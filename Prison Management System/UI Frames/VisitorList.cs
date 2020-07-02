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
    public partial class VisitorList : Form
    {
        ReceptionistService r;
        public VisitorList()
        {
            InitializeComponent();
        }

        private void VisitorList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Warden w = new Warden();
            w.Show();
            this.Hide();
        }

        private void getallbutton_Click(object sender, EventArgs e)
        {
            r = new ReceptionistService();
            dataGridView1.DataSource = r.GetallVisitor();
        }
    }
}
