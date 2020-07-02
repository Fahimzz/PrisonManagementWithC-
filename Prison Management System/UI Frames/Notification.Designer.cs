namespace Prison_Management_System.UI_Frames
{
    partial class Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.postbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 176);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(130, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notice";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(370, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // postbutton
            // 
            this.postbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.postbutton.Image = ((System.Drawing.Image)(resources.GetObject("postbutton.Image")));
            this.postbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postbutton.Location = new System.Drawing.Point(133, 321);
            this.postbutton.Name = "postbutton";
            this.postbutton.Size = new System.Drawing.Size(130, 41);
            this.postbutton.TabIndex = 3;
            this.postbutton.Text = "Post";
            this.postbutton.UseVisualStyleBackColor = true;
            this.postbutton.Click += new System.EventHandler(this.postbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.backbutton.Image = ((System.Drawing.Image)(resources.GetObject("backbutton.Image")));
            this.backbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbutton.Location = new System.Drawing.Point(305, 321);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(134, 41);
            this.backbutton.TabIndex = 4;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.postbutton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notification";
            this.Text = "Notification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notification_FormClosing);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button postbutton;
        private System.Windows.Forms.Button backbutton;
    }
}