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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nTransTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void queryCombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
