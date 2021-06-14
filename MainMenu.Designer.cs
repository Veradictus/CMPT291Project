
namespace _291CarProject
{
    partial class MainMenu
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
            this.logout_button = new System.Windows.Forms.Button();
            this.ListingsMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.records_button = new System.Windows.Forms.Button();
            this.reports_button = new System.Windows.Forms.Button();
            this.rental_button = new System.Windows.Forms.Button();
            this.rentalLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(742, 387);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(71, 39);
            this.logout_button.TabIndex = 0;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // ListingsMenu
            // 
            this.ListingsMenu.Location = new System.Drawing.Point(263, 88);
            this.ListingsMenu.Name = "ListingsMenu";
            this.ListingsMenu.Size = new System.Drawing.Size(280, 52);
            this.ListingsMenu.TabIndex = 3;
            this.ListingsMenu.Text = "Vehicle Listings";
            this.ListingsMenu.UseVisualStyleBackColor = true;
            this.ListingsMenu.Click += new System.EventHandler(this.ListingsMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // records_button
            // 
            this.records_button.Location = new System.Drawing.Point(264, 159);
            this.records_button.Name = "records_button";
            this.records_button.Size = new System.Drawing.Size(280, 52);
            this.records_button.TabIndex = 5;
            this.records_button.Text = "Update Records";
            this.records_button.UseVisualStyleBackColor = true;
            this.records_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // reports_button
            // 
            this.reports_button.Location = new System.Drawing.Point(263, 231);
            this.reports_button.Name = "reports_button";
            this.reports_button.Size = new System.Drawing.Size(280, 52);
            this.reports_button.TabIndex = 6;
            this.reports_button.Text = "Reports";
            this.reports_button.UseVisualStyleBackColor = true;
            this.reports_button.Click += new System.EventHandler(this.reports_button_Click);
            // 
            // rental_button
            // 
            this.rental_button.Location = new System.Drawing.Point(416, 345);
            this.rental_button.Name = "rental_button";
            this.rental_button.Size = new System.Drawing.Size(90, 40);
            this.rental_button.TabIndex = 4;
            this.rental_button.Text = "Borrows";
            this.rental_button.UseVisualStyleBackColor = true;
            this.rental_button.Click += new System.EventHandler(this.rental_button_Click);
            // 
            // rentalLabel
            // 
            this.rentalLabel.AutoSize = true;
            this.rentalLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentalLabel.Location = new System.Drawing.Point(264, 300);
            this.rentalLabel.Name = "rentalLabel";
            this.rentalLabel.Size = new System.Drawing.Size(279, 32);
            this.rentalLabel.TabIndex = 7;
            this.rentalLabel.Text = "Rental Transaction Forms";
            this.rentalLabel.Click += new System.EventHandler(this.rentalLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Returns";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rentalLabel);
            this.Controls.Add(this.rental_button);
            this.Controls.Add(this.reports_button);
            this.Controls.Add(this.records_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListingsMenu);
            this.Controls.Add(this.logout_button);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ListingsMenu;
        private System.Windows.Forms.Button records_button;
        private System.Windows.Forms.Button reports_button;
        private System.Windows.Forms.Button rental_button;
        private System.Windows.Forms.Label rentalLabel;
        private System.Windows.Forms.Button button1;
    }
}