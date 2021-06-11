
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
            this.backButton = new System.Windows.Forms.Button();
            this.sizeSelector = new System.Windows.Forms.ComboBox();
            this.milageSelector = new System.Windows.Forms.ComboBox();
            this.yearSelector = new System.Windows.Forms.ComboBox();
            this.modelSelector = new System.Windows.Forms.ComboBox();
            this.labelSBranch = new System.Windows.Forms.Label();
            this.labelSSize = new System.Windows.Forms.Label();
            this.labelSMilage = new System.Windows.Forms.Label();
            this.labelSYear = new System.Windows.Forms.Label();
            this.labelSModel = new System.Windows.Forms.Label();
            this.labelAvailableV = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.updateSearchButton = new System.Windows.Forms.Button();
            this.SearchResultGrid = new System.Windows.Forms.DataGridView();
            this.vehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandSelector = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // branchSelector
            // 
            this.branchSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.branchSelector.FormattingEnabled = true;
            this.branchSelector.Items.AddRange(new object[] {
            "-",
            "Branch 1",
            "Branch 2",
            "Branch 3"});
            this.branchSelector.Location = new System.Drawing.Point(13, 34);
            this.branchSelector.Name = "branchSelector";
            this.branchSelector.Size = new System.Drawing.Size(100, 23);
            this.branchSelector.TabIndex = 0;
            this.branchSelector.SelectedIndexChanged += new System.EventHandler(this.branchSelector_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(11, 371);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sizeSelector
            // 
            this.sizeSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sizeSelector.FormattingEnabled = true;
            this.sizeSelector.Items.AddRange(new object[] {
            "-",
            "Small",
            "Medium",
            "Large"});
            this.sizeSelector.Location = new System.Drawing.Point(88, 121);
            this.sizeSelector.Name = "sizeSelector";
            this.sizeSelector.Size = new System.Drawing.Size(84, 23);
            this.sizeSelector.TabIndex = 10;
            this.sizeSelector.SelectedIndexChanged += new System.EventHandler(this.sizeSelector_SelectedIndexChanged);
            // 
            // milageSelector
            // 
            this.milageSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.milageSelector.FormattingEnabled = true;
            this.milageSelector.Items.AddRange(new object[] {
            "-",
            "< 10k",
            "10k to 25k",
            "25k to 50k",
            "> 50k"});
            this.milageSelector.Location = new System.Drawing.Point(88, 150);
            this.milageSelector.Name = "milageSelector";
            this.milageSelector.Size = new System.Drawing.Size(84, 23);
            this.milageSelector.TabIndex = 11;
            this.milageSelector.SelectedIndexChanged += new System.EventHandler(this.milageSelector_SelectedIndexChanged);
            // 
            // yearSelector
            // 
            this.yearSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.yearSelector.FormattingEnabled = true;
            this.yearSelector.Items.AddRange(new object[] {
            "-",
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
            this.yearSelector.Location = new System.Drawing.Point(88, 239);
            this.yearSelector.Name = "yearSelector";
            this.yearSelector.Size = new System.Drawing.Size(84, 23);
            this.yearSelector.TabIndex = 12;
            this.yearSelector.SelectedIndexChanged += new System.EventHandler(this.yearSelector_SelectedIndexChanged);
            // 
            // modelSelector
            // 
            this.modelSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.modelSelector.FormattingEnabled = true;
            this.modelSelector.Items.AddRange(new object[] {
            "-",
            "Volkswagen Golf",
            "Toyota Corola",
            "Subaru Outback",
            "Land Rover Defender",
            "Koenigsegg Gemera"});
            this.modelSelector.Location = new System.Drawing.Point(88, 210);
            this.modelSelector.Name = "modelSelector";
            this.modelSelector.Size = new System.Drawing.Size(84, 23);
            this.modelSelector.TabIndex = 13;
            this.modelSelector.SelectedIndexChanged += new System.EventHandler(this.modelSelector_SelectedIndexChanged);
            // 
            // labelSBranch
            // 
            this.labelSBranch.AutoSize = true;
            this.labelSBranch.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelSBranch.Location = new System.Drawing.Point(13, 16);
            this.labelSBranch.Name = "labelSBranch";
            this.labelSBranch.Size = new System.Drawing.Size(84, 15);
            this.labelSBranch.TabIndex = 15;
            this.labelSBranch.Text = "Select Branch";
            // 
            // labelSSize
            // 
            this.labelSSize.AutoSize = true;
            this.labelSSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSSize.Location = new System.Drawing.Point(13, 129);
            this.labelSSize.Name = "labelSSize";
            this.labelSSize.Size = new System.Drawing.Size(30, 15);
            this.labelSSize.TabIndex = 16;
            this.labelSSize.Text = "Size";
            // 
            // labelSMilage
            // 
            this.labelSMilage.AutoSize = true;
            this.labelSMilage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSMilage.Location = new System.Drawing.Point(13, 158);
            this.labelSMilage.Name = "labelSMilage";
            this.labelSMilage.Size = new System.Drawing.Size(44, 15);
            this.labelSMilage.TabIndex = 17;
            this.labelSMilage.Text = "Milage";
            // 
            // labelSYear
            // 
            this.labelSYear.AutoSize = true;
            this.labelSYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSYear.Location = new System.Drawing.Point(13, 247);
            this.labelSYear.Name = "labelSYear";
            this.labelSYear.Size = new System.Drawing.Size(31, 15);
            this.labelSYear.TabIndex = 18;
            this.labelSYear.Text = "Year";
            // 
            // labelSModel
            // 
            this.labelSModel.AutoSize = true;
            this.labelSModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSModel.Location = new System.Drawing.Point(13, 218);
            this.labelSModel.Name = "labelSModel";
            this.labelSModel.Size = new System.Drawing.Size(42, 15);
            this.labelSModel.TabIndex = 19;
            this.labelSModel.Text = "Model";
            // 
            // labelAvailableV
            // 
            this.labelAvailableV.AutoSize = true;
            this.labelAvailableV.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelAvailableV.Location = new System.Drawing.Point(263, 9);
            this.labelAvailableV.Name = "labelAvailableV";
            this.labelAvailableV.Size = new System.Drawing.Size(149, 21);
            this.labelAvailableV.TabIndex = 20;
            this.labelAvailableV.Text = "Available Vehicles";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(88, 63);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(141, 23);
            this.dateFrom.TabIndex = 21;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(88, 92);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(141, 23);
            this.dateTo.TabIndex = 22;
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateFrom.Location = new System.Drawing.Point(13, 71);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(69, 15);
            this.labelDateFrom.TabIndex = 23;
            this.labelDateFrom.Text = "Date From:";
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateTo.Location = new System.Drawing.Point(13, 100);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(53, 15);
            this.labelDateTo.TabIndex = 24;
            this.labelDateTo.Text = "Date To:";
            // 
            // updateSearchButton
            // 
            this.updateSearchButton.Location = new System.Drawing.Point(13, 275);
            this.updateSearchButton.Name = "updateSearchButton";
            this.updateSearchButton.Size = new System.Drawing.Size(100, 23);
            this.updateSearchButton.TabIndex = 25;
            this.updateSearchButton.Text = "Update Search";
            this.updateSearchButton.UseVisualStyleBackColor = true;
            this.updateSearchButton.Click += new System.EventHandler(this.updateSearchButton_Click);
            // 
            // SearchResultGrid
            // 
            this.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleID,
            this.vBrand,
            this.vModel,
            this.vYear,
            this.vBranch,
            this.vType,
            this.vDRate,
            this.vWRate,
            this.vMRate});
            this.SearchResultGrid.Location = new System.Drawing.Point(263, 33);
            this.SearchResultGrid.Name = "SearchResultGrid";
            this.SearchResultGrid.RowTemplate.Height = 25;
            this.SearchResultGrid.Size = new System.Drawing.Size(943, 315);
            this.SearchResultGrid.TabIndex = 26;
            // 
            // vehicleID
            // 
            this.vehicleID.HeaderText = "Vehicle ID";
            this.vehicleID.Name = "vehicleID";
            // 
            // vBrand
            // 
            this.vBrand.HeaderText = "Brand";
            this.vBrand.Name = "vBrand";
            // 
            // vModel
            // 
            this.vModel.HeaderText = "Model";
            this.vModel.Name = "vModel";
            // 
            // vYear
            // 
            this.vYear.HeaderText = "Year";
            this.vYear.Name = "vYear";
            // 
            // vBranch
            // 
            this.vBranch.HeaderText = "Branch";
            this.vBranch.Name = "vBranch";
            // 
            // vType
            // 
            this.vType.HeaderText = "Type";
            this.vType.Name = "vType";
            // 
            // vDRate
            // 
            this.vDRate.HeaderText = "Day Rate";
            this.vDRate.Name = "vDRate";
            // 
            // vWRate
            // 
            this.vWRate.HeaderText = "Weekly Rate";
            this.vWRate.Name = "vWRate";
            // 
            // vMRate
            // 
            this.vMRate.HeaderText = "Monthly Rate";
            this.vMRate.Name = "vMRate";
            // 
            // brandSelector
            // 
            this.brandSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.brandSelector.FormattingEnabled = true;
            this.brandSelector.Items.AddRange(new object[] {
            "-",
            "Volkswagen Golf",
            "Toyota Corola",
            "Subaru Outback",
            "Land Rover Defender",
            "Koenigsegg Gemera"});
            this.brandSelector.Location = new System.Drawing.Point(88, 179);
            this.brandSelector.Name = "brandSelector";
            this.brandSelector.Size = new System.Drawing.Size(84, 23);
            this.brandSelector.TabIndex = 27;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBrand.Location = new System.Drawing.Point(12, 187);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(40, 15);
            this.labelBrand.TabIndex = 28;
            this.labelBrand.Text = "Brand";
            // 
            // BranchSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1222, 405);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.brandSelector);
            this.Controls.Add(this.SearchResultGrid);
            this.Controls.Add(this.updateSearchButton);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.labelAvailableV);
            this.Controls.Add(this.labelSModel);
            this.Controls.Add(this.labelSYear);
            this.Controls.Add(this.labelSMilage);
            this.Controls.Add(this.labelSSize);
            this.Controls.Add(this.labelSBranch);
            this.Controls.Add(this.modelSelector);
            this.Controls.Add(this.yearSelector);
            this.Controls.Add(this.milageSelector);
            this.Controls.Add(this.sizeSelector);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.branchSelector);
            this.Name = "BranchSearch";
            this.Text = "BranchSearch1";
            this.Load += new System.EventHandler(this.BranchSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox branchSelector;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox sizeSelector;
        private System.Windows.Forms.ComboBox milageSelector;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox modelSelector;
        private System.Windows.Forms.ComboBox yearSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelSBranch;
        private System.Windows.Forms.Label labelSSize;
        private System.Windows.Forms.Label labelSMilage;
        private System.Windows.Forms.Label labelSYear;
        private System.Windows.Forms.Label labelSModel;
        private System.Windows.Forms.Label labelAvailableV;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Button updateSearchButton;
        private System.Windows.Forms.DataGridView SearchResultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn vModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn vYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn vBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn vType;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vWRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vMRate;
        private System.Windows.Forms.ComboBox brandSelector;
        private System.Windows.Forms.Label labelBrand;
    }
}