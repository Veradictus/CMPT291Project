
namespace _291CarProject
{
    partial class Return_Form
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
            this.return_label = new System.Windows.Forms.Label();
            this.veh_label = new System.Windows.Forms.Label();
            this.cust_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.veh_tbox = new System.Windows.Forms.TextBox();
            this.cust_tbox = new System.Windows.Forms.TextBox();
            this.date_tbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // return_label
            // 
            this.return_label.AutoSize = true;
            this.return_label.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.return_label.Location = new System.Drawing.Point(200, 21);
            this.return_label.Name = "return_label";
            this.return_label.Size = new System.Drawing.Size(225, 50);
            this.return_label.TabIndex = 0;
            this.return_label.Text = "Return Form";
            // 
            // veh_label
            // 
            this.veh_label.AutoSize = true;
            this.veh_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.veh_label.Location = new System.Drawing.Point(80, 107);
            this.veh_label.Name = "veh_label";
            this.veh_label.Size = new System.Drawing.Size(131, 32);
            this.veh_label.TabIndex = 1;
            this.veh_label.Text = "Vechicle ID";
            // 
            // cust_label
            // 
            this.cust_label.AutoSize = true;
            this.cust_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cust_label.Location = new System.Drawing.Point(80, 177);
            this.cust_label.Name = "cust_label";
            this.cust_label.Size = new System.Drawing.Size(147, 32);
            this.cust_label.TabIndex = 2;
            this.cust_label.Text = "Customer ID";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_label.Location = new System.Drawing.Point(80, 240);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(64, 32);
            this.date_label.TabIndex = 3;
            this.date_label.Text = "Date";
            this.date_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // veh_tbox
            // 
            this.veh_tbox.Location = new System.Drawing.Point(275, 116);
            this.veh_tbox.Name = "veh_tbox";
            this.veh_tbox.Size = new System.Drawing.Size(238, 23);
            this.veh_tbox.TabIndex = 4;
            // 
            // cust_tbox
            // 
            this.cust_tbox.Location = new System.Drawing.Point(275, 177);
            this.cust_tbox.Name = "cust_tbox";
            this.cust_tbox.Size = new System.Drawing.Size(238, 23);
            this.cust_tbox.TabIndex = 5;
            // 
            // date_tbox
            // 
            this.date_tbox.Location = new System.Drawing.Point(275, 240);
            this.date_tbox.Name = "date_tbox";
            this.date_tbox.Size = new System.Drawing.Size(238, 23);
            this.date_tbox.TabIndex = 6;
            // 
            // Return_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 332);
            this.Controls.Add(this.date_tbox);
            this.Controls.Add(this.cust_tbox);
            this.Controls.Add(this.veh_tbox);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.cust_label);
            this.Controls.Add(this.veh_label);
            this.Controls.Add(this.return_label);
            this.Name = "Return_Form";
            this.Text = "Return_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label return_label;
        private System.Windows.Forms.Label veh_label;
        private System.Windows.Forms.Label cust_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox veh_tbox;
        private System.Windows.Forms.TextBox cust_tbox;
        private System.Windows.Forms.TextBox date_tbox;
    }
}