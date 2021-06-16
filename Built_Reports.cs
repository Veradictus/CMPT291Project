using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            query1GroupBox.Visible = false;
            query2GroupBox.Visible = false;
            query3GroupBox.Visible = false;
            query4GroupBox.Visible = false;

            Debug.WriteLine(queryCombox.SelectedIndex);

            switch (queryCombox.SelectedIndex)
            {
                case 0:
                    query1GroupBox.Visible = true;
                    break;

                case 1:

                    Debug.WriteLine("Hi??");
                    query2GroupBox.Visible = true;
                    break;

                case 2:
                    query3GroupBox.Visible = true;
                    break;

                case 3:
                    query4GroupBox.Visible = true;
                    break;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void q1ConfirmButton_Click(object sender, EventArgs e)
        {
            string minimumAmount = nTransTbox.Text;

            if (minimumAmount.Length < 1)
            {
                MessageBox.Show("Please enter a value greater than.");
                return;
            }

            bool isReturnChecked = returnRadio.Checked;
            bool isBorrowChecked = borrowRadio.Checked;

            if (checkedListBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a vehicle size.");
                return;
            }

            string size = checkedListBox2.SelectedItem.ToString();

            if (!isReturnChecked && !isBorrowChecked)
            {
                MessageBox.Show("Please specify whether your report is a borrow or a return.");
                return;
            }

            //[GetHighestTransactionReport] query: SELECT firstName + ' ' + lastName FROM [User]  WHERE [UID] IN ( SELECT empRet FROM RentalTransaction WHERE vTypeID=Medium GROUP BY empRet HAVING COUNT(*) > 2)

            List<string> names = _291CarProject.Static.Database.GetHighestTransactionReport(minimumAmount, isBorrowChecked, size);

            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 1;

            dataGridView1.Columns[0].Name = "Full Name";

            foreach (string name in names) {
                dataGridView1.Rows.Add(name);
            }
        }

        private void q2ConfirmButton_Click(object sender, EventArgs e)
        {
            bool isGoldMember = goldRadio.Checked;
            bool isRegularMember = regularMemberRadio.Checked;

            if (!isGoldMember && !isRegularMember)
            {
                MessageBox.Show("Please select the type of member.");
                return;
            }

            List<string> sizes = new List<string>();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                sizes.Add(checkedListBox1.CheckedItems[i].ToString().ToLower());

            if (sizes.Count < 1)
            {
                MessageBox.Show("Please select at least one size.");
                return;
            }

            Debug.WriteLine("isGoldMember: " + isGoldMember);
            Debug.WriteLine("isRegularMember: " + isRegularMember);

            Debug.WriteLine("--------------");

            foreach (string size in sizes)
                Debug.WriteLine("sizes: " + size.ToString());

            string membership = isGoldMember ? "Gold" : "Regular";

            List<string> names = _291CarProject.Static.Database.GetVehicleTypesNotUsed(membership, sizes);

            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 1;

            dataGridView1.Columns[0].Name = "Full Name";

            foreach (string name in names)
            {
                dataGridView1.Rows.Add(name);
            }
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; ++i)
                if (i != e.Index) checkedListBox2.SetItemChecked(i, false);
        }
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count > 1)
            {
                Int32 checkedItemIndex = checkedListBox2.CheckedIndices[0];
                checkedListBox2.ItemCheck -= checkedListBox2_ItemCheck;
                checkedListBox2.SetItemChecked(checkedItemIndex, false);
                checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void query4CheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < query4CheckBox.Items.Count; ++i)
                if (i != e.Index) query4CheckBox.SetItemChecked(i, false);
        }
        private void query4CheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (query4CheckBox.CheckedItems.Count > 1)
            {
                Int32 checkedItemIndex = query4CheckBox.CheckedIndices[0];
                query4CheckBox.ItemCheck -= query4CheckBox_ItemCheck;
                query4CheckBox.SetItemChecked(checkedItemIndex, false);
                query4CheckBox.ItemCheck += query4CheckBox_ItemCheck;
            }

            for (int i = 0; i < query4CheckBox.CheckedItems.Count; i++)
            {
                bool isCity = query4CheckBox.CheckedItems[i].ToString().Equals("City");

                q3Value.PlaceholderText = isCity ? "Enter a city" : "Enter a province";
            }

        }
        private void query4CheckBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < query4CheckBox2.Items.Count; ++i)
                if (i != e.Index) query4CheckBox2.SetItemChecked(i, false);
        }
        private void query4CheckBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (query4CheckBox2.CheckedItems.Count > 1)
            {
                Int32 checkedItemIndex = query4CheckBox2.CheckedIndices[0];
                query4CheckBox2.ItemCheck -= query4CheckBox2_ItemCheck;
                query4CheckBox2.SetItemChecked(checkedItemIndex, false);
                query4CheckBox2.ItemCheck += query4CheckBox2_ItemCheck;
            }
        }

        private void q4ConfirmButton_Click(object sender, EventArgs e)
        {
            bool isCity = false;
            bool most = false;

            for (int i = 0; i < query4CheckBox.CheckedItems.Count; i++)
                isCity = query4CheckBox.CheckedItems[i].ToString().Equals("City");

            for (int i = 0; i < query4CheckBox2.CheckedItems.Count; i++)
                most = query4CheckBox2.CheckedItems[i].ToString().Equals("Most");

            if (query4CheckBox.CheckedItems.Count < 1)
            {
                MessageBox.Show("You must specify a city or a province.");
                return;
            }

            if (query4CheckBox2.CheckedItems.Count < 1)
            {
                MessageBox.Show("You must select most or least.");
                return;
            }

            if (q3Value.Text.Length < 1)
            {
                MessageBox.Show("You must enter a value.");
                return;
            }

            Dictionary<string, string> changeFees = _291CarProject.Static.Database.GetBranchChangeFee(most, isCity, q3Value.Text);

            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[0].Name = "Branch ID";
            dataGridView1.Columns[1].Name = "Branch Count";
 

            foreach (KeyValuePair<string, string> entry in changeFees)
            {
                dataGridView1.Rows.Add(entry.Key, entry.Value);
            }


        }

        private void q3ConfirmButton_Click(object sender, EventArgs e)
        {
            bool isGold = q4GoldRadio.Checked;
            bool isRegular = q4RegularRadio.Checked;

            if (!isGold && !isRegular)
            {
                MessageBox.Show("You must specify a type of customer.");
                return;
            }

            string startDate = dateTimePicker1.Value.ToString("dd-MM-yy");
            string toDate = dateTimePicker2.Value.ToString("dd-MM-yy");

            List<string> averageSpendings = _291CarProject.Static.Database.GetAverageSpending(isGold, startDate, toDate);

            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 1;

            dataGridView1.Columns[0].Name = "Average Spending";

            foreach (string spending in averageSpendings)
            {
                dataGridView1.Rows.Add(spending);
            }
        }
    }
}
