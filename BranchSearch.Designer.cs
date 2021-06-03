
namespace _291CarProject
{
    partial class BranchSearch
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
            this.branchSelector = new System.Windows.Forms.ComboBox();
            this.branchText = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.availabeVehicleText = new System.Windows.Forms.TextBox();
            this.sizeText = new System.Windows.Forms.TextBox();
            this.milageText = new System.Windows.Forms.TextBox();
            this.modelText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.sizeSelector = new System.Windows.Forms.ComboBox();
            this.milageSelector = new System.Windows.Forms.ComboBox();
            this.yearSelector = new System.Windows.Forms.ComboBox();
            this.modelSelector = new System.Windows.Forms.ComboBox();
            this.ListingBox = new System.Windows.Forms.GroupBox();
            this.ListingRates = new System.Windows.Forms.TextBox();
            this.ListingMilage = new System.Windows.Forms.TextBox();
            this.ListingYear = new System.Windows.Forms.TextBox();
            this.ListingSize = new System.Windows.Forms.TextBox();
            this.ListingModel = new System.Windows.Forms.TextBox();
            this.ListingNumber = new System.Windows.Forms.TextBox();
            this.ListingVID = new System.Windows.Forms.TextBox();
            this.ListingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // branchSelector
            // 
            this.branchSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.branchSelector.FormattingEnabled = true;
            this.branchSelector.Items.AddRange(new object[] {
            "Branch 1",
            "Branch 2",
            "Branch 3"});
            this.branchSelector.Location = new System.Drawing.Point(43, 77);
            this.branchSelector.Name = "branchSelector";
            this.branchSelector.Size = new System.Drawing.Size(100, 23);
            this.branchSelector.TabIndex = 0;
            this.branchSelector.Text = "Location";
            this.branchSelector.SelectedIndexChanged += new System.EventHandler(this.branchSelector_SelectedIndexChanged);
            // 
            // branchText
            // 
            this.branchText.BackColor = System.Drawing.SystemColors.Control;
            this.branchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.branchText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.branchText.Location = new System.Drawing.Point(43, 55);
            this.branchText.Name = "branchText";
            this.branchText.Size = new System.Drawing.Size(100, 16);
            this.branchText.TabIndex = 1;
            this.branchText.Text = "Select Branch";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 415);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // availabeVehicleText
            // 
            this.availabeVehicleText.BackColor = System.Drawing.SystemColors.Control;
            this.availabeVehicleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availabeVehicleText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.availabeVehicleText.Location = new System.Drawing.Point(367, 20);
            this.availabeVehicleText.Name = "availabeVehicleText";
            this.availabeVehicleText.Size = new System.Drawing.Size(158, 22);
            this.availabeVehicleText.TabIndex = 5;
            this.availabeVehicleText.Text = " Available Vehicles";
            // 
            // sizeText
            // 
            this.sizeText.BackColor = System.Drawing.SystemColors.Control;
            this.sizeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sizeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sizeText.Location = new System.Drawing.Point(43, 154);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(100, 16);
            this.sizeText.TabIndex = 6;
            this.sizeText.Text = "Size";
            // 
            // milageText
            // 
            this.milageText.BackColor = System.Drawing.SystemColors.Control;
            this.milageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.milageText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.milageText.Location = new System.Drawing.Point(43, 183);
            this.milageText.Name = "milageText";
            this.milageText.Size = new System.Drawing.Size(100, 16);
            this.milageText.TabIndex = 7;
            this.milageText.Text = "Milage";
            // 
            // modelText
            // 
            this.modelText.BackColor = System.Drawing.SystemColors.Control;
            this.modelText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modelText.Location = new System.Drawing.Point(43, 212);
            this.modelText.Name = "modelText";
            this.modelText.Size = new System.Drawing.Size(100, 16);
            this.modelText.TabIndex = 8;
            this.modelText.Text = "Model";
            // 
            // yearText
            // 
            this.yearText.BackColor = System.Drawing.SystemColors.Control;
            this.yearText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearText.Location = new System.Drawing.Point(43, 241);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(100, 16);
            this.yearText.TabIndex = 9;
            this.yearText.Text = "Year";
            // 
            // sizeSelector
            // 
            this.sizeSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sizeSelector.FormattingEnabled = true;
            this.sizeSelector.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.sizeSelector.Location = new System.Drawing.Point(149, 147);
            this.sizeSelector.Name = "sizeSelector";
            this.sizeSelector.Size = new System.Drawing.Size(84, 23);
            this.sizeSelector.TabIndex = 10;
            this.sizeSelector.Text = "-";
            this.sizeSelector.SelectedIndexChanged += new System.EventHandler(this.sizeSelector_SelectedIndexChanged);
            // 
            // milageSelector
            // 
            this.milageSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.milageSelector.FormattingEnabled = true;
            this.milageSelector.Items.AddRange(new object[] {
            "< 10k",
            "10k to 25k",
            "25k to 50k",
            "> 50k"});
            this.milageSelector.Location = new System.Drawing.Point(149, 176);
            this.milageSelector.Name = "milageSelector";
            this.milageSelector.Size = new System.Drawing.Size(84, 23);
            this.milageSelector.TabIndex = 11;
            this.milageSelector.Text = "-";
            this.milageSelector.SelectedIndexChanged += new System.EventHandler(this.milageSelector_SelectedIndexChanged);
            // 
            // yearSelector
            // 
            this.yearSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.yearSelector.FormattingEnabled = true;
            this.yearSelector.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010"});
            this.yearSelector.Location = new System.Drawing.Point(149, 234);
            this.yearSelector.Name = "yearSelector";
            this.yearSelector.Size = new System.Drawing.Size(84, 23);
            this.yearSelector.TabIndex = 12;
            this.yearSelector.Text = "-";
            this.yearSelector.SelectedIndexChanged += new System.EventHandler(this.yearSelector_SelectedIndexChanged);
            // 
            // modelSelector
            // 
            this.modelSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.modelSelector.FormattingEnabled = true;
            this.modelSelector.Items.AddRange(new object[] {
            "Volkswagen Golf",
            "Toyota Corola",
            "Subaru Outback",
            "Land Rover Defender",
            "Koenigsegg Gemera"});
            this.modelSelector.Location = new System.Drawing.Point(149, 205);
            this.modelSelector.Name = "modelSelector";
            this.modelSelector.Size = new System.Drawing.Size(84, 23);
            this.modelSelector.TabIndex = 13;
            this.modelSelector.Text = "-";
            this.modelSelector.SelectedIndexChanged += new System.EventHandler(this.modelSelector_SelectedIndexChanged);
            // 
            // ListingBox
            // 
            this.ListingBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListingBox.Controls.Add(this.ListingVID);
            this.ListingBox.Controls.Add(this.ListingRates);
            this.ListingBox.Controls.Add(this.ListingMilage);
            this.ListingBox.Controls.Add(this.ListingYear);
            this.ListingBox.Controls.Add(this.ListingSize);
            this.ListingBox.Controls.Add(this.ListingModel);
            this.ListingBox.Controls.Add(this.ListingNumber);
            this.ListingBox.Location = new System.Drawing.Point(257, 106);
            this.ListingBox.Name = "ListingBox";
            this.ListingBox.Size = new System.Drawing.Size(531, 93);
            this.ListingBox.TabIndex = 14;
            this.ListingBox.TabStop = false;
            this.ListingBox.Text = "exampleListing";
            // 
            // ListingRates
            // 
            this.ListingRates.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListingRates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListingRates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListingRates.ForeColor = System.Drawing.SystemColors.Window;
            this.ListingRates.Location = new System.Drawing.Point(194, 41);
            this.ListingRates.Multiline = true;
            this.ListingRates.Name = "ListingRates";
            this.ListingRates.Size = new System.Drawing.Size(125, 52);
            this.ListingRates.TabIndex = 15;
            this.ListingRates.Text = "Daily Rate: $50\r\nWeekly Rate: $300\r\nMonthly Rate: $900";
            // 
            // ListingMilage
            // 
            this.ListingMilage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListingMilage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListingMilage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListingMilage.ForeColor = System.Drawing.SystemColors.Window;
            this.ListingMilage.Location = new System.Drawing.Point(88, 48);
            this.ListingMilage.Name = "ListingMilage";
            this.ListingMilage.Size = new System.Drawing.Size(100, 16);
            this.ListingMilage.TabIndex = 4;
            this.ListingMilage.Text = "Milage: 20k KM";
            // 
            // ListingYear
            // 
            this.ListingYear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListingYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListingYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListingYear.ForeColor = System.Drawing.SystemColors.Window;
            this.ListingYear.Location = new System.Drawing.Point(6, 70);
            this.ListingYear.Name = "ListingYear";
            this.ListingYear.Size = new System.Drawing.Size(100, 16);
            this.ListingYear.TabIndex = 3;
            this.ListingYear.Text = "Year: 2008";
            // 
            // ListingSize
            // 
            this.ListingSize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListingSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListingSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListingSize.ForeColor = System.Drawing.SystemColors.Window;
            this.ListingSize.Location = new System.Drawing.Point(7, 48);
            this.ListingSize.Name = "ListingSize";
            this.ListingSize.Size = new System.Drawing.Size(75, 16);
            this.ListingSize.TabIndex = 2;
            this.ListingSize.Text = "Size: Small";
            // 
            // ListingModel
            // 
            this.ListingModel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListingModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListingModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListingModel.ForeColor = System.Drawing.SystemColors.Window;
            this.ListingModel.Location = new System.Drawing.Point(62, 22);
            this.ListingModel.Name = "ListingModel";
            this.ListingModel.Size = new System.Drawing.Size(151, 16);
            this.ListingModel.TabIndex = 1;
            this.ListingModel.Text = "Model: Volkswagen Golf";
            // 
            // ListingNumber
            // 
            this.ListingNumber.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListingNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListingNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListingNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.ListingNumber.Location = new System.Drawing.Point(7, 23);
            this.ListingNumber.Name = "ListingNumber";
            this.ListingNumber.Size = new System.Drawing.Size(135, 16);
            this.ListingNumber.TabIndex = 0;
            this.ListingNumber.Text = "Listing1";
            // 
            // ListingVID
            // 
            this.ListingVID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListingVID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListingVID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListingVID.ForeColor = System.Drawing.SystemColors.Window;
            this.ListingVID.Location = new System.Drawing.Point(219, 23);
            this.ListingVID.Name = "ListingVID";
            this.ListingVID.Size = new System.Drawing.Size(100, 16);
            this.ListingVID.TabIndex = 15;
            this.ListingVID.Text = "Vehicle ID: 5328";
            // 
            // BranchSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListingBox);
            this.Controls.Add(this.modelSelector);
            this.Controls.Add(this.yearSelector);
            this.Controls.Add(this.milageSelector);
            this.Controls.Add(this.sizeSelector);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.modelText);
            this.Controls.Add(this.milageText);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.availabeVehicleText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.branchText);
            this.Controls.Add(this.branchSelector);
            this.Name = "BranchSearch";
            this.Text = "BranchSearch1";
            this.Load += new System.EventHandler(this.BranchSearch_Load);
            this.ListingBox.ResumeLayout(false);
            this.ListingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox branchSelector;
        private System.Windows.Forms.TextBox branchText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox availabeVehicleText;
        private System.Windows.Forms.TextBox sizeText;
        private System.Windows.Forms.TextBox milageText;
        private System.Windows.Forms.TextBox ListingYear;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox modelText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.ComboBox sizeSelector;
        private System.Windows.Forms.ComboBox milageSelector;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox modelSelector;
        private System.Windows.Forms.ComboBox yearSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ListingModel;
        private System.Windows.Forms.TextBox ListingNumber;
        private System.Windows.Forms.TextBox ListingSize;
        private System.Windows.Forms.GroupBox ListingBox;
        private System.Windows.Forms.TextBox ListingMilage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ListingRates;
        private System.Windows.Forms.TextBox ListingVID;
    }
}