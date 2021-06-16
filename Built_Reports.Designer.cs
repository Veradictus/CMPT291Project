
namespace _291CarProject
{
    partial class Built_Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reports_label = new System.Windows.Forms.Label();
            this.queryCombox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nTransTbox = new System.Windows.Forms.TextBox();
            this.borrowRadio = new System.Windows.Forms.RadioButton();
            this.returnRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.goldRadio = new System.Windows.Forms.RadioButton();
            this.regularMemberRadio = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.query4CheckBox = new System.Windows.Forms.CheckedListBox();
            this.query4CheckBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.query1GroupBox = new System.Windows.Forms.GroupBox();
            this.q1ConfirmButton = new System.Windows.Forms.Button();
            this.query2GroupBox = new System.Windows.Forms.GroupBox();
            this.q2ConfirmButton = new System.Windows.Forms.Button();
            this.query3GroupBox = new System.Windows.Forms.GroupBox();
            this.q3Value = new System.Windows.Forms.TextBox();
            this.query4GroupBox = new System.Windows.Forms.GroupBox();
            this.q3ConfirmButton = new System.Windows.Forms.Button();
            this.q4GoldRadio = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.q4RegularRadio = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.q4ConfirmButton = new System.Windows.Forms.Button();
            this.outPutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.query1GroupBox.SuspendLayout();
            this.query2GroupBox.SuspendLayout();
            this.query3GroupBox.SuspendLayout();
            this.query4GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // reports_label
            // 
            this.reports_label.AutoSize = true;
            this.reports_label.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reports_label.Location = new System.Drawing.Point(330, 18);
            this.reports_label.Name = "reports_label";
            this.reports_label.Size = new System.Drawing.Size(148, 50);
            this.reports_label.TabIndex = 1;
            this.reports_label.Text = "Reports";
            // 
            // queryCombox
            // 
            this.queryCombox.FormattingEnabled = true;
            this.queryCombox.Items.AddRange(new object[] {
            "Highest Rental Transaction Report",
            "Vehicle Types Not Used Report",
            "Count for Different-Branch-return Fee Report",
            "Average Spending Report"});
            this.queryCombox.Location = new System.Drawing.Point(143, 81);
            this.queryCombox.Name = "queryCombox";
            this.queryCombox.Size = new System.Drawing.Size(417, 23);
            this.queryCombox.TabIndex = 3;
            this.queryCombox.SelectedIndexChanged += new System.EventHandler(this.queryCombox_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(916, 404);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(690, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(310, 299);
            this.dataGridView1.TabIndex = 5;
            // 
            // nTransTbox
            // 
            this.nTransTbox.Location = new System.Drawing.Point(115, 19);
            this.nTransTbox.Name = "nTransTbox";
            this.nTransTbox.Size = new System.Drawing.Size(68, 23);
            this.nTransTbox.TabIndex = 6;
            this.nTransTbox.TextChanged += new System.EventHandler(this.nTransTbox_TextChanged);
            // 
            // borrowRadio
            // 
            this.borrowRadio.AutoSize = true;
            this.borrowRadio.Location = new System.Drawing.Point(11, 68);
            this.borrowRadio.Name = "borrowRadio";
            this.borrowRadio.Size = new System.Drawing.Size(68, 19);
            this.borrowRadio.TabIndex = 7;
            this.borrowRadio.TabStop = true;
            this.borrowRadio.Text = "Borrows";
            this.borrowRadio.UseVisualStyleBackColor = true;
            // 
            // returnRadio
            // 
            this.returnRadio.AutoSize = true;
            this.returnRadio.Location = new System.Drawing.Point(11, 43);
            this.returnRadio.Name = "returnRadio";
            this.returnRadio.Size = new System.Drawing.Size(65, 19);
            this.returnRadio.TabIndex = 8;
            this.returnRadio.TabStop = true;
            this.returnRadio.Text = "Returns";
            this.returnRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Greater Than:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // goldRadio
            // 
            this.goldRadio.AutoSize = true;
            this.goldRadio.Location = new System.Drawing.Point(11, 22);
            this.goldRadio.Name = "goldRadio";
            this.goldRadio.Size = new System.Drawing.Size(103, 19);
            this.goldRadio.TabIndex = 10;
            this.goldRadio.TabStop = true;
            this.goldRadio.Text = "Gold Members";
            this.goldRadio.UseVisualStyleBackColor = true;
            // 
            // regularMemberRadio
            // 
            this.regularMemberRadio.AutoSize = true;
            this.regularMemberRadio.Location = new System.Drawing.Point(11, 48);
            this.regularMemberRadio.Name = "regularMemberRadio";
            this.regularMemberRadio.Size = new System.Drawing.Size(118, 19);
            this.regularMemberRadio.TabIndex = 11;
            this.regularMemberRadio.TabStop = true;
            this.regularMemberRadio.Text = "Regular Members";
            this.regularMemberRadio.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.checkedListBox1.Location = new System.Drawing.Point(133, 9);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(69, 58);
            this.checkedListBox1.TabIndex = 12;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // query4CheckBox
            // 
            this.query4CheckBox.CheckOnClick = true;
            this.query4CheckBox.FormattingEnabled = true;
            this.query4CheckBox.Items.AddRange(new object[] {
            "City",
            "Province"});
            this.query4CheckBox.Location = new System.Drawing.Point(9, 22);
            this.query4CheckBox.Name = "query4CheckBox";
            this.query4CheckBox.Size = new System.Drawing.Size(76, 40);
            this.query4CheckBox.TabIndex = 15;
            this.query4CheckBox.ThreeDCheckBoxes = true;
            this.query4CheckBox.SelectedIndexChanged += new System.EventHandler(this.query4CheckBox_SelectedIndexChanged);
            // 
            // query4CheckBox2
            // 
            this.query4CheckBox2.CheckOnClick = true;
            this.query4CheckBox2.FormattingEnabled = true;
            this.query4CheckBox2.Items.AddRange(new object[] {
            "Most",
            "Least"});
            this.query4CheckBox2.Location = new System.Drawing.Point(105, 22);
            this.query4CheckBox2.Name = "query4CheckBox2";
            this.query4CheckBox2.Size = new System.Drawing.Size(76, 40);
            this.query4CheckBox2.TabIndex = 16;
            this.query4CheckBox2.ThreeDCheckBoxes = true;
            this.query4CheckBox2.SelectedIndexChanged += new System.EventHandler(this.query4CheckBox2_SelectedIndexChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.checkedListBox2.Location = new System.Drawing.Point(114, 46);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(69, 58);
            this.checkedListBox2.TabIndex = 17;
            this.checkedListBox2.ThreeDCheckBoxes = true;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // query1GroupBox
            // 
            this.query1GroupBox.Controls.Add(this.q1ConfirmButton);
            this.query1GroupBox.Controls.Add(this.label1);
            this.query1GroupBox.Controls.Add(this.checkedListBox2);
            this.query1GroupBox.Controls.Add(this.nTransTbox);
            this.query1GroupBox.Controls.Add(this.returnRadio);
            this.query1GroupBox.Controls.Add(this.borrowRadio);
            this.query1GroupBox.Location = new System.Drawing.Point(143, 186);
            this.query1GroupBox.Name = "query1GroupBox";
            this.query1GroupBox.Size = new System.Drawing.Size(214, 161);
            this.query1GroupBox.TabIndex = 18;
            this.query1GroupBox.TabStop = false;
            this.query1GroupBox.Text = "q1GBox";
            this.query1GroupBox.Visible = false;
            // 
            // q1ConfirmButton
            // 
            this.q1ConfirmButton.Location = new System.Drawing.Point(17, 106);
            this.q1ConfirmButton.Name = "q1ConfirmButton";
            this.q1ConfirmButton.Size = new System.Drawing.Size(75, 37);
            this.q1ConfirmButton.TabIndex = 18;
            this.q1ConfirmButton.Text = "Confirm";
            this.q1ConfirmButton.UseVisualStyleBackColor = true;
            this.q1ConfirmButton.Click += new System.EventHandler(this.q1ConfirmButton_Click);
            // 
            // query2GroupBox
            // 
            this.query2GroupBox.Controls.Add(this.q2ConfirmButton);
            this.query2GroupBox.Controls.Add(this.goldRadio);
            this.query2GroupBox.Controls.Add(this.regularMemberRadio);
            this.query2GroupBox.Controls.Add(this.checkedListBox1);
            this.query2GroupBox.Location = new System.Drawing.Point(164, 164);
            this.query2GroupBox.Name = "query2GroupBox";
            this.query2GroupBox.Size = new System.Drawing.Size(236, 126);
            this.query2GroupBox.TabIndex = 19;
            this.query2GroupBox.TabStop = false;
            this.query2GroupBox.Text = "q2GBox";
            this.query2GroupBox.Visible = false;
            // 
            // q2ConfirmButton
            // 
            this.q2ConfirmButton.Location = new System.Drawing.Point(67, 82);
            this.q2ConfirmButton.Name = "q2ConfirmButton";
            this.q2ConfirmButton.Size = new System.Drawing.Size(75, 28);
            this.q2ConfirmButton.TabIndex = 13;
            this.q2ConfirmButton.Text = "Confirm";
            this.q2ConfirmButton.UseVisualStyleBackColor = true;
            this.q2ConfirmButton.Click += new System.EventHandler(this.q2ConfirmButton_Click);
            // 
            // query3GroupBox
            // 
            this.query3GroupBox.Controls.Add(this.q3Value);
            this.query3GroupBox.Controls.Add(this.q4ConfirmButton);
            this.query3GroupBox.Controls.Add(this.query4CheckBox);
            this.query3GroupBox.Controls.Add(this.query4CheckBox2);
            this.query3GroupBox.Location = new System.Drawing.Point(235, 158);
            this.query3GroupBox.Name = "query3GroupBox";
            this.query3GroupBox.Size = new System.Drawing.Size(282, 117);
            this.query3GroupBox.TabIndex = 20;
            this.query3GroupBox.TabStop = false;
            this.query3GroupBox.Text = "q3GBox";
            this.query3GroupBox.Visible = false;
            // 
            // q3Value
            // 
            this.q3Value.Location = new System.Drawing.Point(9, 76);
            this.q3Value.Name = "q3Value";
            this.q3Value.Size = new System.Drawing.Size(172, 23);
            this.q3Value.TabIndex = 18;
            // 
            // query4GroupBox
            // 
            this.query4GroupBox.Controls.Add(this.q3ConfirmButton);
            this.query4GroupBox.Controls.Add(this.q4GoldRadio);
            this.query4GroupBox.Controls.Add(this.dateTimePicker2);
            this.query4GroupBox.Controls.Add(this.q4RegularRadio);
            this.query4GroupBox.Controls.Add(this.dateTimePicker1);
            this.query4GroupBox.Location = new System.Drawing.Point(291, 154);
            this.query4GroupBox.Name = "query4GroupBox";
            this.query4GroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.query4GroupBox.Size = new System.Drawing.Size(324, 187);
            this.query4GroupBox.TabIndex = 26;
            this.query4GroupBox.TabStop = false;
            this.query4GroupBox.Text = "q4GBox";
            this.query4GroupBox.Visible = false;
            // 
            // q3ConfirmButton
            // 
            this.q3ConfirmButton.Location = new System.Drawing.Point(232, 79);
            this.q3ConfirmButton.Name = "q3ConfirmButton";
            this.q3ConfirmButton.Size = new System.Drawing.Size(61, 52);
            this.q3ConfirmButton.TabIndex = 26;
            this.q3ConfirmButton.Text = "Confirm";
            this.q3ConfirmButton.UseVisualStyleBackColor = true;
            this.q3ConfirmButton.Click += new System.EventHandler(this.q3ConfirmButton_Click);
            // 
            // q4GoldRadio
            // 
            this.q4GoldRadio.AutoSize = true;
            this.q4GoldRadio.Location = new System.Drawing.Point(6, 19);
            this.q4GoldRadio.Name = "q4GoldRadio";
            this.q4GoldRadio.Size = new System.Drawing.Size(103, 19);
            this.q4GoldRadio.TabIndex = 21;
            this.q4GoldRadio.TabStop = true;
            this.q4GoldRadio.Text = "Gold Members";
            this.q4GoldRadio.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(7, 98);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // q4RegularRadio
            // 
            this.q4RegularRadio.AutoSize = true;
            this.q4RegularRadio.Location = new System.Drawing.Point(6, 44);
            this.q4RegularRadio.Name = "q4RegularRadio";
            this.q4RegularRadio.Size = new System.Drawing.Size(118, 19);
            this.q4RegularRadio.TabIndex = 22;
            this.q4RegularRadio.TabStop = true;
            this.q4RegularRadio.Text = "Regular Members";
            this.q4RegularRadio.UseVisualStyleBackColor = true;
            this.q4RegularRadio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // q4ConfirmButton
            // 
            this.q4ConfirmButton.Location = new System.Drawing.Point(206, 41);
            this.q4ConfirmButton.Name = "q4ConfirmButton";
            this.q4ConfirmButton.Size = new System.Drawing.Size(70, 40);
            this.q4ConfirmButton.TabIndex = 17;
            this.q4ConfirmButton.Text = "Confirm";
            this.q4ConfirmButton.UseVisualStyleBackColor = true;
            this.q4ConfirmButton.Click += new System.EventHandler(this.q4ConfirmButton_Click);
            // 
            // outPutLabel
            // 
            this.outPutLabel.AutoSize = true;
            this.outPutLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outPutLabel.Location = new System.Drawing.Point(690, 44);
            this.outPutLabel.Name = "outPutLabel";
            this.outPutLabel.Size = new System.Drawing.Size(79, 30);
            this.outPutLabel.TabIndex = 27;
            this.outPutLabel.Text = "Output";
            // 
            // Built_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 499);
            this.Controls.Add(this.outPutLabel);
            this.Controls.Add(this.query4GroupBox);
            this.Controls.Add(this.query3GroupBox);
            this.Controls.Add(this.query2GroupBox);
            this.Controls.Add(this.query1GroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.queryCombox);
            this.Controls.Add(this.reports_label);
            this.Name = "Built_Reports";
            this.Text = "Built_Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.query1GroupBox.ResumeLayout(false);
            this.query1GroupBox.PerformLayout();
            this.query2GroupBox.ResumeLayout(false);
            this.query2GroupBox.PerformLayout();
            this.query3GroupBox.ResumeLayout(false);
            this.query3GroupBox.PerformLayout();
            this.query4GroupBox.ResumeLayout(false);
            this.query4GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reports_label;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox queryCombox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nTransTbox;
        private System.Windows.Forms.RadioButton borrowRadio;
        private System.Windows.Forms.RadioButton returnRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton goldRadio;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox query4CheckBox;
        private System.Windows.Forms.CheckedListBox query4CheckBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.GroupBox query1GroupBox;
        private System.Windows.Forms.GroupBox query2GroupBox;
        private System.Windows.Forms.GroupBox query3GroupBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button q1ConfirmButton;
        private System.Windows.Forms.Button q2ConfirmButton;
        private System.Windows.Forms.Button q4ConfirmButton;
        private System.Windows.Forms.Button q3ConfirmButton;
        private System.Windows.Forms.Label outPutLabel;
        private System.Windows.Forms.RadioButton regularMemberRadio;
        public System.Windows.Forms.GroupBox query4GroupBox;
        private System.Windows.Forms.TextBox q3Value;
        private System.Windows.Forms.RadioButton q4GoldRadio;
        private System.Windows.Forms.RadioButton q4RegularRadio;
    }
}