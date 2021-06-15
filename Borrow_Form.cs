using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            // Start filling the query out
            string timeFrom = DateReorganizer(dateFrom.Value.ToString("d"));
            string timeTo = DateReorganizer(dateTo.Value.ToString("d"));
            Dictionary<string, string> userInfo = _291CarProject.Static.Database.GetUserInfo(cust_tbox.Text);

            string newTransaction = "insert into RentalTransaction (userID, rentedVID, vTypeID, branchBorrow, eBranchReturn, dateBooked, expRetDate) " +
                "values + (" + userInfo["uid"] + "," + veh_text_box.Text + ",'" + vTypeDropDown.Text + "'," + userInfo["branchID"] + "," + expReturnDD.Text + "," + timeFrom + "," + timeTo + ")";

            // Hand it to the function in the database to add the transanction
            _291CarProject.Static.Database.CreateNewTransaction(newTransaction);
            _291CarProject.Static.Database.GoldMembershipCheck(userInfo["userName"]);
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
            return fixedString;
        }
    }
}
