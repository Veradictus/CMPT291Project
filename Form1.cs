using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> userInfo;
        public Form1(Dictionary<string, string> userInfo)
        {
            InitializeComponent();

            this.userInfo = userInfo;
        }

        private void borrow_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrow_Form borrow_screen = new Borrow_Form(userInfo);
            borrow_screen.Show();
        }

        private void return_bottom_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return_Form return_screen = new Return_Form(userInfo);
            return_screen.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenuForm = new MainMenu(userInfo);

            mainMenuForm.Show();
        }
    }
}
