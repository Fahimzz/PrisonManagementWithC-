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

namespace prisson
{
    public partial class Prisoner : Form
    {
        PrisonerService prisn;
        public Prisoner()
        {
            InitializeComponent();
        }
        private void UpdateGridView()
        {
            dataGridView1.DataSource = prisn.getAllPrisoner();
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            prisn = new PrisonerService();
            dataGridView1.DataSource = prisn.getAllPrisoner();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("You have to Fill Up the Form First");
            }
            else
            {
                prisn = new PrisonerService();

                int result = prisn.savePrisoner(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToInt32(textBox6.Text), textBox7.Text);

                if (result > 0)
                {
                    MessageBox.Show("User registration successfull.");


                }
                else
                {
                    MessageBox.Show("Error");

                }
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            jailorwindow jw = new jailorwindow();
            jw.Show();
            this.Hide();
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            prisn = new PrisonerService();
            int result = prisn.deletePrisoner(textBox1.Text);
            if (result > 0)
            {
                MessageBox.Show("Deleted Successfully");
                UpdateGridView();
            }
            else
            { MessageBox.Show("Error"); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Prisoner_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void crimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void enterdateLabel_Click(object sender, EventArgs e)
        {

        }

        private void releasedateLabel_Click(object sender, EventArgs e)
        {

        }

        private void cellnoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nationalidLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           

        }
    }
}
