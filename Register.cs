using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            this.Hide();

            MainMenu mainMenuForm = new MainMenu();

            mainMenuForm.Show();
        }
    }
}
