
namespace _291CarProject
{
    partial class Borrow_Form
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
            this.rental_label = new System.Windows.Forms.Label();
            this.veh_label = new System.Windows.Forms.Label();
            this.start_label = new System.Windows.Forms.Label();
            this.end_label = new System.Windows.Forms.Label();
            this.veh_text_box = new System.Windows.Forms.TextBox();
            this.date_label = new System.Windows.Forms.Label();
            this.cust_id_label = new System.Windows.Forms.Label();
            this.cust_tbox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.branch_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.expected_label = new System.Windows.Forms.Label();
            this.borrowed_label = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rental_label
            // 
            this.rental_label.AutoSize = true;
            this.rental_label.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rental_label.ForeColor = System.Drawing.Color.Black;
            this.rental_label.Location = new System.Drawing.Point(228, 9);
            this.rental_label.Name = "rental_label";
            this.rental_label.Size = new System.Drawing.Size(235, 50);
            this.rental_label.TabIndex = 0;
            this.rental_label.Text = "Borrow Form";
            // 
            // veh_label
            // 
            this.veh_label.AutoSize = true;
            this.veh_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.veh_label.ForeColor = System.Drawing.Color.Black;
            this.veh_label.Location = new System.Drawing.Point(126, 86);
            this.veh_label.Name = "veh_label";
            this.veh_label.Size = new System.Drawing.Size(120, 32);
            this.veh_label.TabIndex = 1;
            this.veh_label.Text = "Vehicle ID";
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_label.Location = new System.Drawing.Point(151, 200);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(95, 32);
            this.start_label.TabIndex = 2;
            this.start_label.Text = "Booked";
            this.start_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.end_label.Location = new System.Drawing.Point(62, 229);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(187, 32);
            this.end_label.TabIndex = 3;
            this.end_label.Text = "Expected Return";
            this.end_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // veh_text_box
            // 
            this.veh_text_box.Location = new System.Drawing.Point(255, 95);
            this.veh_text_box.Name = "veh_text_box";
            this.veh_text_box.Size = new System.Drawing.Size(264, 23);
            this.veh_text_box.TabIndex = 4;
            this.veh_text_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_label.Location = new System.Drawing.Point(18, 160);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(90, 37);
            this.date_label.TabIndex = 7;
            this.date_label.Text = "Dates:";
            // 
            // cust_id_label
            // 
            this.cust_id_label.AutoSize = true;
            this.cust_id_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cust_id_label.ForeColor = System.Drawing.Color.Black;
            this.cust_id_label.Location = new System.Drawing.Point(18, 115);
            this.cust_id_label.Name = "cust_id_label";
            this.cust_id_label.Size = new System.Drawing.Size(231, 32);
            this.cust_id_label.TabIndex = 8;
            this.cust_id_label.Text = "Customer Username";
            this.cust_id_label.Click += new System.EventHandler(this.label5_Click);
            // 
            // cust_tbox
            // 
            this.cust_tbox.Location = new System.Drawing.Point(255, 124);
            this.cust_tbox.Name = "cust_tbox";
            this.cust_tbox.Size = new System.Drawing.Size(264, 23);
            this.cust_tbox.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(586, 345);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // branch_label
            // 
            this.branch_label.AutoSize = true;
            this.branch_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.branch_label.Location = new System.Drawing.Point(18, 261);
            this.branch_label.Name = "branch_label";
            this.branch_label.Size = new System.Drawing.Size(128, 37);
            this.branch_label.TabIndex = 15;
            this.branch_label.Text = "Branches:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 23);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 310);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 23);
            this.textBox2.TabIndex = 13;
            // 
            // expected_label
            // 
            this.expected_label.AutoSize = true;
            this.expected_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expected_label.Location = new System.Drawing.Point(59, 330);
            this.expected_label.Name = "expected_label";
            this.expected_label.Size = new System.Drawing.Size(187, 32);
            this.expected_label.TabIndex = 12;
            this.expected_label.Text = "Expected Return";
            // 
            // borrowed_label
            // 
            this.borrowed_label.AutoSize = true;
            this.borrowed_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowed_label.Location = new System.Drawing.Point(130, 301);
            this.borrowed_label.Name = "borrowed_label";
            this.borrowed_label.Size = new System.Drawing.Size(116, 32);
            this.borrowed_label.TabIndex = 11;
            this.borrowed_label.Text = "Borrowed";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(586, 316);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(252, 237);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // Borrow_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 380);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.branch_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.expected_label);
            this.Controls.Add(this.borrowed_label);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.cust_tbox);
            this.Controls.Add(this.cust_id_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.veh_text_box);
            this.Controls.Add(this.end_label);
            this.Controls.Add(this.start_label);
            this.Controls.Add(this.veh_label);
            this.Controls.Add(this.rental_label);
            this.Name = "Borrow_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label rental_label;
        private System.Windows.Forms.Label veh_label;
        private System.Windows.Forms.Label start_label;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.TextBox veh_text_box;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label cust_id_label;
        private System.Windows.Forms.TextBox cust_tbox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label branch_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label expected_label;
        private System.Windows.Forms.Label borrowed_label;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}