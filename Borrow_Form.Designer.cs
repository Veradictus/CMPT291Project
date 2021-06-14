
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
            this.expected_label = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.vTypeLabel = new System.Windows.Forms.Label();
            this.vTypeDropDown = new System.Windows.Forms.ComboBox();
            this.expReturnDD = new System.Windows.Forms.ComboBox();
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
            this.start_label.Location = new System.Drawing.Point(151, 236);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(95, 32);
            this.start_label.TabIndex = 2;
            this.start_label.Text = "Booked";
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.end_label.Location = new System.Drawing.Point(62, 265);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(187, 32);
            this.end_label.TabIndex = 3;
            this.end_label.Text = "Expected Return";
            // 
            // veh_text_box
            // 
            this.veh_text_box.Location = new System.Drawing.Point(255, 95);
            this.veh_text_box.Name = "veh_text_box";
            this.veh_text_box.Size = new System.Drawing.Size(197, 23);
            this.veh_text_box.TabIndex = 4;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_label.Location = new System.Drawing.Point(18, 196);
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
            this.cust_id_label.Location = new System.Drawing.Point(18, 151);
            this.cust_id_label.Name = "cust_id_label";
            this.cust_id_label.Size = new System.Drawing.Size(231, 32);
            this.cust_id_label.TabIndex = 8;
            this.cust_id_label.Text = "Customer Username";
            // 
            // cust_tbox
            // 
            this.cust_tbox.Location = new System.Drawing.Point(255, 153);
            this.cust_tbox.Name = "cust_tbox";
            this.cust_tbox.Size = new System.Drawing.Size(264, 23);
            this.cust_tbox.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(586, 436);
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
            this.branch_label.Location = new System.Drawing.Point(18, 297);
            this.branch_label.Name = "branch_label";
            this.branch_label.Size = new System.Drawing.Size(128, 37);
            this.branch_label.TabIndex = 15;
            this.branch_label.Text = "Branches:";
            // 
            // expected_label
            // 
            this.expected_label.AutoSize = true;
            this.expected_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expected_label.Location = new System.Drawing.Point(59, 334);
            this.expected_label.Name = "expected_label";
            this.expected_label.Size = new System.Drawing.Size(187, 32);
            this.expected_label.TabIndex = 12;
            this.expected_label.Text = "Expected Return";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(586, 407);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(252, 244);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 23);
            this.dateFrom.TabIndex = 17;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(252, 273);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 23);
            this.dateTo.TabIndex = 18;
            // 
            // vTypeLabel
            // 
            this.vTypeLabel.AutoSize = true;
            this.vTypeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.vTypeLabel.Location = new System.Drawing.Point(98, 118);
            this.vTypeLabel.Name = "vTypeLabel";
            this.vTypeLabel.Size = new System.Drawing.Size(148, 32);
            this.vTypeLabel.TabIndex = 19;
            this.vTypeLabel.Text = "Vehicle Type";
            // 
            // vTypeDropDown
            // 
            this.vTypeDropDown.FormattingEnabled = true;
            this.vTypeDropDown.Location = new System.Drawing.Point(255, 124);
            this.vTypeDropDown.Name = "vTypeDropDown";
            this.vTypeDropDown.Size = new System.Drawing.Size(197, 23);
            this.vTypeDropDown.TabIndex = 20;
            // 
            // expReturnDD
            // 
            this.expReturnDD.FormattingEnabled = true;
            this.expReturnDD.Location = new System.Drawing.Point(252, 342);
            this.expReturnDD.Name = "expReturnDD";
            this.expReturnDD.Size = new System.Drawing.Size(267, 23);
            this.expReturnDD.TabIndex = 21;
            // 
            // Borrow_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 471);
            this.Controls.Add(this.expReturnDD);
            this.Controls.Add(this.vTypeDropDown);
            this.Controls.Add(this.vTypeLabel);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.branch_label);
            this.Controls.Add(this.expected_label);
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
        private System.Windows.Forms.Label expected_label;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label vTypeLabel;
        private System.Windows.Forms.ComboBox vTypeDropDown;
        private System.Windows.Forms.ComboBox vTypeComboBox;
        private System.Windows.Forms.ComboBox expReturnDD;
    }
}