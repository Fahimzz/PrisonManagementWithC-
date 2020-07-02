namespace Prison_Management_System.UI_Frames
{
    partial class Receptionist_s_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist_s_Window));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.changepasswordbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prison_Management_SystemDataSet = new Prison_Management_System.Prison_Management_SystemDataSet();
            this.Noticebutton = new System.Windows.Forms.Button();
            this.notificationTableAdapter = new Prison_Management_System.Prison_Management_SystemDataSetTableAdapters.NotificationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prison_Management_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visitor Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prisoner Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Relation :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(253, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(253, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(253, 237);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(177, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(253, 279);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(177, 22);
            this.textBox6.TabIndex = 11;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.savebutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.savebutton.Image = ((System.Drawing.Image)(resources.GetObject("savebutton.Image")));
            this.savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebutton.Location = new System.Drawing.Point(119, 355);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(150, 39);
            this.savebutton.TabIndex = 12;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // refreshbutton
            // 
            this.refreshbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.refreshbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbutton.Image = ((System.Drawing.Image)(resources.GetObject("refreshbutton.Image")));
            this.refreshbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshbutton.Location = new System.Drawing.Point(320, 355);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(172, 39);
            this.refreshbutton.TabIndex = 13;
            this.refreshbutton.Text = "Refresh";
            this.refreshbutton.UseVisualStyleBackColor = false;
            this.refreshbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.logoutbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Image = ((System.Drawing.Image)(resources.GetObject("logoutbutton.Image")));
            this.logoutbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbutton.Location = new System.Drawing.Point(848, 439);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(265, 41);
            this.logoutbutton.TabIndex = 14;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // changepasswordbutton
            // 
            this.changepasswordbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.changepasswordbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepasswordbutton.Image = ((System.Drawing.Image)(resources.GetObject("changepasswordbutton.Image")));
            this.changepasswordbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changepasswordbutton.Location = new System.Drawing.Point(848, 371);
            this.changepasswordbutton.Name = "changepasswordbutton";
            this.changepasswordbutton.Size = new System.Drawing.Size(265, 42);
            this.changepasswordbutton.TabIndex = 15;
            this.changepasswordbutton.Text = "Change Password";
            this.changepasswordbutton.UseVisualStyleBackColor = false;
            this.changepasswordbutton.Click += new System.EventHandler(this.changepasswordbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.noticeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.notificationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(455, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(878, 219);
            this.dataGridView1.TabIndex = 16;
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
            this.notificationBindingSource.DataSource = this.prison_Management_SystemDataSet;
            // 
            // prison_Management_SystemDataSet
            // 
            this.prison_Management_SystemDataSet.DataSetName = "Prison_Management_SystemDataSet";
            this.prison_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Noticebutton
            // 
            this.Noticebutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Noticebutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Noticebutton.Image = ((System.Drawing.Image)(resources.GetObject("Noticebutton.Image")));
            this.Noticebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Noticebutton.Location = new System.Drawing.Point(656, 293);
            this.Noticebutton.Name = "Noticebutton";
            this.Noticebutton.Size = new System.Drawing.Size(160, 44);
            this.Noticebutton.TabIndex = 17;
            this.Noticebutton.Text = "Notice";
            this.Noticebutton.UseVisualStyleBackColor = false;
            this.Noticebutton.Click += new System.EventHandler(this.Noticebutton_Click);
            // 
            // notificationTableAdapter
            // 
            this.notificationTableAdapter.ClearBeforeFill = true;
            // 
            // Receptionist_s_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 492);
            this.Controls.Add(this.Noticebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.changepasswordbutton);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receptionist_s_Window";
            this.Text = "Receptionist_s_Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Receptionist_s_Window_FormClosing);
            this.Load += new System.EventHandler(this.Receptionist_s_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prison_Management_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button changepasswordbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Noticebutton;
        private Prison_Management_SystemDataSet prison_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource notificationBindingSource;
        private Prison_Management_SystemDataSetTableAdapters.NotificationTableAdapter notificationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noticeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}