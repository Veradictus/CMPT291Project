
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
            this.start_tbox = new System.Windows.Forms.TextBox();
            this.end_tbox = new System.Windows.Forms.TextBox();
            this.date_label = new System.Windows.Forms.Label();
            this.cust_id_label = new System.Windows.Forms.Label();
            this.cust_tbox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
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
            this.veh_label.Location = new System.Drawing.Point(68, 86);
            this.veh_label.Name = "veh_label";
            this.veh_label.Size = new System.Drawing.Size(120, 32);
            this.veh_label.TabIndex = 1;
            this.veh_label.Text = "Vehicle ID";
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_label.Location = new System.Drawing.Point(84, 169);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(62, 32);
            this.start_label.TabIndex = 2;
            this.start_label.Text = "Start";
            this.start_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.end_label.Location = new System.Drawing.Point(84, 222);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(54, 32);
            this.end_label.TabIndex = 3;
            this.end_label.Text = "End";
            this.end_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // veh_text_box
            // 
            this.veh_text_box.Location = new System.Drawing.Point(255, 97);
            this.veh_text_box.Name = "veh_text_box";
            this.veh_text_box.Size = new System.Drawing.Size(264, 23);
            this.veh_text_box.TabIndex = 4;
            this.veh_text_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // start_tbox
            // 
            this.start_tbox.Location = new System.Drawing.Point(255, 180);
            this.start_tbox.Name = "start_tbox";
            this.start_tbox.Size = new System.Drawing.Size(264, 23);
            this.start_tbox.TabIndex = 5;
            this.start_tbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // end_tbox
            // 
            this.end_tbox.Location = new System.Drawing.Point(255, 231);
            this.end_tbox.Name = "end_tbox";
            this.end_tbox.Size = new System.Drawing.Size(264, 23);
            this.end_tbox.TabIndex = 6;
            this.end_tbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_label.Location = new System.Drawing.Point(12, 132);
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
            this.cust_id_label.Location = new System.Drawing.Point(68, 281);
            this.cust_id_label.Name = "cust_id_label";
            this.cust_id_label.Size = new System.Drawing.Size(121, 32);
            this.cust_id_label.TabIndex = 8;
            this.cust_id_label.Text = "Username";
            this.cust_id_label.Click += new System.EventHandler(this.label5_Click);
            // 
            // cust_tbox
            // 
            this.cust_tbox.Location = new System.Drawing.Point(255, 292);
            this.cust_tbox.Name = "cust_tbox";
            this.cust_tbox.Size = new System.Drawing.Size(264, 23);
            this.cust_tbox.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(586, 292);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Borrow_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 322);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.cust_tbox);
            this.Controls.Add(this.cust_id_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.end_tbox);
            this.Controls.Add(this.start_tbox);
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
        private System.Windows.Forms.TextBox start_tbox;
        private System.Windows.Forms.TextBox end_tbox;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label cust_id_label;
        private System.Windows.Forms.TextBox cust_tbox;
        private System.Windows.Forms.Button BackButton;
    }
}