
namespace _291CarProject
{
    partial class Form1
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
            this.borrow_button = new System.Windows.Forms.Button();
            this.return_bottom = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borrow_button
            // 
            this.borrow_button.Location = new System.Drawing.Point(297, 90);
            this.borrow_button.Name = "borrow_button";
            this.borrow_button.Size = new System.Drawing.Size(180, 111);
            this.borrow_button.TabIndex = 0;
            this.borrow_button.Text = "Borrow";
            this.borrow_button.UseVisualStyleBackColor = true;
            this.borrow_button.Click += new System.EventHandler(this.borrow_button_Click);
            // 
            // return_bottom
            // 
            this.return_bottom.Location = new System.Drawing.Point(297, 247);
            this.return_bottom.Name = "return_bottom";
            this.return_bottom.Size = new System.Drawing.Size(180, 111);
            this.return_bottom.TabIndex = 1;
            this.return_bottom.Text = "Return";
            this.return_bottom.UseVisualStyleBackColor = true;
            this.return_bottom.Click += new System.EventHandler(this.return_bottom_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(695, 402);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.return_bottom);
            this.Controls.Add(this.borrow_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button borrow_button;
        private System.Windows.Forms.Button return_bottom;
        private System.Windows.Forms.Button BackButton;
    }
}