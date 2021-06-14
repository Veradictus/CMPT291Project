using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _291CarProject
{
    public partial class Built_Reports : Form
    {
        private Dictionary<string, string> userInfo;
        public Built_Reports(Dictionary<string, string> userInfo)
        {
            InitializeComponent();

            this.userInfo = userInfo;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenuForm = new MainMenu(userInfo);

            mainMenuForm.Show();
        }
    }
}
