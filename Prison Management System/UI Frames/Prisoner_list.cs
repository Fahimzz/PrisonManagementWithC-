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

namespace Prison_Management_System.UI_Frames
{
    public partial class Prisoner_list : Form
    {
        PrisonerService ps;
        public Prisoner_list()
        {
            InitializeComponent();
        }

        private void Backbutton2_Click(object sender, EventArgs e)
        {
            Warden w = new Warden();
            w.Show();
            this.Hide();
        }

        private void GetAllbutton1_Click(object sender, EventArgs e)
        {
            ps = new PrisonerService();
            dataGridView1.DataSource = ps.getAllPrisoner();
        }
    }
}
