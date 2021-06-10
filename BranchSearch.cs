using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class BranchSearch : Form
    {
        public BranchSearch()
        {
            InitializeComponent();

            // Clear then populate all dropdowns
            DropDownClear();
            DropDownPopulate();
        }

        private void DropDownPopulate()
        {
            // Adding branchIDs + names into our drop down ========================================
            _291CarProject.Static.Database.commandStream.CommandText = "select branchID, street from Branch";
            try
            {
                // Run and grab the result from the dataStream
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader();

                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    string branch = _291CarProject.Static.Database.dataStream["branchID"].ToString()
                        + " - Branch " + _291CarProject.Static.Database.dataStream["street"].ToString();
                    branchSelector.Items.Add(branch);
                }
                _291CarProject.Static.Database.dataStream.Close();
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }

            // Adding Sizes/Types into our drop down ==============================================
            _291CarProject.Static.Database.commandStream.CommandText = "select vTypeID from VehicleType";
            try
            {
                // Run and grab the result from the dataStream
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader();

                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    sizeSelector.Items.Add(_291CarProject.Static.Database.dataStream["vTypeID"].ToString());
                }
                _291CarProject.Static.Database.dataStream.Close();
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }

            // Adding vehicle info into our drop down boxes =======================================
            DDPopulate_Distinct("brand", brandSelector);
            DDPopulate_Distinct("model", modelSelector);
            DDPopulate_Distinct("year", yearSelector);
        }

        private void DDPopulate_Distinct(string dAttribute, ComboBox dropDownBox)
        {
            // Create the command text
            _291CarProject.Static.Database.commandStream.CommandText = "select distinct " + dAttribute + " from Vehicle";
            MessageBox.Show(_291CarProject.Static.Database.commandStream.CommandText);

            try
            {
                // Run and grab the result from the dataStream
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader();
                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    dropDownBox.Items.Add(_291CarProject.Static.Database.dataStream[dAttribute].ToString());
                }
                _291CarProject.Static.Database.dataStream.Close();
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }
        }

        // Empty all the drop down boxes + the result grid
        private void DropDownClear()
        {
            SearchResultGrid.Rows.Clear();
            branchSelector.Items.Clear();
            sizeSelector.Items.Clear();
            brandSelector.Items.Clear();
            modelSelector.Items.Clear();
            yearSelector.Items.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenuForm = new MainMenu();

            mainMenuForm.Show();
        }

        private void updateSearchButton_Click(object sender, EventArgs e)
        {
            SearchResultGrid.Rows.Clear();
            string searchCommand = SearchQueryGenerator();
            UpdateResultGrid(searchCommand);
        }

        private void UpdateResultGrid(string searchCommand)
        {
            try
            {
                _291CarProject.Static.Database.commandStream.CommandText = searchCommand; // Hand over the command
                _291CarProject.Static.Database.dataStream = _291CarProject.Static.Database.commandStream.ExecuteReader(); // run the query

                while (_291CarProject.Static.Database.dataStream.Read())
                {
                    SearchResultGrid.Rows.Add(_291CarProject.Static.Database.dataStream["vehicleID"].ToString(),
                        _291CarProject.Static.Database.dataStream["brand"].ToString(),
                        _291CarProject.Static.Database.dataStream["model"].ToString(),
                        _291CarProject.Static.Database.dataStream["year"].ToString(),
                        _291CarProject.Static.Database.dataStream["branchID"].ToString(),
                        _291CarProject.Static.Database.dataStream["vTypeID"].ToString(),
                        _291CarProject.Static.Database.dataStream["dRate"].ToString(),
                        _291CarProject.Static.Database.dataStream["wRate"].ToString(),
                        _291CarProject.Static.Database.dataStream["mRate"].ToString()
                        );
                }
                _291CarProject.Static.Database.dataStream.Close();
            }
            // Error catching
            catch (Exception e2) { MessageBox.Show(e2.ToString(), "Error"); }

        }

        private string SearchQueryGenerator()
        {
            bool andFlag = false; // The comma flag, used to tell when to add a comma , to the query
            StringBuilder searchCommand = new StringBuilder("Select V.vehicleID, V.branchID, V.vTypeID, V.brand, V.model, V.year," +
                "T.dRate, T.wRate, T.mRate from Vehicle as V, VehicleType as T where V.vTypeID = T.vTypeID");

            // The where flag, used to tell if we should add a Where to the query or not
            // If there's no Where to specify, return what we got
            if (!AndCheck()) { return searchCommand.ToString(); }
            // If we do have a where, let's add it
            searchCommand.Append(" and ");

            // Now start adding each query option one by one
            // Branch
            if (branchSelector.Text != "")
            {
                searchCommand.Append("branchID = " + BranchReader(branchSelector.Text));
                andFlag = true;
            }
            // Size
            if (sizeSelector.Text != "")
            {
                // If we added a change to the model, make sure to add a comma here
                if (andFlag)
                {
                    searchCommand.Append(" and ");
                    andFlag = false;
                }
                searchCommand.Append("V.vTypeID = '" + sizeSelector.Text + "'");
                andFlag = true;
            }
            // Brand
            if (brandSelector.Text != "")
            {
                // If we added a change to the model, make sure to add a comma here
                if (andFlag)
                {
                    searchCommand.Append(" and ");
                    andFlag = false;
                }
                searchCommand.Append("brand = '" + brandSelector.Text + "'");
                andFlag = true;
            }
            // Model
            if (modelSelector.Text != "")
            {
                // If we added a change to the model, make sure to add a comma here
                if (andFlag)
                {
                    searchCommand.Append(" and ");
                    andFlag = false;
                }
                searchCommand.Append("model = '" + modelSelector.Text + "'");
                andFlag = true;
            }
            // Year
            if (yearSelector.Text != "")
            {
                // If we added a change to the model, make sure to add a comma here
                if (andFlag) { searchCommand.Append(" and "); }
                searchCommand.Append("year = " + yearSelector.Text);
                andFlag = true;
            }
            //int index = milageSelector.SelectedIndex;

            // Branch
            MessageBox.Show(searchCommand.ToString());
            return searchCommand.ToString();
        }

        // BranchReader takes our fancy branch option from a drop down box and splits it,
        // grabbing only the ID that we want.
        private string BranchReader(string branchOption)
        {
            string[] sections = branchOption.Split(' ');
            return sections[0];
        }

        private bool AndCheck()
        {
            if (branchSelector.Text == "" &
                sizeSelector.Text == "" &
                brandSelector.Text == "" &
                modelSelector.Text == "" &
                yearSelector.Text == "")
            {
                // If they're all false, return false
                return false;
            }
            // Else, at least 1 must have an option in it, thus we return true
            else { return true; }
        }

        // Unused and/or important
        private void BranchSearch_Load(object sender, EventArgs e) { }
        private void branchSelector_SelectedIndexChanged(object sender, EventArgs e) {  }
        private void sizeSelector_SelectedIndexChanged(object sender, EventArgs e) {  }
        private void milageSelector_SelectedIndexChanged(object sender, EventArgs e) {  }
        private void modelSelector_SelectedIndexChanged(object sender, EventArgs e) {  }
        private void yearSelector_SelectedIndexChanged(object sender, EventArgs e) {  }
    }
}
