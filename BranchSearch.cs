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
    }
}
