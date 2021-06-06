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
        }

        private void BranchSearch_Load(object sender, EventArgs e)
        {

        }

        private void branchSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sizeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void milageSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modelSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenuForm = new MainMenu();

            mainMenuForm.Show();
        }

        private void updateSearchButton_Click(object sender, EventArgs e)
        {
            // search query message
            string searchMessage;

            // If there is no branch selected, let the user know
            if (branchSelector.Text == "-")
            {
                searchMessage = "Please select a branch.";
                MessageBox.Show(searchMessage);
                return;
            }

            // The basic query
            searchMessage = "Searching for vehicle matching the following query: " +
                "\r\nBranch: " + branchSelector.Text + 
                "\r\nFrom: " + dateFrom.Text + " to " + dateTo.Text;

            // Check for search query options
            // Size, Milage, Model, Year
            if (sizeSelector.Text != "-")
            {
                searchMessage += "\r\nSize: " + sizeSelector.Text;
            }
            if (milageSelector.Text != "-")
            {
                searchMessage += "\r\nMilage: " + milageSelector.Text;
            }
            if (modelSelector.Text != "-")
            {
                searchMessage += "\r\nModel: " + modelSelector.Text;
            }
            if (yearSelector.Text != "-")
            {
                searchMessage += "\r\nYear: " + yearSelector.Text;
            }

            // Show the search query
            MessageBox.Show(searchMessage);
        }
    }
}
