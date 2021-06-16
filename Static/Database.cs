using System;
using System.Text;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _291CarProject.Static
{
    public static class Database
    {
        private static SqlConnection connection;
        public static SqlCommand commandStream = new SqlCommand();
        public static SqlDataReader dataStream;

        public const string host = "localhost";
        public const string database = "291proDatabase";

        public const string username = "user2";
        public const string password = "pass1";

        public const int timeout = 15; // Connection timeout duration

        public static void CreateConnection()
        {
            connection = new SqlConnection(getConnectionString());

            try
            {
                connection.Open();

                commandStream.Connection = connection;

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString(), "Error");
            }
        }

        public static bool CreateUser(string username, string password, 
            string gender, string firstName, string lastName, 
            string street, string city, string province, string driverLicense)
        {
            bool status = false;

            StringBuilder createUserString = new StringBuilder("INSERT INTO [User] VALUES ('");

            createUserString.Append(username + "', '");
            createUserString.Append(password + "', 'Customer', '");
            createUserString.Append(gender + "', '");
            createUserString.Append(firstName + "', '");
            createUserString.Append(lastName + "', '");
            createUserString.Append(street + "', '");
            createUserString.Append(city + "', '");
            createUserString.Append(province + "')");

            Debug.WriteLine("CreateUserString: " + createUserString.ToString());

            commandStream.CommandText = createUserString.ToString();

            try
            {
                dataStream = commandStream.ExecuteReader();

                dataStream.Close();

                int userId = GetUserId(username);

                if (userId != -1)
                    CreateCustomer(userId, driverLicense);
                else
                    MessageBox.Show("[CreateUser]: An error has occurred :(");

                status = true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            return status;
        }

        /**
         
        --1)
    SELECT firstName +' '+lastName FROM [User]
    WHERE [UID] in (
            SELECT empBorrow FROM RentalTransaction 
            WHERE vTypeID='small' -- Here User specifies (small,medium,Large)
            GROUP BY empBorrow      --Here User specifies empRet or empBorrow
            HAVING COUNT(*) > 1);   --Here user specifies the number for X

         */

        public static List<string> GetHighestTransactionReport(string minimumCount, bool isBorrowing, string vTypeSize)
        {
            List<string> highestTransactionReport = new List<string>();

            string isBorrowingString = isBorrowing ? "empBorrow" : "empRet";

            StringBuilder transactionString = new StringBuilder("SELECT (firstName + ' ' + lastName) AS userFullName FROM [User] ");

            transactionString.Append("WHERE [UID] IN ( SELECT " + isBorrowingString);
            transactionString.Append(" FROM RentalTransaction WHERE vTypeID='" + vTypeSize);
            transactionString.Append("' GROUP BY " + isBorrowingString);
            transactionString.Append(" HAVING COUNT(*) > " + minimumCount + ")");

            commandStream.CommandText = transactionString.ToString();

            Debug.WriteLine("[GetHighestTransactionReport] query: " + commandStream.CommandText);

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    highestTransactionReport.Add(dataStream["userFullName"].ToString());
                }

            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return highestTransactionReport;
        }

        public static bool ArrayContains(List<string> array, string item)
        {
            for (int i = 0; i < array.Count; i++)
                if (array[i].Equals(item))
                    return true;

            return false;
        }

        public static List<string> SizesException(List<string> sizesPicked)
        {
            List<string> newSizes = new List<string>();

            string[] sizes = new string[3] { "small", "medium", "large" };

            for (int i = 0; i < sizes.Length; i++)
            {
                if (ArrayContains(sizesPicked, sizes[i])) continue;

                newSizes.Add(sizes[i]);
            }

            return newSizes;
        }

        /*
 --2)
SELECT (firstName + ' ' + lastName) AS userFullName FROM [User] as U, Customer as C, RentalTransaction R1 
WHERE membership='Gold' AND R1.vTypeID='medium' AND R1.vTypeID='small' AND exists( --User will specify the type of member (Gold or Regular)
                    (SELECT vTypeID FROM VehicleType WHERE vTypeID='large') --"haven't used large or medium
                    EXCEPT
                    (SELECT vTypeID FROM RentalTransaction as R
                    WHERE R.userID=C.customerID)) AND U.[UID]=C.customerID;

//picked small

*/

        public static List<string> GetVehicleTypesNotUsed(string membership, List<string> sizesPicked)
        {
            List<string> fullNames = new List<string>();

            StringBuilder vehicleUsageString = new StringBuilder("SELECT DISTINCT  (U.firstName + ' ' + U.lastName) AS userFullName FROM [User] as U, Customer as C, RentalTransaction R1 ");

            vehicleUsageString.Append("WHERE membership='" + membership + "' AND ");
            vehicleUsageString.Append("R1.vTypeID='" + sizesPicked[0] + "' AND ");

            if (sizesPicked.Count > 1)
            {
                for (int i = 1; i < sizesPicked.Count; i++)
                    vehicleUsageString.Append("R1.vTypeID='" + sizesPicked[i] + "' AND ");
            }

            vehicleUsageString.Append("exists((SELECT vTypeID FROM VehicleType ");

            List<string> sizeException = SizesException(sizesPicked);

            int index = 0;

            foreach (string size in sizeException)
            {
                if (index == 0)
                    vehicleUsageString.Append("WHERE ");

                vehicleUsageString.Append("vTypeID='" + size + "'");

                if (sizeException.Count > 1 && index < sizeException.Count - 1)
                    vehicleUsageString.Append(" OR ");

                index++;
            }

            vehicleUsageString.Append(") EXCEPT (SELECT vTypeID FROM RentalTransaction as R2 WHERE R2.userID=R1.userID)) ");
            vehicleUsageString.Append("AND U.[UID]=R1.userID");

            commandStream.CommandText = vehicleUsageString.ToString();

            Debug.WriteLine("[GetVehicleTypesNotUsed] query: " + commandStream.CommandText);

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    fullNames.Add(dataStream["userFullName"].ToString());
                }

            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return fullNames;
        }

        /**
         select B.branchID, max(temp.branchCount) as difBranchCount from Branch as B, 
(select count(branchID) as branchCount, branchID as BID from Branch as B, RentalTransaction as R, Customer as C 
where R.userID = C.customerID and B.branchID = R.aBranchReturn and B.branchID != R.eBranchReturn
and C.membership = 'Regular' group by branchID) as temp
where B.branchID = temp.BID and B.prov = 'AB' -- Switch prov to city and vice versa depending on what you want
group by B.branchID

         */

        public static Dictionary<string, string> GetBranchChangeFee(bool most, bool isCity, string value)
        {
            Dictionary<string, string> changeFees = new Dictionary<string, string>();

            StringBuilder branchFeeString = new StringBuilder("SELECT B.branchID, ");

            branchFeeString.Append((most ? "max" : "min") + "(temp.branchCount) AS difBranchCount ");
            branchFeeString.Append("FROM Branch as B, (SELECT COUNT(branchID) as branchCount, branchID ");
            branchFeeString.Append("AS BID FROM Branch AS B, RentalTransaction as R, Customer as C WHERE R.userID");
            branchFeeString.Append("=C.customerId AND B.branchID");
            branchFeeString.Append("= R.aBranchReturn AND B.branchID != R.eBranchReturn AND C.membership=");
            branchFeeString.Append("'Regular' GROUP BY branchID) AS temp WHERE B.branchId = temp.BID AND B.");
            branchFeeString.Append((isCity ? "city" : "prov") + "='" + value + "' GROUP BY B.branchID");

            commandStream.CommandText = branchFeeString.ToString();

            Debug.WriteLine("[BranchChangeFee] query: " + commandStream.CommandText);

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    changeFees.Add(dataStream["branchID"].ToString(), dataStream["difBranchCount"].ToString());
                }


            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return changeFees;
        }

        /*
         
        select avg(R.amountPaid) as avgSpent from RentalTransaction as R, Customer as U
        where R.userID = U.customerID and U.membership = 'Gold' and R.aBranchReturn = 1 and
        (dateBooked between convert(datetime,'12-06-21 10:34:09 PM',5) and convert(datetime,'12-06-21 10:34:09 PM',5)) or 
        (expRetDate between convert(datetime,'12-06-21 10:34:09 PM',5) and convert(datetime,'12-06-21 10:34:09 PM',5)) or
        (dateBooked > convert(datetime,'12-06-21 10:34:09 PM',5) and expRetDate < convert(datetime,'12-06-21 10:34:09 PM',5))

         */

        public static List<string> GetAverageSpending(bool isGold, string startDate, string endDate)
        {
            List<string> averageSpending = new List<string>();

            StringBuilder averageSpendingString = new StringBuilder("SELECT AVG(R.amountPaid) AS avgSpent FROM RentalTransaction as R, ");

            averageSpendingString.Append("Customer AS U WHERE R.userID = U.customerId AND U.membership = '");
            averageSpendingString.Append((isGold ? "Gold" : "Regular") + "' AND R.aBranchReturn = 1 AND (dateBooked between convert(");
            averageSpendingString.Append("datetime, '" + startDate + "', 5) and convert(datetime, '" + endDate + "',5)) or ");
            averageSpendingString.Append("(expRetDate between convert(datetime, '" + startDate + "',5) and convert(datetime, '");
            averageSpendingString.Append(endDate + "',5)) or (dateBooked > convert(datetime, '" + startDate + "',5) and expRetDate <");
            averageSpendingString.Append("convert(datetime, '" + endDate + "',5))");

            commandStream.CommandText = averageSpendingString.ToString();

            Debug.WriteLine("[GetAverageSpending] query: " + commandStream.CommandText);

            try
            {

                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    averageSpending.Add(dataStream["avgSpent"].ToString());
                }

            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return averageSpending;
        }

        public static Dictionary<string, string> GetUserInfo(string username)
        {
            Dictionary<string, string> infoDictionary = new Dictionary<string, string>();

            commandStream.CommandText = "SELECT * FROM [User] WHERE userName='" + username + "'";

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                 
                    infoDictionary.Add("uid", dataStream["UID"].ToString());
                    infoDictionary.Add("userName", dataStream["userName"].ToString());
                    infoDictionary.Add("userType", dataStream["userType"].ToString());
                    infoDictionary.Add("firstName", dataStream["firstName"].ToString());
                    infoDictionary.Add("lastName", dataStream["lastName"].ToString());
                    
                    dataStream.Close();

                    if (infoDictionary["userType"].Equals("Employee"))
                    {
                        Dictionary<string, string> branchInformation = GetEmployeeBranchInfo(infoDictionary["uid"]);

                        infoDictionary.Add("branchId", branchInformation["branchId"]);
                        infoDictionary.Add("street", branchInformation["street"]);
                        infoDictionary.Add("city", branchInformation["city"]);
                        infoDictionary.Add("prov", branchInformation["prov"]);
                        infoDictionary.Add("phoneNumber", branchInformation["phoneNumber"]);
                    }

                    if (infoDictionary["userType"].Equals("Customer"))
                    {
                        bool isGoldMember = IsGoldMember(username);

                        string goldMemberString = isGoldMember ? "Gold" : "Regular";

                        infoDictionary.Add("goldMember", goldMemberString);
                    }

                    return infoDictionary;
                }

            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return infoDictionary;
        }

        public static Dictionary<string, string> GetVehicleInfo(string vehicleID)
        {
            Dictionary<string, string> infoDictionary = new Dictionary<string, string>();
            
            commandStream.CommandText = "SELECT * FROM Vehicle WHERE vehicleID=" + vehicleID;

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {

                    infoDictionary.Add("vid", dataStream["vehicleID"].ToString());
                    infoDictionary.Add("milage", dataStream["milage"].ToString());
                    infoDictionary.Add("brand", dataStream["brand"].ToString());
                    infoDictionary.Add("model", dataStream["model"].ToString());
                    infoDictionary.Add("year", dataStream["[year]"].ToString());
                    infoDictionary.Add("branchID", dataStream["branchID"].ToString());
                    infoDictionary.Add("vTypeID", dataStream["vTypeID"].ToString());

                    dataStream.Close();
                    return infoDictionary;
                }

            }
            catch (Exception e) { Debug.WriteLine(e.ToString()); }

            dataStream.Close();
            return infoDictionary;
        }

        public static Dictionary<string, string> GetEmployeeBranchInfo(string employeeId)
        {
            Dictionary<string, string> infoDictionary = new Dictionary<string, string>();

            commandStream.CommandText = "SELECT * FROM Employee WHERE employID=" + employeeId;

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    string branchId = dataStream["branchID"].ToString();

                    dataStream.Close();

                    return GetBranchInfo(branchId);
                }

            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return infoDictionary;
        }

        public static Dictionary<string, string> GetBranchInfo(string branchId)
        {
            Dictionary<string, string> infoDictionary = new Dictionary<string, string>();

            commandStream.CommandText = "SELECT * FROM Branch WHERE branchID=" + branchId;

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    infoDictionary.Add("branchId", dataStream["branchID"].ToString());
                    infoDictionary.Add("street", dataStream["street"].ToString());
                    infoDictionary.Add("city", dataStream["city"].ToString());
                    infoDictionary.Add("prov", dataStream["prov"].ToString());
                    infoDictionary.Add("phoneNumber", dataStream["phoneNumber"].ToString());
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return infoDictionary;
        }

        public static bool IsGoldMember(string username)
        {
            bool status = false;

            int userId = GetUserId(username);

            if (userId == -1) return false;

            string currentYear = DateTime.Now.ToString("yyyy");
            string currentMonth = DateTime.Now.ToString("MM");
            string currentDay = DateTime.Now.ToString("dd");

            StringBuilder lastYearFormat = new StringBuilder((int.Parse(currentYear) - 1).ToString());

            lastYearFormat.Append("-" + currentMonth);
            lastYearFormat.Append("-" + currentDay);

            commandStream.CommandText = "SELECT COUNT(*) AS count FROM RentalTransaction WHERE dateBooked > " + lastYearFormat.ToString();

            try
            {

                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    int count = int.Parse(dataStream["count"].ToString());

                    Debug.WriteLine("User has had " + count.ToString() + " rental transaction in the past year.");

                    if (count > 2)
                        status = true;
                }

            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return status;
        }

        public static bool CreateCustomer(int customerId, string driverLicense)
        {
            bool status = false;

            StringBuilder createCustomerString = new StringBuilder("INSERT INTO Customer VALUES ('");

            createCustomerString.Append(customerId.ToString() + "', '");
            createCustomerString.Append(driverLicense + "', 'Regular')");

            Debug.WriteLine("CreateCustomerString: " + createCustomerString);

            commandStream.CommandText = createCustomerString.ToString();

            try
            {
                dataStream = commandStream.ExecuteReader();

            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return status;
        }
        public static int GetUserId(string username)
        {
            int userId = -1;

            commandStream.CommandText = "SELECT UID FROM [User] WHERE userName='" + username + "'";

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    string UID = dataStream["UID"].ToString();

                    userId = int.Parse(UID);
                }


            } catch (Exception e)
            {
                Debug.WriteLine("[GetUserId] An error has occurred");
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return userId;
        }

        public static bool UserExists(string username)
        {
            bool status = false;

            commandStream.CommandText = "SELECT * FROM [User] WHERE userName='" + username + "'";

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    string dataStreamUsername = dataStream["userName"].ToString();

                    if (dataStream["userName"].ToString().Equals(username, StringComparison.OrdinalIgnoreCase))
                        status = true;
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("[UserExists] An error has occurred");
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return status;
        }

        public static bool VerifyPassword(string username, string password)
        {
            bool status = false;

            commandStream.CommandText = "SELECT * FROM [User] WHERE userName='" + username + "'";

            try
            {
                dataStream = commandStream.ExecuteReader();

                while (dataStream.Read())
                {
                    if (!dataStream["userName"].ToString().Equals(username, StringComparison.OrdinalIgnoreCase))
                        break;

                    if (!dataStream["passw"].ToString().Equals(password))
                        break;

                    status = true;
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occurred");
                Debug.WriteLine(e.ToString());
            }

            dataStream.Close();

            return status;
        }

        private static string getConnectionString()
        {
            StringBuilder connectionString = new StringBuilder("user id=");

            connectionString.Append(username + ";password=");
            connectionString.Append(password + ";server=");
            connectionString.Append(host + ";database=");
            connectionString.Append(database + ";connection timeout=");
            connectionString.Append(timeout);

            return connectionString.ToString();
        }

        /*
         * AUR/Search Screen/Borrow+Return stuff below
         */
        public static bool CreateNewTransaction(string newQuery)
        {
            if (newQuery == "" || newQuery == null) { return false; }

            try
            {
                // Build the command text here
                commandStream.CommandText = newQuery;
                // Message box feat. our query
                MessageBox.Show(commandStream.CommandText.ToString());
                // Send it along to the server
                commandStream.ExecuteNonQuery();
                // We added it
                return true;
            }
            // Error catching
            catch (Exception e2)
            { MessageBox.Show(e2.ToString(), "Error"); }

            return false;
        }

        internal static void GoldMembershipCheck(string userName)
        {
            // Check if the userID is real
            //if (userName == "" || int.Parse(userName) == 0) { return; }
            // Check for gold status
            if (IsGoldMember(userName)) { UpdateGoldStatus(userName); }

        }

        private static void UpdateGoldStatus(string userName)
        {
            // Get the user's ID
            int userId = GetUserId(userName);
            try
            {
                commandStream.CommandText = "update Customer set membership = 'Gold' where customerID = " + userId;
                // Send it along to the server
                commandStream.ExecuteNonQuery();
            }
            // Error catching
            catch (Exception e2)
            { MessageBox.Show(e2.ToString(), "Error"); }
        }

        public static bool VIDCheck(string vID)
        {
            // Check if we even got a vehicle ID to look for
            if (vID == "" || int.Parse(vID) == 0)
            {
                MessageBox.Show("Please enter a valid vehicle ID.");
                return false;
            }

            try
            {
                commandStream.CommandText = "select vehicleID as Found from Vehicle where vehicleID = " + vID;
                // Run and grab the result from the dataStream
                dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader();
                dataStream.Read();
                if (!dataStream.HasRows)
                {
                    MessageBox.Show("Vehicle ID not-existent.\r\nPlease enter an existing vehicle ID.");
                    dataStream.Close(); // close
                    return false;
                }
                // Otherwise, it's real
                dataStream.Close(); // close
                return true;
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
            // We have to return something out here
            return false;
        }

        public static bool RentalIDCheck(string rentalID)
        {
            // Check if we even got a vehicle ID to look for
            if (rentalID == "" || int.Parse(rentalID) == 0)
            {
                MessageBox.Show("Please enter a valid Rental Transaction ID.");
                return false;
            }

            try
            {
                commandStream.CommandText = "select rentalID as Found from RentalTransaction where rentalID = " + rentalID;
                // Run and grab the result from the dataStream
                dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader();
                dataStream.Read();
                if (!dataStream.HasRows)
                {
                    MessageBox.Show("Rental Transaction ID not-existent.\r\nPlease enter a valid Rental Transaction ID.");
                    dataStream.Close(); // close
                    return false;
                }
                // Otherwise, it's real
                dataStream.Close(); // close
                return true;
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
            // We have to return something out here
            return false;
        }
    }
}