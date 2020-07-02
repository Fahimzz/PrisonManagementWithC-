namespace Prison_Management_System.UI_Frames
{
    partial class VisitorList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getallbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // getallbutton
            // 
            this.getallbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.getallbutton.Image = ((System.Drawing.Image)(resources.GetObject("getallbutton.Image")));
            this.getallbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getallbutton.Location = new System.Drawing.Point(879, 351);
            this.getallbutton.Name = "getallbutton";
            this.getallbutton.Size = new System.Drawing.Size(197, 55);
            this.getallbutton.TabIndex = 1;
            this.getallbutton.Text = "Get All";
            this.getallbutton.UseVisualStyleBackColor = false;
            this.getallbutton.Click += new System.EventHandler(this.getallbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Image = ((System.Drawing.Image)(resources.GetObject("backbutton.Image")));
            this.backbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbutton.Location = new System.Drawing.Point(879, 438);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(197, 64);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // VisitorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 514);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.getallbutton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisitorList";
            this.Text = "VisitorList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisitorList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getallbutton;
        private System.Windows.Forms.Button backbutton;
    }
}