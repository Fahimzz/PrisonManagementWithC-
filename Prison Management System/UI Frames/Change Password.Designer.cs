namespace Prison_Management_System.UI_Frames
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            this.backbutton = new System.Windows.Forms.Button();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginidtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Image = ((System.Drawing.Image)(resources.GetObject("backbutton.Image")));
            this.backbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbutton.Location = new System.Drawing.Point(549, 325);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(221, 41);
            this.backbutton.TabIndex = 15;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // confirmbutton
            // 
            this.confirmbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbutton.Image = ((System.Drawing.Image)(resources.GetObject("confirmbutton.Image")));
            this.confirmbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmbutton.Location = new System.Drawing.Point(308, 325);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(235, 41);
            this.confirmbutton.TabIndex = 14;
            this.confirmbutton.Text = "Confirm";
            this.confirmbutton.UseVisualStyleBackColor = true;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(189, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type Again:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Old Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(52, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Log in Id:";
            // 
            // loginidtextBox
            // 
            this.loginidtextBox.Location = new System.Drawing.Point(189, 61);
            this.loginidtextBox.Name = "loginidtextBox";
            this.loginidtextBox.Size = new System.Drawing.Size(177, 22);
            this.loginidtextBox.TabIndex = 17;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginidtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginidtextBox;
    }
}