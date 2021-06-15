
namespace _291CarProject
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.register_username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.confirm_password_text = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.province = new System.Windows.Forms.TextBox();
            this.driverLicense = new System.Windows.Forms.TextBox();
            this.genderTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // register_username_text
            // 
            this.register_username_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.register_username_text.Location = new System.Drawing.Point(286, 79);
            this.register_username_text.Name = "register_username_text";
            this.register_username_text.PlaceholderText = "Username";
            this.register_username_text.Size = new System.Drawing.Size(258, 23);
            this.register_username_text.TabIndex = 0;
            this.register_username_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.register_username_text.TextChanged += new System.EventHandler(this.register_username_text_TextChanged);
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(286, 108);
            this.password_text.Name = "password_text";
            this.password_text.PlaceholderText = "Password";
            this.password_text.Size = new System.Drawing.Size(258, 23);
            this.password_text.TabIndex = 1;
            this.password_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirm_password_text
            // 
            this.confirm_password_text.Location = new System.Drawing.Point(286, 137);
            this.confirm_password_text.Name = "confirm_password_text";
            this.confirm_password_text.PlaceholderText = "Confirm Password";
            this.confirm_password_text.Size = new System.Drawing.Size(258, 23);
            this.confirm_password_text.TabIndex = 2;
            this.confirm_password_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(477, 296);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(67, 23);
            this.register_button.TabIndex = 4;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(286, 296);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(152, 23);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Go Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(286, 167);
            this.firstName.Name = "firstName";
            this.firstName.PlaceholderText = "First Name";
            this.firstName.Size = new System.Drawing.Size(134, 23);
            this.firstName.TabIndex = 6;
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(427, 167);
            this.lastName.Name = "lastName";
            this.lastName.PlaceholderText = "Last Name";
            this.lastName.Size = new System.Drawing.Size(117, 23);
            this.lastName.TabIndex = 7;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(286, 197);
            this.street.Name = "street";
            this.street.PlaceholderText = "Street";
            this.street.Size = new System.Drawing.Size(258, 23);
            this.street.TabIndex = 8;
            this.street.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(286, 226);
            this.city.Name = "city";
            this.city.PlaceholderText = "City";
            this.city.Size = new System.Drawing.Size(100, 23);
            this.city.TabIndex = 9;
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(392, 227);
            this.province.Name = "province";
            this.province.PlaceholderText = "Province";
            this.province.Size = new System.Drawing.Size(152, 23);
            this.province.TabIndex = 10;
            this.province.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // driverLicense
            // 
            this.driverLicense.Location = new System.Drawing.Point(286, 256);
            this.driverLicense.Name = "driverLicense";
            this.driverLicense.PlaceholderText = "Driver License";
            this.driverLicense.Size = new System.Drawing.Size(134, 23);
            this.driverLicense.TabIndex = 11;
            this.driverLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genderTB
            // 
            this.genderTB.Location = new System.Drawing.Point(426, 256);
            this.genderTB.Name = "genderTB";
            this.genderTB.PlaceholderText = "Gender";
            this.genderTB.Size = new System.Drawing.Size(118, 23);
            this.genderTB.TabIndex = 12;
            this.genderTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.genderTB);
            this.Controls.Add(this.driverLicense);
            this.Controls.Add(this.province);
            this.Controls.Add(this.city);
            this.Controls.Add(this.street);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.confirm_password_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.register_username_text);
            this.Name = "Register";
            this.Text = "Project 291";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox register_username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox confirm_password_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.TextBox driverLicense;
        private System.Windows.Forms.TextBox genderTB;
    }
}