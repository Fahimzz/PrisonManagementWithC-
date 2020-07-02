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

namespace Prison_Management_System.UI_Frames
{
    public partial class Warden : Form
    {
        logInForm log;
        int user;
        public Warden(int user)
        {
            InitializeComponent();
            this.user = user;

        }
        public Warden()
        {
            InitializeComponent();
           // this.user = user;

        }
        public Warden(logInForm log)
        {
            InitializeComponent();
            this.log = log;
        }

        private void manageempButton_Click(object sender, EventArgs e)
        {
            WardenWork wk = new WardenWork();
            wk.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            logInForm lg = new logInForm();
            lg.Show();
            this.Hide();
        }

        private void checkPrisonerButton_Click(object sender, EventArgs e)
        {
            Prisoner_list pl = new Prisoner_list();
            pl.Show();
            this.Hide();
        }

        private void checkRprisonerButton_Click(object sender, EventArgs e)
        {
            Notification n = new Notification();
            n.Show();
            this.Hide();
        }

        private void checkvisitorButton_Click(object sender, EventArgs e)
        {
            VisitorList vl = new VisitorList();
            this.Hide();
            vl.Show();
        }

        private void changepassButton_Click(object sender, EventArgs e)
        {
            Change_Password c = new Change_Password(user);
            c.Show();
            this.Hide();
        }

        private void Warden_Load(object sender, EventArgs e)
        {

        }
    }
}
