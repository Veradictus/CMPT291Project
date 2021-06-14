using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login loginForm = new Login();

            loginForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ListingsMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            BranchSearch branchSearch = new BranchSearch();

            branchSearch.Show();
        }

        private void VControlButton_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {//This the update records button. Name needs to be changed

            this.Hide();

            AURScreen aURScreen = new AURScreen();

            aURScreen.Show();
        }

        private void reports_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Built_Reports reportScreen = new Built_Reports();
            reportScreen.Show();
        }

        private void rental_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrow_Form borrow = new Borrow_Form();
            borrow.Show();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return_Form returnForm = new Return_Form();
            returnForm.Show();
        }

        private void rentalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
