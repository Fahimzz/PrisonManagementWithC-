namespace Prison_Management_System.UI_Frames
{
    partial class logInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInForm));
            this.userLabel = new System.Windows.Forms.Label();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(251, 150);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(76, 20);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User Id:";
            this.userLabel.Click += new System.EventHandler(this.userLabel_Click);
            // 
            // userIdBox
            // 
            this.userIdBox.Location = new System.Drawing.Point(333, 141);
            this.userIdBox.Multiline = true;
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(177, 31);
            this.userIdBox.TabIndex = 1;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(230, 199);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(97, 20);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(333, 191);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(177, 28);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.Image")));
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(234, 270);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(171, 38);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(432, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(181, 38);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userIdBox);
            this.Controls.Add(this.userLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logInForm";
            this.Text = "Log In";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.logInForm_FormClosed);
            this.Load += new System.EventHandler(this.logInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
    }
}