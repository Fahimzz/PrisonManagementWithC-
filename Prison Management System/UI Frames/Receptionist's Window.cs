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
    public partial class Receptionist_s_Window : Form
    {
        int user;
        NoticeService ns;
       
        ReceptionistService recpt;
        public Receptionist_s_Window()
        {
            InitializeComponent();
           

        }
        public Receptionist_s_Window(int user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("You have to Fill Up the Form First");
            }
            else
            {
                recpt = new ReceptionistService();

                int result = recpt.saveVisitor(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text, textBox5.Text, textBox6.Text);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void changepasswordbutton_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(user);
            this.Hide();
            cp.Show();
        }

        private void Receptionist_s_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            logInForm lf = new logInForm();
            this.Hide();
            lf.Show();
        }

        private void Receptionist_s_Window_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prison_Management_SystemDataSet.Notification' table. You can move, or remove it, as needed.
            this.notificationTableAdapter.Fill(this.prison_Management_SystemDataSet.Notification);

        }

        private void Noticebutton_Click(object sender, EventArgs e)
        {
            ns = new NoticeService();
            dataGridView1.DataSource = ns.getNotifications();
        }
    }
}
