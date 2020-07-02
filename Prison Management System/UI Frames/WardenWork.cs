using System;
using Prison_Management_System.UI_Frames;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prison_Management_System.Services;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Prison_Management_System.UI_Frames
{
    public partial class WardenWork : Form
    {
        EmployeeService emps;
        LoginServices log;
        //string id;
        public WardenWork()
        {
            InitializeComponent();
            emps = new EmployeeService();
            log = new LoginServices();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int status = 0;
            if(idtextBox.Text=="" || nametextBox.Text=="" || designationtextBox.Text=="" || salarytextBox.Text=="" || passtextBox.Text=="")
            {
                MessageBox.Show("You have to Fill Up the Form First");
            }
            else
            {
                if(designationtextBox.Text=="Warden")
                {
                    status = 0;
                }
                else if(designationtextBox.Text=="Jailor")
                {
                    status = 1;
                }
                else if(designationtextBox.Text=="Receptionist")
                {
                    status = 2;
                }
                else { MessageBox.Show("Designation is not Right"); }

                int result = log.insertUser(idtextBox.Text,passtextBox.Text, status);
                int result1 = emps.insertEmployee(idtextBox.Text, nametextBox.Text, designationtextBox.Text, Convert.ToDouble(salarytextBox.Text));
                if (result > 0 || result1>0)
                {
                    MessageBox.Show("User registration successfull.");
                    UpdateGridView();

                }
                else
                {
                    MessageBox.Show("Error");

                }
            }
        }

        private void UpdateGridView()
        {
            dataGridView1.DataSource = emps.getAllEmployee();
        }

        private void WardenWork_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Warden w = new Warden();
            w.Show();
            this.Hide();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = emps.GetByEmpId(idtextBox.Text);
        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void getallButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = emps.getAllEmployee();
            //dataGridView1.ClearSelection();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            idtextBox.Text = "";
            nametextBox.Text = "";
            designationtextBox.Text = "";
            salarytextBox.Text = "";
            label1.Visible = true;
            passtextBox.Visible = true;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int result = log.deleteUser(idtextBox.Text);
            int result1 = emps.deleteEmployee(idtextBox.Text);
            if(result>0||result1>0)
            {
                MessageBox.Show("Deleted Successfully");
                UpdateGridView();
            }
            else
            { MessageBox.Show("Error"); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            idtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            designationtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            salarytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            passtextBox.Visible = false;
            label1.Visible = false;
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int result = emps.UpdateDetails(idtextBox.Text, nametextBox.Text, designationtextBox.Text,Convert.ToDouble( salarytextBox.Text));
            if(result>0)
            {
                MessageBox.Show("Updated!!!");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error Occered");
            }
        }
    }
}
