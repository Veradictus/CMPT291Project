using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class MainMenu : Form
    {

        private Dictionary<string, string> userInfo;

        public MainMenu(Dictionary<string, string> userInfo)
        {
            InitializeComponent();

            this.userInfo = userInfo;

            userNameLabel.Text = userInfo["userName"];
            IDLabel.Text = userInfo["uid"];

            if (userInfo["userType"].Equals("Customer"))
            {
                employeeBox.Text = "Customer Info";
                membershipLabel.Text = userInfo["goldMember"];

                branchLabel.Visible = false;
                bIDLabel.Visible = false;

                BranchAddress.Visible = false;
                bAddLabel.Visible = false;

                records_button.Visible = false;
                reports_button.Visible = false;

                rentalLabel.Visible = false;

                returns_button.Visible = false;
                borrows_button.Visible = false;

                mainMenuTitle.Text = "Customer Menu";
            }

            if (userInfo["userType"].Equals("Employee"))
            {
                MemLabel.Visible = false;
                membershipLabel.Visible = false;

                bIDLabel.Text = userInfo["branchId"];

                bAddLabel.Text = userInfo["street"] + ", " + userInfo["city"] + ", " + userInfo["prov"];
            }

            Debug.WriteLine("----------------");

            Debug.WriteLine("uid: " + userInfo["uid"]);
            Debug.WriteLine("userName: " + userInfo["userName"]);
            Debug.WriteLine("userType: " + userInfo["userType"]);
            Debug.WriteLine("firstName: " + userInfo["firstName"]);
            Debug.WriteLine("lastName: " + userInfo["lastName"]);

            if (userInfo["userType"].Equals("Employee"))
            {
                Debug.WriteLine("branchId: " + userInfo["branchId"]);
                Debug.WriteLine("street: " + userInfo["street"]);
                Debug.WriteLine("city: " + userInfo["city"]);
                Debug.WriteLine("prov: " + userInfo["prov"]);
                Debug.WriteLine("phoneNumber: " + userInfo["phoneNumber"]);
            }

            if (userInfo["userType"].Equals("Customer"))
                Debug.WriteLine("goldMember: " + userInfo["goldMember"]);
            
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

            BranchSearch branchSearch = new BranchSearch(userInfo);

            branchSearch.Show();
        }

        private void VControlButton_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {//This the update records button. Name needs to be changed

            this.Hide();

            AURScreen aURScreen = new AURScreen(userInfo);

            aURScreen.Show();
        }

        private void reports_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Built_Reports reportScreen = new Built_Reports(userInfo);
            reportScreen.Show();
        }

        private void rental_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 temp_screen = new Form1(userInfo);
            temp_screen.Show();
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
