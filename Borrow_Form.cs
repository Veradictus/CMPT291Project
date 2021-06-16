using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class Borrow_Form : Form
    {
        private Dictionary<string, string> userInfo;

        public Borrow_Form(Dictionary<string, string> userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            PopulateVType();
            PopulateBranchList();
        }


        private void PopulateVType()
        {
            _291CarProject.Static.Database.commandStream.CommandText = "select vTypeID from VehicleType";
            try
            {
                // Run and grab the result from the dataStream
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader();

                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    vTypeDropDown.Items.Add(_291CarProject.Static.Database.dataStream["vTypeID"].ToString());
                }
                _291CarProject.Static.Database.dataStream.Close();
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
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
                    expReturnDD.Items.Add(branch);
                }
                _291CarProject.Static.Database.dataStream.Close();
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenuForm = new MainMenu(userInfo);

            mainMenuForm.Show();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // Check that all fields are filled out
            if (!EmptyFieldCheck()) { return; }
            // Check if the vID is real
            if (!_291CarProject.Static.Database.VIDCheck(veh_text_box.Text)) { return; }
            // Check if the user exists
            if (!_291CarProject.Static.Database.UserExists(cust_tbox.Text)) { return; }

            if (!CheckVehicleBranch(userInfo)) { return; }

            if (!CheckForCopies(userInfo)) { return; }
            // Fill the query out
            string newTransaction = CreateNewTransaction(userInfo);
            Debug.WriteLine(newTransaction);

            // Hand it to the function in the database to add the transanction
            _291CarProject.Static.Database.NewORUpdateQuery(newTransaction);
            _291CarProject.Static.Database.GoldMembershipCheck(cust_tbox.Text);
        }

        private bool CheckVehicleBranch(Dictionary<string, string> userInfo)
        {
            string vCheckQuery = "select vehicleID from Vehicle where vehicleID = " + veh_text_box.Text + " and branchID = " + userInfo["branchId"];

            bool check = _291CarProject.Static.Database.VehicleBranchCheck(vCheckQuery);

            return check;
        }

        private bool CheckForCopies(Dictionary<string, string> userInfo)
        {
            string timeFrom = DateReorganizer(dateFrom.Value.ToString("G"));
            string timeTo = DateReorganizer(dateTo.Value.ToString("G"));

            string copyCheckQuery = "select rentedVID from RentalTransaction where rentedVID = " + veh_text_box.Text + " and rentedVID in " +
                "((select rentedVID from RentalTransaction where amountPaid is null and actRetDate is null and empRet is null and aBranchReturn is null) " +
                "intersect " +
                "(select rentedVID from RentalTransaction where amountPaid is not null and " +
                "(dateBooked between " + timeFrom + " and " + timeTo + ") or " +
                "(expRetDate between " + timeFrom + " and " + timeTo + ") or " +
                "(dateBooked > " + timeFrom + " and expRetDate < " + timeTo + ")))";

            // Check here if it's TRUE (legal rental) or FALSE (car is unavailable)
            bool check = _291CarProject.Static.Database.vIDTransaction(copyCheckQuery);
            return check;
        }

        private string CreateNewTransaction(Dictionary<string, string> userInfo)
        {
            // Start filling the query out
            string timeFrom = DateReorganizer(dateFrom.Value.ToString("G"));
            string timeTo = DateReorganizer(dateTo.Value.ToString("G"));
            string returnBranch = BranchReorganizer(expReturnDD.Text);
            // Get the customer's info here
            Dictionary<string, string> customerInfo = _291CarProject.Static.Database.GetUserInfo(cust_tbox.Text);

            // Put it together
            string newTransaction = "insert into RentalTransaction (userID, rentedVID, vTypeID, empBorrow, branchBorrow, eBranchReturn, dateBooked, expRetDate) " +
                "values (" + customerInfo["uid"] + "," + veh_text_box.Text + ",'" + vTypeDropDown.Text + "'," + userInfo["uid"] + "," + userInfo["branchId"] + "," + returnBranch + "," + timeFrom + "," + timeTo + ")";

            return newTransaction;
        }

        private string BranchReorganizer(string text)
        {
            string[] branchSplit = text.Split(" ");
            return branchSplit[1];
        }

        private bool EmptyFieldCheck()
        {
            // If one of these is empty, return false
            if (veh_text_box.Text == "" ||
                vTypeDropDown.Text == "" ||
                cust_tbox.Text == "" ||
                expReturnDD.Text == "")
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
            string completeString = "convert(datetime, '" + fixedString + "', 5)";
            return completeString;
        }
    }
}
