using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void register_username_text_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("yes hello I change text");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login loginForm = new Login();


            loginForm.Show();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            bool userExists = _291CarProject.Static.Database.UserExists(register_username_text.Text);

            if (userExists)
            {
                MessageBox.Show("The username you have entered is already registered.");

                return;
            }

            bool createUser = _291CarProject.Static.Database.CreateUser(register_username_text.Text, password_text.Text,
                "Male", firstName.Text, lastName.Text, street.Text, city.Text, province.Text);

            if (!createUser)
            {
                MessageBox.Show("An error has occurred whilst trying to create the user.");

                return;
            }

            this.Hide();

            Login loginForm = new Login();

            loginForm.Show();

            /* this.Hide();

            MainMenu mainMenuForm = new MainMenu();

            mainMenuForm.Show();*/
        }

    }
}
