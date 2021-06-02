
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.register_username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.confirm_password_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // register_username_text
            // 
            this.register_username_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.register_username_text.Location = new System.Drawing.Point(286, 67);
            this.register_username_text.Name = "register_username_text";
            this.register_username_text.PlaceholderText = "Username";
            this.register_username_text.Size = new System.Drawing.Size(258, 23);
            this.register_username_text.TabIndex = 0;
            this.register_username_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.register_username_text.TextChanged += new System.EventHandler(this.register_username_text_TextChanged);
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(286, 96);
            this.password_text.Name = "password_text";
            this.password_text.PlaceholderText = "Password";
            this.password_text.Size = new System.Drawing.Size(258, 23);
            this.password_text.TabIndex = 1;
            this.password_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirm_password_text
            // 
            this.confirm_password_text.Location = new System.Drawing.Point(286, 125);
            this.confirm_password_text.Name = "confirm_password_text";
            this.confirm_password_text.PlaceholderText = "Confirm Password";
            this.confirm_password_text.Size = new System.Drawing.Size(258, 23);
            this.confirm_password_text.TabIndex = 2;
            this.confirm_password_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(286, 154);
            this.email_text.Name = "email_text";
            this.email_text.PlaceholderText = "Email Address";
            this.email_text.Size = new System.Drawing.Size(258, 23);
            this.email_text.TabIndex = 3;
            this.email_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(477, 212);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(67, 23);
            this.register_button.TabIndex = 4;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(286, 212);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(152, 23);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Go Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.confirm_password_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.register_username_text);
            this.Name = "Register";
            this.Text = "Project 291";
            this.Load += new System.EventHandler(this.Register_Load);
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
    }
}