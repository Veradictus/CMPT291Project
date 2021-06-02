
namespace _291CarProject
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_button = new System.Windows.Forms.Button();
            this.username_field = new System.Windows.Forms.TextBox();
            this.password_field = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.login_button.Location = new System.Drawing.Point(193, 304);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(302, 34);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // username_field
            // 
            this.username_field.Location = new System.Drawing.Point(193, 66);
            this.username_field.Name = "username_field";
            this.username_field.PlaceholderText = "Username";
            this.username_field.Size = new System.Drawing.Size(424, 23);
            this.username_field.TabIndex = 1;
            this.username_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username_field.TextChanged += new System.EventHandler(this.username_field_TextChanged);
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(193, 95);
            this.password_field.Name = "password_field";
            this.password_field.PlaceholderText = "Password";
            this.password_field.Size = new System.Drawing.Size(424, 23);
            this.password_field.TabIndex = 2;
            this.password_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register_button
            // 
            this.register_button.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.register_button.Location = new System.Drawing.Point(543, 305);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(74, 33);
            this.register_button.TabIndex = 3;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.username_field);
            this.Controls.Add(this.login_button);
            this.Name = "Login";
            this.Text = "Project 291";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox username_field;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Button register_button;
    }
}

