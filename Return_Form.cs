using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class Return_Form : Form
    {
        private Dictionary<string, string> userInfo;
        public Return_Form(Dictionary<string, string> userInfo)
        {
            InitializeComponent();

            this.userInfo = userInfo;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenuForm = new MainMenu(userInfo);

            mainMenuForm.Show();
        }

        private void Return_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
