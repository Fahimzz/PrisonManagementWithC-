using Prison_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Management_System.UI_Frames
{
    public partial class Notification : Form
    {
        NoticeService n;
        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {

        }

        private void Notification_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Warden w = new Warden();
            w.Show();
            this.Hide();
        }

        private void postbutton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||dateTimePicker1.Text=="")
            {
                MessageBox.Show("Fill the Boxes First");
            }
            else
            {
                n = new NoticeService();
                int result = n.Postnotice(textBox1.Text, dateTimePicker1.Text);
                if(result>0)
                {
                    MessageBox.Show("Posted");
                }
                else { MessageBox.Show("Error"); }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
