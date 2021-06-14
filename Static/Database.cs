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
    }
}