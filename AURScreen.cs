﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class AURScreen : Form
    {

        private Dictionary<string, string> userInfo;
        public AURScreen(Dictionary<string, string> userInfo)
        {
            InitializeComponent();

            // Clear then populate all dropdowns
            DropDownClear();
            DropDownPopulate();

            this.userInfo = userInfo;
        }

        private void DropDownPopulate()
        {
            // Adding branchIDs + names into our drop down
            _291CarProject.Static.Database.commandStream.CommandText = "select branchID, street from Branch";
            try
            {
                // Run and grab the result from the dataStream
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader();

                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    string branch = _291CarProject.Static.Database.dataStream["branchID"].ToString()
                        + " - Branch " + _291CarProject.Static.Database.dataStream["street"].ToString();
                    DD_AddBranch.Items.Add(branch);
                    DD_UpdateBranch.Items.Add(branch);
                }
                _291CarProject.Static.Database.dataStream.Close();
            }
            // Error catching
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            // Adding Sizes/Types into our drop down
            _291CarProject.Static.Database.commandStream.CommandText = "select vTypeID from VehicleType";
            try
            {
                // Run and grab the result from the dataStream
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader();

                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    DD_AddSize.Items.Add(_291CarProject.Static.Database.dataStream["vTypeID"].ToString());
                    DD_UpdateSize.Items.Add(_291CarProject.Static.Database.dataStream["vTypeID"].ToString());
                }
                _291CarProject.Static.Database.dataStream.Close();
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
        }

        private void DropDownClear()
        {
            DD_AddBranch.Items.Clear();
            DD_AddSize.Items.Clear();
            DD_UpdateBranch.Items.Clear();
            DD_UpdateSize.Items.Clear();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenu = new MainMenu(userInfo);

            mainMenu.Show();
        }

        /* ========================================================================================
         * Add Side
         * In Add, we add a new vehicle to our database.
         * The vehicle ID is generated by this script
         * All input fields are required; we cannot have an empty or null value.
        ======================================================================================= */
        private void AddConfirm_Click(object sender, EventArgs e)
        {
            // If any of our inputs are illegal, end the function immediately
            if (!InputCheck_Add()) { return; }

            try
            {
                // Build the command text here
                _291CarProject.Static.Database.commandStream.CommandText = "insert into Vehicle (vTypeID, milage, brand, model, [year], branchID) values " +
                    "('" + DD_AddSize.Text + "'," + TB_AddMilage.Text + ",'" + TB_AddBrand.Text + "','" + TB_AddModel.Text + "'," + TB_AddYear.Text + "," +
                    BranchReader(DD_AddBranch.Text) + ")";
                // Message box feat. our query
                MessageBox.Show(_291CarProject.Static.Database.commandStream.CommandText.ToString());
                // Send it along to the server
                _291CarProject.Static.Database.commandStream.ExecuteNonQuery();
            }
            // Error catching
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private bool InputCheck_Add()
        {
            string message;
            // Check to see if any of our fields are empty.
            if (TB_AddBrand.Text == "" ||
                TB_AddModel.Text == "" ||
                DD_AddSize.Text == "" ||
                DD_AddBranch.Text == "" ||
                TB_AddYear.Text == "" ||
                TB_AddMilage.Text == "")
            {
                // If any of them are empty, return an 'error' message
                message = "One or more mandatory fields are empty." +
                    "\r\nPlease make sure all fields are filled out before" +
                    "\r\nadding a new entry.";
                MessageBox.Show(message);
                return false; // End the function here.
            }

            // Check that the year and milage are legal int values
            int yearCheck = int.Parse(TB_AddYear.Text);
            int milageCheck = int.Parse(TB_AddMilage.Text);

            // Check if year and/or milage have a char in them
            if (yearCheck == 0 || milageCheck == 0)
            {
                message = "Year and/or Milage possess illegal values." +
                    "\r\nPlease make sure these fields are integers.";
                MessageBox.Show(message);
                return false; // End the function here.
            }

            // Else, return true
            return true;
        }

        /* ========================================================================================
         * Update Side
         * In Update, we can change values for a vehicle.
         * If a field is left empty, we assume it is NOT to be updated and thus
         * will be left alone
         ======================================================================================= */
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // If any of our inputs are illegal, end the function immediately
            if (!InputCheck_Update()) { return; }

            // Build the update SQL command here
            StringBuilder updateSQLQuery = GenerateUpdateQuery();

            try
            {
                _291CarProject.Static.Database.commandStream.CommandText = updateSQLQuery.ToString();
                _291CarProject.Static.Database.commandStream.ExecuteNonQuery(); // run the query and update the entry
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
        }

        private StringBuilder GenerateUpdateQuery()
        {
            bool cFlag = false; // The comma flag, used to tell when to add a comma , to the query
            StringBuilder updateCommand = new StringBuilder("Update Vehicle set ");

            // Size
            if (DD_UpdateSize.Text != "")
            {
                updateCommand.Append("vTypeID = '" + DD_UpdateSize.Text + "'");
                cFlag = true;
            }
            // Milage
            if (TB_UpdateMilage.Text != "")
            {
                // If we added a change to the model, make sure to add a comma here
                if (cFlag)
                {
                    updateCommand.Append(",");
                    cFlag = false;
                }
                updateCommand.Append("milage = " + TB_UpdateMilage.Text);
                cFlag = true;
            }
            // Brand
            if (TB_UpdateBrand.Text != "")
            {
                // If we added a change to the model, make sure to add a comma here
                if (cFlag)
                {
                    updateCommand.Append(",");
                    cFlag = false;
                }
                updateCommand.Append("brand = '" + TB_UpdateBrand.Text + "'");
                cFlag = true;
            }
            // Model
            if (TB_UpdateModel.Text != "")
            {
                // If we added a change to the model, make sure to add a comma here
                if (cFlag)
                {
                    updateCommand.Append(",");
                    cFlag = false;
                }
                updateCommand.Append("model = '" + TB_UpdateModel.Text + "'");
                cFlag = true;
            }
            // Year
            if (TB_UpdateYear.Text != "")
            {
                // If we added a change to the model, make sure to add a comma here
                if (cFlag)
                {
                    updateCommand.Append(",");
                    cFlag = false;
                }
                updateCommand.Append("year = " + TB_UpdateYear.Text);
                cFlag = true;
            }
            // Branch
            if (DD_UpdateBranch.Text != "")
            {
                // If we added a change to the model, make sure to add a comma here
                if (cFlag) { updateCommand.Append(","); }
                updateCommand.Append("branchID = " + BranchReader(DD_UpdateBranch.Text));
            }
            // Finally, add the Where
            updateCommand.Append(" where vehicleID = " + TB_UpdateID.Text);
            MessageBox.Show(updateCommand.ToString());
            return updateCommand;
        }

        private bool InputCheck_Update()
        {
            if (!_291CarProject.Static.Database.VIDCheck(TB_UpdateID.Text)) { return false; }

            string message; // Used for error messages

            // Check to see if ALL fields are empty.
            if (TB_UpdateModel.Text == "" &
                DD_UpdateSize.Text == "" &
                TB_UpdateYear.Text == "" &
                TB_UpdateMilage.Text == "" &
                TB_UpdateBrand.Text == "" &
                DD_UpdateBranch.Text == "")
            {
                // For this one, we just return false
                return false; // End the function here.
            }

            // Check that the year and milage are legal int values
            // This time, we do it seperately cause one might not be updated
            if (TB_UpdateYear.Text != "")
            {
                int yearCheck = int.Parse(TB_UpdateYear.Text);
                if (yearCheck == 0)
                {
                    message = "Illegal value in the Year field." +
                    "\r\nPlease make sure this field is an integer.";
                    MessageBox.Show(message);
                    return false; // End the function here.
                }
            }
            if (TB_UpdateMilage.Text != "")
            {
                int yearCheck = int.Parse(TB_UpdateMilage.Text);
                if (yearCheck == 0)
                {
                    message = "Illegal value in the Milage field." +
                        "\r\nPlease make sure this field is an integer.";
                    MessageBox.Show(message);
                    return false; // End the function here.
                }
            }

            // Else, return true
            return true;
        }

        private void uSearchButton_Click(object sender, EventArgs e)
        {
            // Check if the vehicle exists
            if (!_291CarProject.Static.Database.VIDCheck(TB_UpdateID.Text)) { return; }

            try
            {
                _291CarProject.Static.Database.commandStream.CommandText = "select * from Vehicle where vehicleID = " + TB_UpdateID.Text;
                // Run and grab the result from the dataStream
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader();
                _291CarProject.Static.Database.dataStream.Read(); // Read

                // Set the fields
                DD_UpdateSize.Text = _291CarProject.Static.Database.dataStream["vTypeID"].ToString(); ;
                TB_UpdateMilage.Text = _291CarProject.Static.Database.dataStream["milage"].ToString();
                TB_UpdateBrand.Text = _291CarProject.Static.Database.dataStream["brand"].ToString();
                TB_UpdateModel.Text = _291CarProject.Static.Database.dataStream["model"].ToString();
                TB_UpdateYear.Text = _291CarProject.Static.Database.dataStream["year"].ToString();
                DD_UpdateBranch.Text = _291CarProject.Static.Database.dataStream["branchID"].ToString();

                _291CarProject.Static.Database.dataStream.Close(); // Close
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
        }

        /* ========================================================================================
         * Remove Side
         * In Update, we receive a vehicle ID and remove its entry from the Vehicle table
         * An existing vehicle ID is required for this to work.
         ======================================================================================= */
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Make double sure we want to delete the vehicle
            if (!checkBoxConfirm.Checked)
            {
                MessageBox.Show("Please check the confirmation check box before deleting a vehicle.");
                return;
            }

            // If any of our inputs are illegal, end the function immediately
            if (!InputCheck_Remove()) { return; }

            try
            {
                _291CarProject.Static.Database.commandStream.CommandText = "delete from Vehicle where vehicleID = " + TB_RemoveVID.Text;
                // Message box feat. our query
                MessageBox.Show(_291CarProject.Static.Database.commandStream.CommandText.ToString());
                _291CarProject.Static.Database.commandStream.ExecuteNonQuery(); // run the query and remove the entry
                checkBoxConfirm.Checked = false;
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
        }

        private bool InputCheck_Remove()
        {
            return _291CarProject.Static.Database.VIDCheck(TB_RemoveVID.Text);
        }

        // BranchReader takes our fancy branch option from a drop down box and splits it,
        // grabbing only the ID that we want.
        private string BranchReader(string branchOption)
        {
            string[] sections = branchOption.Split(' ');
            return sections[0];
        }

        // NOTE - DO NOT DELETE THIS OR IT'LL BREAK
        private void AURScreen_Load(object sender, EventArgs e) { }
    }
}
