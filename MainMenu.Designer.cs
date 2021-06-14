
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
            this.mainMenuTitle = new System.Windows.Forms.Label();
            this.records_button = new System.Windows.Forms.Button();
            this.reports_button = new System.Windows.Forms.Button();
            this.borrows_button = new System.Windows.Forms.Button();
            this.rentalLabel = new System.Windows.Forms.Label();
            this.returns_button = new System.Windows.Forms.Button();
            this.ENameLabel = new System.Windows.Forms.Label();
            this.BranchAddress = new System.Windows.Forms.Label();
            this.branchLabel = new System.Windows.Forms.Label();
            this.UIDLabel = new System.Windows.Forms.Label();
            this.employeeBox = new System.Windows.Forms.GroupBox();
            this.bAddLabel = new System.Windows.Forms.Label();
            this.bIDLabel = new System.Windows.Forms.Label();
            this.membershipLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.MemLabel = new System.Windows.Forms.Label();
            this.employeeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(695, 358);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(71, 39);
            this.logout_button.TabIndex = 0;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // ListingsMenu
            // 
            this.ListingsMenu.Location = new System.Drawing.Point(108, 100);
            this.ListingsMenu.Name = "ListingsMenu";
            this.ListingsMenu.Size = new System.Drawing.Size(280, 52);
            this.ListingsMenu.TabIndex = 3;
            this.ListingsMenu.Text = "Vehicle Listings";
            this.ListingsMenu.UseVisualStyleBackColor = true;
            this.ListingsMenu.Click += new System.EventHandler(this.ListingsMenu_Click);
            // 
            // mainMenuTitle
            // 
            this.mainMenuTitle.AutoSize = true;
            this.mainMenuTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainMenuTitle.Location = new System.Drawing.Point(273, 30);
            this.mainMenuTitle.Name = "mainMenuTitle";
            this.mainMenuTitle.Size = new System.Drawing.Size(286, 50);
            this.mainMenuTitle.TabIndex = 2;
            this.mainMenuTitle.Text = "Employee Menu";
            this.mainMenuTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // records_button
            // 
            this.records_button.Location = new System.Drawing.Point(108, 175);
            this.records_button.Name = "records_button";
            this.records_button.Size = new System.Drawing.Size(280, 52);
            this.records_button.TabIndex = 5;
            this.records_button.Text = "Update Records";
            this.records_button.UseVisualStyleBackColor = true;
            this.records_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // reports_button
            // 
            this.reports_button.Location = new System.Drawing.Point(108, 243);
            this.reports_button.Name = "reports_button";
            this.reports_button.Size = new System.Drawing.Size(280, 52);
            this.reports_button.TabIndex = 6;
            this.reports_button.Text = "Reports";
            this.reports_button.UseVisualStyleBackColor = true;
            this.reports_button.Click += new System.EventHandler(this.reports_button_Click);
            // 
            // borrows_button
            // 
            this.borrows_button.Location = new System.Drawing.Point(297, 357);
            this.borrows_button.Name = "borrows_button";
            this.borrows_button.Size = new System.Drawing.Size(90, 40);
            this.borrows_button.TabIndex = 4;
            this.borrows_button.Text = "Borrows";
            this.borrows_button.UseVisualStyleBackColor = true;
            this.borrows_button.Click += new System.EventHandler(this.rental_button_Click);
            // 
            // rentalLabel
            // 
            this.rentalLabel.AutoSize = true;
            this.rentalLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentalLabel.Location = new System.Drawing.Point(108, 311);
            this.rentalLabel.Name = "rentalLabel";
            this.rentalLabel.Size = new System.Drawing.Size(279, 32);
            this.rentalLabel.TabIndex = 7;
            this.rentalLabel.Text = "Rental Transaction Forms";
            this.rentalLabel.Click += new System.EventHandler(this.rentalLabel_Click);
            // 
            // returns_button
            // 
            this.returns_button.Location = new System.Drawing.Point(108, 358);
            this.returns_button.Name = "returns_button";
            this.returns_button.Size = new System.Drawing.Size(88, 39);
            this.returns_button.TabIndex = 8;
            this.returns_button.Text = "Returns";
            this.returns_button.UseVisualStyleBackColor = true;
            this.returns_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // ENameLabel
            // 
            this.ENameLabel.AutoSize = true;
            this.ENameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ENameLabel.Location = new System.Drawing.Point(6, 19);
            this.ENameLabel.Name = "ENameLabel";
            this.ENameLabel.Size = new System.Drawing.Size(43, 15);
            this.ENameLabel.TabIndex = 5;
            this.ENameLabel.Text = "Name:";
            // 
            // BranchAddress
            // 
            this.BranchAddress.AutoSize = true;
            this.BranchAddress.Location = new System.Drawing.Point(6, 143);
            this.BranchAddress.Name = "BranchAddress";
            this.BranchAddress.Size = new System.Drawing.Size(96, 15);
            this.BranchAddress.TabIndex = 4;
            this.BranchAddress.Text = "Branch Address:";
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Location = new System.Drawing.Point(6, 108);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(65, 15);
            this.branchLabel.TabIndex = 1;
            this.branchLabel.Text = "Branch ID:";
            // 
            // UIDLabel
            // 
            this.UIDLabel.AutoSize = true;
            this.UIDLabel.Location = new System.Drawing.Point(6, 48);
            this.UIDLabel.Name = "UIDLabel";
            this.UIDLabel.Size = new System.Drawing.Size(52, 15);
            this.UIDLabel.TabIndex = 0;
            this.UIDLabel.Text = "User ID:";
            // 
            // employeeBox
            // 
            this.employeeBox.Controls.Add(this.bAddLabel);
            this.employeeBox.Controls.Add(this.bIDLabel);
            this.employeeBox.Controls.Add(this.membershipLabel);
            this.employeeBox.Controls.Add(this.IDLabel);
            this.employeeBox.Controls.Add(this.userNameLabel);
            this.employeeBox.Controls.Add(this.MemLabel);
            this.employeeBox.Controls.Add(this.ENameLabel);
            this.employeeBox.Controls.Add(this.UIDLabel);
            this.employeeBox.Controls.Add(this.BranchAddress);
            this.employeeBox.Controls.Add(this.branchLabel);
            this.employeeBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeBox.Location = new System.Drawing.Point(427, 100);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(339, 216);
            this.employeeBox.TabIndex = 10;
            this.employeeBox.TabStop = false;
            this.employeeBox.Text = "Employee Info";
            // 
            // bAddLabel
            // 
            this.bAddLabel.AutoSize = true;
            this.bAddLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddLabel.Location = new System.Drawing.Point(108, 143);
            this.bAddLabel.Name = "bAddLabel";
            this.bAddLabel.Size = new System.Drawing.Size(49, 15);
            this.bAddLabel.TabIndex = 11;
            this.bAddLabel.Text = "Address";
            // 
            // bIDLabel
            // 
            this.bIDLabel.AutoSize = true;
            this.bIDLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIDLabel.Location = new System.Drawing.Point(77, 108);
            this.bIDLabel.Name = "bIDLabel";
            this.bIDLabel.Size = new System.Drawing.Size(55, 15);
            this.bIDLabel.TabIndex = 10;
            this.bIDLabel.Text = "branchID";
            // 
            // membershipLabel
            // 
            this.membershipLabel.AutoSize = true;
            this.membershipLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.membershipLabel.Location = new System.Drawing.Point(120, 75);
            this.membershipLabel.Name = "membershipLabel";
            this.membershipLabel.Size = new System.Drawing.Size(74, 15);
            this.membershipLabel.TabIndex = 9;
            this.membershipLabel.Text = "membership";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(64, 48);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(40, 15);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "userID";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.Location = new System.Drawing.Point(55, 19);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(61, 15);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "userName";
            // 
            // MemLabel
            // 
            this.MemLabel.AutoSize = true;
            this.MemLabel.Location = new System.Drawing.Point(6, 75);
            this.MemLabel.Name = "MemLabel";
            this.MemLabel.Size = new System.Drawing.Size(109, 15);
            this.MemLabel.TabIndex = 6;
            this.MemLabel.Text = "Membership Type:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.returns_button);
            this.Controls.Add(this.rentalLabel);
            this.Controls.Add(this.borrows_button);
            this.Controls.Add(this.reports_button);
            this.Controls.Add(this.records_button);
            this.Controls.Add(this.mainMenuTitle);
            this.Controls.Add(this.ListingsMenu);
            this.Controls.Add(this.logout_button);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.employeeBox.ResumeLayout(false);
            this.employeeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label mainMenuTitle;
        private System.Windows.Forms.Button ListingsMenu;
        private System.Windows.Forms.Button records_button;
        private System.Windows.Forms.Button reports_button;
        private System.Windows.Forms.Button borrows_button;
        private System.Windows.Forms.Label rentalLabel;
        private System.Windows.Forms.Button returns_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BranchAddress;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Label EIDLabel;
        private System.Windows.Forms.GroupBox employeeBox;
        private System.Windows.Forms.Label ENameLabel;
        private System.Windows.Forms.Label MemLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label UIDLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label membershipLabel;
        private System.Windows.Forms.Label bAddLabel;
        private System.Windows.Forms.Label bIDLabel;
    }
}