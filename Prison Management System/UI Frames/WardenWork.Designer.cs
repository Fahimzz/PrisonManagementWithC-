namespace Prison_Management_System.UI_Frames
{
    partial class WardenWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WardenWork));
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.designationtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.getallButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(67, 46);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(29, 18);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(67, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.Location = new System.Drawing.Point(67, 142);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(102, 18);
            this.dLabel.TabIndex = 2;
            this.dLabel.Text = "Designation:";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.Location = new System.Drawing.Point(67, 195);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(60, 18);
            this.salaryLabel.TabIndex = 3;
            this.salaryLabel.Text = "Salary:";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(205, 36);
            this.idtextBox.Multiline = true;
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(213, 28);
            this.idtextBox.TabIndex = 4;
            this.idtextBox.TextChanged += new System.EventHandler(this.idtextBox_TextChanged);
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(205, 185);
            this.salarytextBox.Multiline = true;
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(213, 28);
            this.salarytextBox.TabIndex = 5;
            // 
            // designationtextBox
            // 
            this.designationtextBox.Location = new System.Drawing.Point(205, 132);
            this.designationtextBox.Multiline = true;
            this.designationtextBox.Name = "designationtextBox";
            this.designationtextBox.Size = new System.Drawing.Size(213, 28);
            this.designationtextBox.TabIndex = 6;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(205, 83);
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(213, 28);
            this.nametextBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(451, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(491, 255);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // loadButton
            // 
            this.loadButton.Image = ((System.Drawing.Image)(resources.GetObject("loadButton.Image")));
            this.loadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadButton.Location = new System.Drawing.Point(41, 351);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(117, 39);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Image = ((System.Drawing.Image)(resources.GetObject("insertButton.Image")));
            this.insertButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.insertButton.Location = new System.Drawing.Point(205, 351);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(134, 39);
            this.insertButton.TabIndex = 10;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButton.Location = new System.Drawing.Point(405, 351);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(115, 39);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(564, 351);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(115, 39);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshButton.Location = new System.Drawing.Point(722, 351);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(115, 39);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // getallButton
            // 
            this.getallButton.Image = ((System.Drawing.Image)(resources.GetObject("getallButton.Image")));
            this.getallButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getallButton.Location = new System.Drawing.Point(649, 294);
            this.getallButton.Name = "getallButton";
            this.getallButton.Size = new System.Drawing.Size(115, 39);
            this.getallButton.TabIndex = 14;
            this.getallButton.Text = "Get All";
            this.getallButton.UseVisualStyleBackColor = true;
            this.getallButton.Click += new System.EventHandler(this.getallButton_Click);
            // 
            // backButton
            // 
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(649, 429);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 39);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password";
            // 
            // passtextBox
            // 
            this.passtextBox.Location = new System.Drawing.Point(205, 247);
            this.passtextBox.Multiline = true;
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(213, 30);
            this.passtextBox.TabIndex = 17;
            // 
            // WardenWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 494);
            this.Controls.Add(this.passtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.getallButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.designationtextBox);
            this.Controls.Add(this.salarytextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WardenWork";
            this.Text = "Employee Information";
            this.Load += new System.EventHandler(this.WardenWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.TextBox designationtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button getallButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passtextBox;
    }
}