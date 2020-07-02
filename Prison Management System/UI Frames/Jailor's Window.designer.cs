namespace prisson
{
    partial class jailorwindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jailorwindow));
            this.manageprisonerButton = new System.Windows.Forms.Button();
            this.changepasswordButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.Noticebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prison_Management_SystemDataSet1 = new Prison_Management_System.Prison_Management_SystemDataSet1();
            this.notificationTableAdapter = new Prison_Management_System.Prison_Management_SystemDataSet1TableAdapters.NotificationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prison_Management_SystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageprisonerButton
            // 
            this.manageprisonerButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.manageprisonerButton.Location = new System.Drawing.Point(61, 280);
            this.manageprisonerButton.Margin = new System.Windows.Forms.Padding(4);
            this.manageprisonerButton.Name = "manageprisonerButton";
            this.manageprisonerButton.Size = new System.Drawing.Size(287, 46);
            this.manageprisonerButton.TabIndex = 0;
            this.manageprisonerButton.Text = "Manage Prisoner";
            this.manageprisonerButton.UseVisualStyleBackColor = false;
            this.manageprisonerButton.Click += new System.EventHandler(this.manageprisonerButton_Click);
            // 
            // changepasswordButton
            // 
            this.changepasswordButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.changepasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("changepasswordButton.Image")));
            this.changepasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changepasswordButton.Location = new System.Drawing.Point(950, 388);
            this.changepasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.changepasswordButton.Name = "changepasswordButton";
            this.changepasswordButton.Size = new System.Drawing.Size(261, 41);
            this.changepasswordButton.TabIndex = 1;
            this.changepasswordButton.Text = "Change Password";
            this.changepasswordButton.UseVisualStyleBackColor = false;
            this.changepasswordButton.Click += new System.EventHandler(this.changepasswordButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(948, 473);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(263, 44);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Noticebutton
            // 
            this.Noticebutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Noticebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Noticebutton.Image = ((System.Drawing.Image)(resources.GetObject("Noticebutton.Image")));
            this.Noticebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Noticebutton.Location = new System.Drawing.Point(756, 296);
            this.Noticebutton.Name = "Noticebutton";
            this.Noticebutton.Size = new System.Drawing.Size(188, 48);
            this.Noticebutton.TabIndex = 19;
            this.Noticebutton.Text = "Notice";
            this.Noticebutton.UseVisualStyleBackColor = false;
            this.Noticebutton.Click += new System.EventHandler(this.Noticebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.noticeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.notificationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(377, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 259);
            this.dataGridView1.TabIndex = 18;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 70;
            // 
            // noticeDataGridViewTextBoxColumn
            // 
            this.noticeDataGridViewTextBoxColumn.DataPropertyName = "Notice";
            this.noticeDataGridViewTextBoxColumn.HeaderText = "Notice";
            this.noticeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noticeDataGridViewTextBoxColumn.Name = "noticeDataGridViewTextBoxColumn";
            this.noticeDataGridViewTextBoxColumn.Width = 650;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // notificationBindingSource
            // 
            this.notificationBindingSource.DataMember = "Notification";
            this.notificationBindingSource.DataSource = this.prison_Management_SystemDataSet1;
            // 
            // prison_Management_SystemDataSet1
            // 
            this.prison_Management_SystemDataSet1.DataSetName = "Prison_Management_SystemDataSet1";
            this.prison_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notificationTableAdapter
            // 
            this.notificationTableAdapter.ClearBeforeFill = true;
            // 
            // jailorwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1233, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Noticebutton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.changepasswordButton);
            this.Controls.Add(this.manageprisonerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "jailorwindow";
            this.Text = "Jailor\'s Window";
            this.Load += new System.EventHandler(this.jailorwindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prison_Management_SystemDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageprisonerButton;
        private System.Windows.Forms.Button changepasswordButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button Noticebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Prison_Management_System.Prison_Management_SystemDataSet1 prison_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource notificationBindingSource;
        private Prison_Management_System.Prison_Management_SystemDataSet1TableAdapters.NotificationTableAdapter notificationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noticeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}

