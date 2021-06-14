using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            string dateReturned = DateReorganizer(transactionReturn.Value.ToString());
            string branchID = BranchReader(returnBranchDD.Text);

            string updateTransaction = "update RentalTransaction " +
                "set actRetDate = " + dateReturned + ", aBranchReturn = " + returnBranchDD.Text + 
                "where rentalID = " + branchID;

            try
            {
                _291CarProject.Static.Database.commandStream.CommandText = updateTransaction;
                _291CarProject.Static.Database.commandStream.ExecuteNonQuery(); // run the query and update the entry
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
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
