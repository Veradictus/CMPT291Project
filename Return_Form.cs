using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class Return_Form : Form
    {
        private Dictionary<string, string> userInfo;
        public Return_Form(Dictionary<string, string> userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            PopulateBranchList();
        }

        private void PopulateBranchList()
        {
            // Adding branchIDs + names into our drop down ========================================
            _291CarProject.Static.Database.commandStream.CommandText = "select branchID, street from Branch";
            try
            {
                // Run and grab the result from the dataStream
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader();

                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    string branch = "Branch " + _291CarProject.Static.Database.dataStream["branchID"].ToString().Trim()
                        + " - " + _291CarProject.Static.Database.dataStream["street"].ToString().Trim();
                    returnBranchDD.Items.Add(branch);
                }
                _291CarProject.Static.Database.dataStream.Close();
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
        }

        // The back button
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenuForm = new MainMenu(userInfo);
            mainMenuForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Check if the user exists
            if (!_291CarProject.Static.Database.UserExists(cust_tbox.Text)) { return; }
            // Update the search results
            UpdateResultGrid(cust_tbox.Text);
        }

        private void UpdateResultGrid(string userID)
        {
            // Clear it for a new search query
            SearchTransactionGrid.Rows.Clear();

            // Build the query
            string searchCommand = "select R.rentalID, U.[UID], U.userName, R.rentedVID, V.brand, V.model, V.[year], R.dateBooked, R.expRetDate, R.branchBorrow, R.eBranchReturn " +
                "from RentalTransaction as R, [User] as U, Vehicle as V " +
                "where R.userID = U.[UID] and R.rentedVID = V.vehicleID and U.userName = '" + userID + "'and R.aBranchReturn IS NULL";
            try
            {
                _291CarProject.Static.Database.commandStream.CommandText = searchCommand; // Hand over the command
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader(); // run the query

                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    // Throw it all into the search grid
                    SearchTransactionGrid.Rows.Add(_291CarProject.Static.Database.dataStream["rentalID"].ToString(),
                        _291CarProject.Static.Database.dataStream["UID"].ToString(),
                        _291CarProject.Static.Database.dataStream["userName"].ToString(),
                        _291CarProject.Static.Database.dataStream["rentedVID"].ToString(),
                        _291CarProject.Static.Database.dataStream["brand"].ToString(),
                        _291CarProject.Static.Database.dataStream["model"].ToString(),
                        _291CarProject.Static.Database.dataStream["year"].ToString(),
                        _291CarProject.Static.Database.dataStream["dateBooked"].ToString(),
                        _291CarProject.Static.Database.dataStream["expRetDate"].ToString(),
                        _291CarProject.Static.Database.dataStream["branchBorrow"].ToString(),
                        _291CarProject.Static.Database.dataStream["eBranchReturn"].ToString()
                        );
                }
                _291CarProject.Static.Database.dataStream.Close();
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // Check that all fields are filled out
            if (!EmptyFieldCheck()) { return; }
            // Check if the rental transaction ID is real
            if (!_291CarProject.Static.Database.RentalIDCheck(transactionIDBox.Text)) { return; }

            // Create the transaction
            string updateTransaction = UpdateQuery(userInfo);

            // Update the transaction
            _291CarProject.Static.Database.CreateNewTransaction(updateTransaction);

        }

        private string UpdateQuery(Dictionary<string, string> userInfo)
        {
            string dateReturned = DateReorganizer(transactionReturn.Value.ToString("d"));
            string branchID = BranchReader(returnBranchDD.Text);
            string transactionID = transactionIDBox.Text;

            float amountOwed = ReturnAmountPaid(transactionID, branchID, transactionReturn.Value.ToString("d"));
            MessageBox.Show("The amount owed for this rental is = $" + amountOwed);

            // Create the query
            string updateTransaction = "update RentalTransaction " +
                "set empRet = " + userInfo["uid"] + ", actRetDate = " + dateReturned + ", aBranchReturn = " + branchID + ", amountPaid = " + amountOwed +
                " where rentalID = " + transactionID;

            return updateTransaction;
        }

        private float ReturnAmountPaid(string transactionID, string returnBranchID, string dateReturned)
        {
            // We need this for ParseExact
            var canada = new CultureInfo("en-CA");

            // Info on the transaction itself
            Dictionary<string, string> transactionInfo = RentalPaymentDetails(transactionID);
            // Info on the vehicle type
            Dictionary<string, string> vTypeInfo = VehicleRateDetails(transactionInfo["vehicleType"]);
            Debug.Write(transactionInfo["dateBooked"]);

            // Turn the strings to DateTime to get them in the correct format
            DateTime dateBooked = DateTime.ParseExact(transactionInfo["dateBooked"], "G", canada);
            DateTime expReturnDate = DateTime.ParseExact(transactionInfo["expRDate"], "G", canada);

            // The amount we owe
            float totalPayment = 0;

            // Check if the vehicle was returned late
            if (expReturnDate < DateTime.ParseExact(dateReturned, "d", canada)) { totalPayment += float.Parse(vTypeInfo["lateFee"]); }
            // Check if the vehicle was returned to the correct branch
            if (returnBranchID != transactionInfo["expBranch"]) { totalPayment += float.Parse(vTypeInfo["changeCharge"]); }

            totalPayment += CalculateAmountOwed(dateBooked, DateTime.ParseExact(dateReturned, "d", canada), vTypeInfo);
            return totalPayment; // Return the amount owed
        }

        private float CalculateAmountOwed(DateTime dateBooked, DateTime dateReturned, Dictionary<string, string> vTypeInfo)
        {
            float total = 0;

            // Find the length of time in days 
            TimeSpan time = dateReturned.Subtract(dateBooked);
            int numberOfDays = time.Days;

            // Months
            int months = numberOfDays / 30;
            int remainder = numberOfDays % 30;

            total += months * float.Parse(vTypeInfo["monthlyRate"]);

            // Weeks + days
            int weeks = remainder / 4;
            int days = remainder % 4;

            total += weeks * float.Parse(vTypeInfo["weeklyRate"]);
            total += days * float.Parse(vTypeInfo["dailyRate"]);

            return total;
        }

        private Dictionary<string, string> RentalPaymentDetails(string rentalID)
        {
            Dictionary<string, string> newDict = new Dictionary<string, string>();

            try
            {
                _291CarProject.Static.Database.commandStream.CommandText = "select vTypeID, dateBooked, expRetDate, eBranchReturn " +
                "from RentalTransaction where rentalID = " + rentalID; // Hand over the command
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader(); // run the query

                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    newDict.Add("vehicleType", _291CarProject.Static.Database.dataStream["vTypeID"].ToString());
                    newDict.Add("expBranch", _291CarProject.Static.Database.dataStream["eBranchReturn"].ToString());
                    newDict.Add("dateBooked", _291CarProject.Static.Database.dataStream["dateBooked"].ToString());
                    newDict.Add("expRDate", _291CarProject.Static.Database.dataStream["expRetDate"].ToString());
                }
                _291CarProject.Static.Database.dataStream.Close();
                return newDict;

            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }

            return newDict;
        }

        private Dictionary<string, string> VehicleRateDetails(string vehicleType)
        {
            Dictionary<string, string> newDict = new Dictionary<string, string>();

            try
            {
                _291CarProject.Static.Database.commandStream.CommandText = "select dRate, wRate, mRate, lateFee, changeCharge from vehicleType where vTypeID = '" + vehicleType + "'";
                // Hand over the command
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader(); // run the query

                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    newDict.Add("dailyRate", _291CarProject.Static.Database.dataStream["dRate"].ToString());
                    newDict.Add("weeklyRate", _291CarProject.Static.Database.dataStream["wRate"].ToString());
                    newDict.Add("monthlyRate", _291CarProject.Static.Database.dataStream["mRate"].ToString());
                    newDict.Add("lateFee", _291CarProject.Static.Database.dataStream["lateFee"].ToString());
                    newDict.Add("changeCharge", _291CarProject.Static.Database.dataStream["changeCharge"].ToString());
                }
                _291CarProject.Static.Database.dataStream.Close();
                return newDict;
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }

            return newDict;
        }

        private bool EmptyFieldCheck()
        {
            // If one of these is empty, return false
            if (transactionIDBox.Text == "" ||
                returnBranchDD.Text == "")
            {
                MessageBox.Show("One or more required fields have been left empty.");
                return false;
            }
            else { return true; }
        }

        private string DateReorganizer(string dateString)
        {
            string dateHalf = dateString.Substring(0, 10);
            string timeHalf = dateString.Substring(10);

            string[] sections = dateHalf.Split('-');
            sections[0] = sections[0].Substring(2);

            string fixedString = sections[2] + "-" + sections[1] + "-" + sections[0] + " " + timeHalf;
            return fixedString;
        }

        // BranchReader takes our fancy branch option from a drop down box and splits it,
        // grabbing only the ID that we want.
        private string BranchReader(string branchOption)
        {
            string[] sections = branchOption.Split(' ');
            return sections[1];
        }

        // Plz don't delete - idk what this is and I don't want to break the code
        private void Return_Form_Load(object sender, EventArgs e) { }

    }
}
