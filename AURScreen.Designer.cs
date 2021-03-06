
namespace _291CarProject
{
    partial class AURScreen
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
            this.AURTabs = new System.Windows.Forms.TabControl();
            this.AddTab = new System.Windows.Forms.TabPage();
            this.BranchText = new System.Windows.Forms.Label();
            this.DD_AddBranch = new System.Windows.Forms.ComboBox();
            this.VBrandText = new System.Windows.Forms.Label();
            this.TB_AddBrand = new System.Windows.Forms.TextBox();
            this.DD_AddSize = new System.Windows.Forms.ComboBox();
            this.TB_AddMilage = new System.Windows.Forms.TextBox();
            this.TB_AddYear = new System.Windows.Forms.TextBox();
            this.TB_AddModel = new System.Windows.Forms.TextBox();
            this.AddMilageText = new System.Windows.Forms.Label();
            this.VehicleYearText = new System.Windows.Forms.Label();
            this.AddSizeText = new System.Windows.Forms.Label();
            this.AddModelText = new System.Windows.Forms.Label();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.UpdateTab = new System.Windows.Forms.TabPage();
            this.uSearchButton = new System.Windows.Forms.Button();
            this.labelUpdateBranch = new System.Windows.Forms.Label();
            this.DD_UpdateBranch = new System.Windows.Forms.ComboBox();
            this.labelUpdateBrand = new System.Windows.Forms.Label();
            this.TB_UpdateBrand = new System.Windows.Forms.TextBox();
            this.DD_UpdateSize = new System.Windows.Forms.ComboBox();
            this.TB_UpdateMilage = new System.Windows.Forms.TextBox();
            this.TB_UpdateYear = new System.Windows.Forms.TextBox();
            this.TB_UpdateModel = new System.Windows.Forms.TextBox();
            this.TB_UpdateID = new System.Windows.Forms.TextBox();
            this.updateMilageText = new System.Windows.Forms.Label();
            this.updateYearText = new System.Windows.Forms.Label();
            this.updateSizeText = new System.Windows.Forms.Label();
            this.updateModelText = new System.Windows.Forms.Label();
            this.updateVIDText = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveTab = new System.Windows.Forms.TabPage();
            this.checkBoxConfirm = new System.Windows.Forms.CheckBox();
            this.TB_RemoveVID = new System.Windows.Forms.TextBox();
            this.RemoveVIDText = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AURTabs.SuspendLayout();
            this.AddTab.SuspendLayout();
            this.UpdateTab.SuspendLayout();
            this.RemoveTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // AURTabs
            // 
            this.AURTabs.Controls.Add(this.AddTab);
            this.AURTabs.Controls.Add(this.UpdateTab);
            this.AURTabs.Controls.Add(this.RemoveTab);
            this.AURTabs.Location = new System.Drawing.Point(12, 12);
            this.AURTabs.Name = "AURTabs";
            this.AURTabs.SelectedIndex = 0;
            this.AURTabs.Size = new System.Drawing.Size(776, 350);
            this.AURTabs.TabIndex = 0;
            // 
            // AddTab
            // 
            this.AddTab.Controls.Add(this.BranchText);
            this.AddTab.Controls.Add(this.DD_AddBranch);
            this.AddTab.Controls.Add(this.VBrandText);
            this.AddTab.Controls.Add(this.TB_AddBrand);
            this.AddTab.Controls.Add(this.DD_AddSize);
            this.AddTab.Controls.Add(this.TB_AddMilage);
            this.AddTab.Controls.Add(this.TB_AddYear);
            this.AddTab.Controls.Add(this.TB_AddModel);
            this.AddTab.Controls.Add(this.AddMilageText);
            this.AddTab.Controls.Add(this.VehicleYearText);
            this.AddTab.Controls.Add(this.AddSizeText);
            this.AddTab.Controls.Add(this.AddModelText);
            this.AddTab.Controls.Add(this.AddConfirm);
            this.AddTab.Location = new System.Drawing.Point(4, 24);
            this.AddTab.Name = "AddTab";
            this.AddTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddTab.Size = new System.Drawing.Size(768, 322);
            this.AddTab.TabIndex = 0;
            this.AddTab.Text = "Add";
            this.AddTab.UseVisualStyleBackColor = true;
            // 
            // BranchText
            // 
            this.BranchText.AutoSize = true;
            this.BranchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchText.Location = new System.Drawing.Point(26, 179);
            this.BranchText.Name = "BranchText";
            this.BranchText.Size = new System.Drawing.Size(61, 18);
            this.BranchText.TabIndex = 15;
            this.BranchText.Text = "Branch";
            // 
            // DD_AddBranch
            // 
            this.DD_AddBranch.FormattingEnabled = true;
            this.DD_AddBranch.Location = new System.Drawing.Point(185, 174);
            this.DD_AddBranch.Name = "DD_AddBranch";
            this.DD_AddBranch.Size = new System.Drawing.Size(175, 23);
            this.DD_AddBranch.TabIndex = 14;
            // 
            // VBrandText
            // 
            this.VBrandText.AutoSize = true;
            this.VBrandText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VBrandText.Location = new System.Drawing.Point(25, 92);
            this.VBrandText.Name = "VBrandText";
            this.VBrandText.Size = new System.Drawing.Size(111, 18);
            this.VBrandText.TabIndex = 13;
            this.VBrandText.Text = "Vehicle Brand";
            // 
            // TB_AddBrand
            // 
            this.TB_AddBrand.Location = new System.Drawing.Point(185, 87);
            this.TB_AddBrand.Name = "TB_AddBrand";
            this.TB_AddBrand.Size = new System.Drawing.Size(175, 23);
            this.TB_AddBrand.TabIndex = 12;
            // 
            // DD_AddSize
            // 
            this.DD_AddSize.FormattingEnabled = true;
            this.DD_AddSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.DD_AddSize.Location = new System.Drawing.Point(185, 29);
            this.DD_AddSize.Name = "DD_AddSize";
            this.DD_AddSize.Size = new System.Drawing.Size(175, 23);
            this.DD_AddSize.TabIndex = 11;
            // 
            // TB_AddMilage
            // 
            this.TB_AddMilage.Location = new System.Drawing.Point(185, 58);
            this.TB_AddMilage.Name = "TB_AddMilage";
            this.TB_AddMilage.Size = new System.Drawing.Size(175, 23);
            this.TB_AddMilage.TabIndex = 10;
            // 
            // TB_AddYear
            // 
            this.TB_AddYear.Location = new System.Drawing.Point(185, 145);
            this.TB_AddYear.Name = "TB_AddYear";
            this.TB_AddYear.Size = new System.Drawing.Size(175, 23);
            this.TB_AddYear.TabIndex = 9;
            // 
            // TB_AddModel
            // 
            this.TB_AddModel.Location = new System.Drawing.Point(185, 116);
            this.TB_AddModel.Name = "TB_AddModel";
            this.TB_AddModel.Size = new System.Drawing.Size(175, 23);
            this.TB_AddModel.TabIndex = 7;
            // 
            // AddMilageText
            // 
            this.AddMilageText.AutoSize = true;
            this.AddMilageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddMilageText.Location = new System.Drawing.Point(25, 63);
            this.AddMilageText.Name = "AddMilageText";
            this.AddMilageText.Size = new System.Drawing.Size(158, 18);
            this.AddMilageText.TabIndex = 5;
            this.AddMilageText.Text = "Vehicle Milage (KM)";
            // 
            // VehicleYearText
            // 
            this.VehicleYearText.AutoSize = true;
            this.VehicleYearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VehicleYearText.Location = new System.Drawing.Point(26, 150);
            this.VehicleYearText.Name = "VehicleYearText";
            this.VehicleYearText.Size = new System.Drawing.Size(101, 18);
            this.VehicleYearText.TabIndex = 4;
            this.VehicleYearText.Text = "Vehicle Year";
            // 
            // AddSizeText
            // 
            this.AddSizeText.AutoSize = true;
            this.AddSizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddSizeText.Location = new System.Drawing.Point(26, 34);
            this.AddSizeText.Name = "AddSizeText";
            this.AddSizeText.Size = new System.Drawing.Size(100, 18);
            this.AddSizeText.TabIndex = 3;
            this.AddSizeText.Text = "Vehicle Size";
            // 
            // AddModelText
            // 
            this.AddModelText.AutoSize = true;
            this.AddModelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddModelText.Location = new System.Drawing.Point(26, 121);
            this.AddModelText.Name = "AddModelText";
            this.AddModelText.Size = new System.Drawing.Size(113, 18);
            this.AddModelText.TabIndex = 2;
            this.AddModelText.Text = "Vehicle Model";
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(21, 282);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(75, 23);
            this.AddConfirm.TabIndex = 0;
            this.AddConfirm.Text = "Add";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // UpdateTab
            // 
            this.UpdateTab.Controls.Add(this.uSearchButton);
            this.UpdateTab.Controls.Add(this.labelUpdateBranch);
            this.UpdateTab.Controls.Add(this.DD_UpdateBranch);
            this.UpdateTab.Controls.Add(this.labelUpdateBrand);
            this.UpdateTab.Controls.Add(this.TB_UpdateBrand);
            this.UpdateTab.Controls.Add(this.DD_UpdateSize);
            this.UpdateTab.Controls.Add(this.TB_UpdateMilage);
            this.UpdateTab.Controls.Add(this.TB_UpdateYear);
            this.UpdateTab.Controls.Add(this.TB_UpdateModel);
            this.UpdateTab.Controls.Add(this.TB_UpdateID);
            this.UpdateTab.Controls.Add(this.updateMilageText);
            this.UpdateTab.Controls.Add(this.updateYearText);
            this.UpdateTab.Controls.Add(this.updateSizeText);
            this.UpdateTab.Controls.Add(this.updateModelText);
            this.UpdateTab.Controls.Add(this.updateVIDText);
            this.UpdateTab.Controls.Add(this.UpdateButton);
            this.UpdateTab.Location = new System.Drawing.Point(4, 24);
            this.UpdateTab.Name = "UpdateTab";
            this.UpdateTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTab.Size = new System.Drawing.Size(768, 322);
            this.UpdateTab.TabIndex = 1;
            this.UpdateTab.Text = "Update";
            this.UpdateTab.UseVisualStyleBackColor = true;
            // 
            // uSearchButton
            // 
            this.uSearchButton.Location = new System.Drawing.Point(337, 16);
            this.uSearchButton.Name = "uSearchButton";
            this.uSearchButton.Size = new System.Drawing.Size(75, 23);
            this.uSearchButton.TabIndex = 27;
            this.uSearchButton.Text = "Search";
            this.uSearchButton.UseVisualStyleBackColor = true;
            this.uSearchButton.Click += new System.EventHandler(this.uSearchButton_Click);
            // 
            // labelUpdateBranch
            // 
            this.labelUpdateBranch.AutoSize = true;
            this.labelUpdateBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUpdateBranch.Location = new System.Drawing.Point(20, 199);
            this.labelUpdateBranch.Name = "labelUpdateBranch";
            this.labelUpdateBranch.Size = new System.Drawing.Size(61, 18);
            this.labelUpdateBranch.TabIndex = 26;
            this.labelUpdateBranch.Text = "Branch";
            // 
            // DD_UpdateBranch
            // 
            this.DD_UpdateBranch.FormattingEnabled = true;
            this.DD_UpdateBranch.Location = new System.Drawing.Point(181, 194);
            this.DD_UpdateBranch.Name = "DD_UpdateBranch";
            this.DD_UpdateBranch.Size = new System.Drawing.Size(150, 23);
            this.DD_UpdateBranch.TabIndex = 25;
            // 
            // labelUpdateBrand
            // 
            this.labelUpdateBrand.AutoSize = true;
            this.labelUpdateBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUpdateBrand.Location = new System.Drawing.Point(20, 112);
            this.labelUpdateBrand.Name = "labelUpdateBrand";
            this.labelUpdateBrand.Size = new System.Drawing.Size(111, 18);
            this.labelUpdateBrand.TabIndex = 24;
            this.labelUpdateBrand.Text = "Vehicle Brand";
            // 
            // TB_UpdateBrand
            // 
            this.TB_UpdateBrand.Location = new System.Drawing.Point(181, 107);
            this.TB_UpdateBrand.Name = "TB_UpdateBrand";
            this.TB_UpdateBrand.Size = new System.Drawing.Size(150, 23);
            this.TB_UpdateBrand.TabIndex = 23;
            // 
            // DD_UpdateSize
            // 
            this.DD_UpdateSize.FormattingEnabled = true;
            this.DD_UpdateSize.Location = new System.Drawing.Point(181, 49);
            this.DD_UpdateSize.Name = "DD_UpdateSize";
            this.DD_UpdateSize.Size = new System.Drawing.Size(150, 23);
            this.DD_UpdateSize.TabIndex = 22;
            // 
            // TB_UpdateMilage
            // 
            this.TB_UpdateMilage.Location = new System.Drawing.Point(181, 78);
            this.TB_UpdateMilage.Name = "TB_UpdateMilage";
            this.TB_UpdateMilage.Size = new System.Drawing.Size(150, 23);
            this.TB_UpdateMilage.TabIndex = 21;
            // 
            // TB_UpdateYear
            // 
            this.TB_UpdateYear.Location = new System.Drawing.Point(181, 165);
            this.TB_UpdateYear.Name = "TB_UpdateYear";
            this.TB_UpdateYear.Size = new System.Drawing.Size(150, 23);
            this.TB_UpdateYear.TabIndex = 20;
            // 
            // TB_UpdateModel
            // 
            this.TB_UpdateModel.Location = new System.Drawing.Point(181, 136);
            this.TB_UpdateModel.Name = "TB_UpdateModel";
            this.TB_UpdateModel.Size = new System.Drawing.Size(150, 23);
            this.TB_UpdateModel.TabIndex = 18;
            // 
            // TB_UpdateID
            // 
            this.TB_UpdateID.Location = new System.Drawing.Point(181, 17);
            this.TB_UpdateID.Name = "TB_UpdateID";
            this.TB_UpdateID.Size = new System.Drawing.Size(150, 23);
            this.TB_UpdateID.TabIndex = 17;
            // 
            // updateMilageText
            // 
            this.updateMilageText.AutoSize = true;
            this.updateMilageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateMilageText.Location = new System.Drawing.Point(17, 83);
            this.updateMilageText.Name = "updateMilageText";
            this.updateMilageText.Size = new System.Drawing.Size(158, 18);
            this.updateMilageText.TabIndex = 16;
            this.updateMilageText.Text = "Vehicle Milage (KM)";
            // 
            // updateYearText
            // 
            this.updateYearText.AutoSize = true;
            this.updateYearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateYearText.Location = new System.Drawing.Point(20, 170);
            this.updateYearText.Name = "updateYearText";
            this.updateYearText.Size = new System.Drawing.Size(101, 18);
            this.updateYearText.TabIndex = 15;
            this.updateYearText.Text = "Vehicle Year";
            // 
            // updateSizeText
            // 
            this.updateSizeText.AutoSize = true;
            this.updateSizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateSizeText.Location = new System.Drawing.Point(20, 52);
            this.updateSizeText.Name = "updateSizeText";
            this.updateSizeText.Size = new System.Drawing.Size(100, 18);
            this.updateSizeText.TabIndex = 14;
            this.updateSizeText.Text = "Vehicle Size";
            // 
            // updateModelText
            // 
            this.updateModelText.AutoSize = true;
            this.updateModelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateModelText.Location = new System.Drawing.Point(20, 141);
            this.updateModelText.Name = "updateModelText";
            this.updateModelText.Size = new System.Drawing.Size(113, 18);
            this.updateModelText.TabIndex = 13;
            this.updateModelText.Text = "Vehicle Model";
            // 
            // updateVIDText
            // 
            this.updateVIDText.AutoSize = true;
            this.updateVIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateVIDText.Location = new System.Drawing.Point(20, 20);
            this.updateVIDText.Name = "updateVIDText";
            this.updateVIDText.Size = new System.Drawing.Size(83, 18);
            this.updateVIDText.TabIndex = 12;
            this.updateVIDText.Text = "Vehicle ID";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(20, 278);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveTab
            // 
            this.RemoveTab.Controls.Add(this.checkBoxConfirm);
            this.RemoveTab.Controls.Add(this.TB_RemoveVID);
            this.RemoveTab.Controls.Add(this.RemoveVIDText);
            this.RemoveTab.Controls.Add(this.RemoveButton);
            this.RemoveTab.Location = new System.Drawing.Point(4, 24);
            this.RemoveTab.Name = "RemoveTab";
            this.RemoveTab.Size = new System.Drawing.Size(768, 322);
            this.RemoveTab.TabIndex = 2;
            this.RemoveTab.Text = "Remove";
            this.RemoveTab.UseVisualStyleBackColor = true;
            // 
            // checkBoxConfirm
            // 
            this.checkBoxConfirm.AutoSize = true;
            this.checkBoxConfirm.Location = new System.Drawing.Point(293, 170);
            this.checkBoxConfirm.Name = "checkBoxConfirm";
            this.checkBoxConfirm.Size = new System.Drawing.Size(97, 19);
            this.checkBoxConfirm.TabIndex = 22;
            this.checkBoxConfirm.Text = "Confirmation";
            this.checkBoxConfirm.UseVisualStyleBackColor = true;
            // 
            // TB_RemoveVID
            // 
            this.TB_RemoveVID.Location = new System.Drawing.Point(293, 141);
            this.TB_RemoveVID.Name = "TB_RemoveVID";
            this.TB_RemoveVID.Size = new System.Drawing.Size(150, 23);
            this.TB_RemoveVID.TabIndex = 20;
            // 
            // RemoveVIDText
            // 
            this.RemoveVIDText.AutoSize = true;
            this.RemoveVIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveVIDText.Location = new System.Drawing.Point(204, 146);
            this.RemoveVIDText.Name = "RemoveVIDText";
            this.RemoveVIDText.Size = new System.Drawing.Size(83, 18);
            this.RemoveVIDText.TabIndex = 19;
            this.RemoveVIDText.Text = "Vehicle ID";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(449, 141);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 18;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 415);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AURScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AURTabs);
            this.Name = "AURScreen";
            this.Text = "AURScreen";
            this.Load += new System.EventHandler(this.AURScreen_Load);
            this.AURTabs.ResumeLayout(false);
            this.AddTab.ResumeLayout(false);
            this.AddTab.PerformLayout();
            this.UpdateTab.ResumeLayout(false);
            this.UpdateTab.PerformLayout();
            this.RemoveTab.ResumeLayout(false);
            this.RemoveTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AURTabs;
        private System.Windows.Forms.TabPage AddTab;
        private System.Windows.Forms.TabPage UpdateTab;
        private System.Windows.Forms.TabPage RemoveTab;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label AddModelText;
        private System.Windows.Forms.Label AddSizeText;
        private System.Windows.Forms.Label AddMilageText;
        private System.Windows.Forms.Label VehicleYearText;
        private System.Windows.Forms.TextBox TB_AddMilage;
        private System.Windows.Forms.TextBox TB_AddYear;
        private System.Windows.Forms.TextBox TB_AddModel;
        private System.Windows.Forms.TextBox TB_UpdateMilage;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox TB_UpdateModel;
        private System.Windows.Forms.TextBox TB_UpdateID;
        private System.Windows.Forms.Label updateMilageText;
        private System.Windows.Forms.Label updateYearText;
        private System.Windows.Forms.Label updateSizeText;
        private System.Windows.Forms.Label updateModelText;
        private System.Windows.Forms.Label updateVIDText;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox TB_UpdateYear;
        private System.Windows.Forms.TextBox TB_RemoveVID;
        private System.Windows.Forms.Label RemoveVIDText;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ComboBox DD_AddSize;
        private System.Windows.Forms.ComboBox DD_UpdateSize;
        private System.Windows.Forms.Label VBrandText;
        private System.Windows.Forms.TextBox TB_AddBrand;
        private System.Windows.Forms.Label BranchText;
        private System.Windows.Forms.ComboBox DD_AddBranch;
        private System.Windows.Forms.TextBox TB_UpdateBrand;
        private System.Windows.Forms.Label labelUpdateBrand;
        private System.Windows.Forms.ComboBox DD_UpdateBranch;
        private System.Windows.Forms.Label labelUpdateBranch;
        private System.Windows.Forms.Button uSearchButton;
        private System.Windows.Forms.CheckBox checkBoxConfirm;
    }
}