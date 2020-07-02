using Prison_Management_System.Services;
using Prison_Management_System.UI_Frames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisson
{
    public partial class jailorwindow : Form
    {
        int user;
        NoticeService ns;
        public jailorwindow(int user)
        {
            InitializeComponent();
            this.user = user;
        }
        public jailorwindow()
        {
            InitializeComponent();
           
        }

        private void manageprisonerButton_Click(object sender, EventArgs e)
        {
            Prisoner pr = new Prisoner();
            pr.Show();
            this.Hide();
        }

        private void changepasswordButton_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(user);
            this.Hide();
            cp.Show();

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            logInForm lg = new logInForm();
            lg.Show();
            this.Hide();
        }

        private void Noticebutton_Click(object sender, EventArgs e)
        {
            ns = new NoticeService();
            dataGridView1.DataSource = ns.getNotifications();
        }

        private void jailorwindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prison_Management_SystemDataSet1.Notification' table. You can move, or remove it, as needed.
            this.notificationTableAdapter.Fill(this.prison_Management_SystemDataSet1.Notification);

        }
    }
}
