namespace Prison_Management_System.UI_Frames
{
    partial class Prisoner_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prisoner_list));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Backbutton2 = new System.Windows.Forms.Button();
            this.GetAllbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(13, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(991, 249);
            this.dataGridView1.TabIndex = 5;
            // 
            // Backbutton2
            // 
            this.Backbutton2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Backbutton2.Image = ((System.Drawing.Image)(resources.GetObject("Backbutton2.Image")));
            this.Backbutton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Backbutton2.Location = new System.Drawing.Point(917, 399);
            this.Backbutton2.Margin = new System.Windows.Forms.Padding(4);
            this.Backbutton2.Name = "Backbutton2";
            this.Backbutton2.Size = new System.Drawing.Size(195, 53);
            this.Backbutton2.TabIndex = 4;
            this.Backbutton2.Text = "Back";
            this.Backbutton2.UseVisualStyleBackColor = false;
            this.Backbutton2.Click += new System.EventHandler(this.Backbutton2_Click);
            // 
            // GetAllbutton1
            // 
            this.GetAllbutton1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GetAllbutton1.Image = ((System.Drawing.Image)(resources.GetObject("GetAllbutton1.Image")));
            this.GetAllbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GetAllbutton1.Location = new System.Drawing.Point(917, 313);
            this.GetAllbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.GetAllbutton1.Name = "GetAllbutton1";
            this.GetAllbutton1.Size = new System.Drawing.Size(195, 56);
            this.GetAllbutton1.TabIndex = 3;
            this.GetAllbutton1.Text = "Get All";
            this.GetAllbutton1.UseVisualStyleBackColor = false;
            this.GetAllbutton1.Click += new System.EventHandler(this.GetAllbutton1_Click);
            // 
            // Prisoner_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Backbutton2);
            this.Controls.Add(this.GetAllbutton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prisoner_list";
            this.Text = "Prisoner list";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Backbutton2;
        private System.Windows.Forms.Button GetAllbutton1;
    }
}