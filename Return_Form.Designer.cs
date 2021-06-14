
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
            this.transactionLabel = new System.Windows.Forms.Label();
            this.cust_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.transactionIDBox = new System.Windows.Forms.TextBox();
            this.cust_tbox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.transactionReturn = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.SearchTransactionGrid = new System.Windows.Forms.DataGridView();
            this.rentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBooked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBranchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.returnBranchDD = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTransactionGrid)).BeginInit();
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
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionLabel.Location = new System.Drawing.Point(51, 172);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(164, 32);
            this.transactionLabel.TabIndex = 1;
            this.transactionLabel.Text = "Transaction ID";
            // 
            // cust_label
            // 
            this.cust_label.AutoSize = true;
            this.cust_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cust_label.Location = new System.Drawing.Point(12, 114);
            this.cust_label.Name = "cust_label";
            this.cust_label.Size = new System.Drawing.Size(231, 32);
            this.cust_label.TabIndex = 2;
            this.cust_label.Text = "Customer Username";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_label.Location = new System.Drawing.Point(51, 201);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(168, 32);
            this.date_label.TabIndex = 3;
            this.date_label.Text = "Date Returned";
            // 
            // transactionIDBox
            // 
            this.transactionIDBox.Location = new System.Drawing.Point(246, 181);
            this.transactionIDBox.Name = "transactionIDBox";
            this.transactionIDBox.Size = new System.Drawing.Size(200, 23);
            this.transactionIDBox.TabIndex = 4;
            // 
            // cust_tbox
            // 
            this.cust_tbox.Location = new System.Drawing.Point(246, 123);
            this.cust_tbox.Name = "cust_tbox";
            this.cust_tbox.Size = new System.Drawing.Size(238, 23);
            this.cust_tbox.TabIndex = 5;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(9, 402);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // transactionReturn
            // 
            this.transactionReturn.Location = new System.Drawing.Point(246, 210);
            this.transactionReturn.Name = "transactionReturn";
            this.transactionReturn.Size = new System.Drawing.Size(200, 23);
            this.transactionReturn.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(409, 152);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchTransactionGrid
            // 
            this.SearchTransactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchTransactionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalID,
            this.userID,
            this.userName,
            this.vehicleID,
            this.vBrand,
            this.vModel,
            this.dateBooked,
            this.expReturn,
            this.bBranchID,
            this.expBranch});
            this.SearchTransactionGrid.Location = new System.Drawing.Point(490, 21);
            this.SearchTransactionGrid.Name = "SearchTransactionGrid";
            this.SearchTransactionGrid.RowTemplate.Height = 25;
            this.SearchTransactionGrid.Size = new System.Drawing.Size(717, 404);
            this.SearchTransactionGrid.TabIndex = 27;
            // 
            // rentalID
            // 
            this.rentalID.HeaderText = "Transaction ID";
            this.rentalID.Name = "rentalID";
            // 
            // userID
            // 
            this.userID.HeaderText = "User ID";
            this.userID.Name = "userID";
            // 
            // userName
            // 
            this.userName.HeaderText = "Customer Username";
            this.userName.Name = "userName";
            // 
            // vehicleID
            // 
            this.vehicleID.HeaderText = "Vehicle ID";
            this.vehicleID.Name = "vehicleID";
            // 
            // vBrand
            // 
            this.vBrand.HeaderText = "Vehicle Brand";
            this.vBrand.Name = "vBrand";
            // 
            // vModel
            // 
            this.vModel.HeaderText = "Vehicle Model";
            this.vModel.Name = "vModel";
            // 
            // dateBooked
            // 
            this.dateBooked.HeaderText = "Date Booked";
            this.dateBooked.Name = "dateBooked";
            // 
            // expReturn
            // 
            this.expReturn.HeaderText = "Expected Return Date";
            this.expReturn.Name = "expReturn";
            // 
            // bBranchID
            // 
            this.bBranchID.HeaderText = "Borrowed Branch";
            this.bBranchID.Name = "bBranchID";
            // 
            // expBranch
            // 
            this.expBranch.HeaderText = "Expected Return Branch";
            this.expBranch.Name = "expBranch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Branch Returned";
            // 
            // returnBranchDD
            // 
            this.returnBranchDD.FormattingEnabled = true;
            this.returnBranchDD.Location = new System.Drawing.Point(246, 239);
            this.returnBranchDD.Name = "returnBranchDD";
            this.returnBranchDD.Size = new System.Drawing.Size(200, 23);
            this.returnBranchDD.TabIndex = 29;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(349, 268);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 25);
            this.confirmButton.TabIndex = 30;
            this.confirmButton.Text = "Confirm Return";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // Return_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 437);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.returnBranchDD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTransactionGrid);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.transactionReturn);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.cust_tbox);
            this.Controls.Add(this.transactionIDBox);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.cust_label);
            this.Controls.Add(this.transactionLabel);
            this.Controls.Add(this.return_label);
            this.Name = "Return_Form";
            this.Text = "Return_Form";
            ((System.ComponentModel.ISupportInitialize)(this.SearchTransactionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label return_label;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Label cust_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox transactionIDTBox;
        private System.Windows.Forms.TextBox cust_tbox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DateTimePicker transactionReturn;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView SearchTransactionGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox returnBranchDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn vModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBooked;
        private System.Windows.Forms.DataGridViewTextBoxColumn expReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bBranchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn expBranch;
        private System.Windows.Forms.TextBox tIDTBox;
        private System.Windows.Forms.TextBox transactionIDBox;
        private System.Windows.Forms.Button confirmButton;
    }
}