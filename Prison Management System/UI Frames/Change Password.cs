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
using Prison_Management_System.Entities;
using Prison_Management_System.Services;
using prisson;


namespace Prison_Management_System.UI_Frames
{
    public partial class Change_Password : Form
    {
        
        User u;
        LoginServices logs;
        LoginServices ls;
        int user;
        
        public Change_Password()
        {
            InitializeComponent();
            
            
            

        }
       
        public Change_Password(int user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void confirmbutton_Click(object sender, EventArgs e)
        {

            logs = new LoginServices();
            int result = logs.Validation(loginidtextBox.Text, textBox1.Text);
            if(result!=0)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    ls = new LoginServices();

                    int r = ls.Updatepass(loginidtextBox.Text, textBox2.Text);
                    if(r>0)
                    {
                        MessageBox.Show("Password changed.. Login Again");
                        logInForm log = new logInForm();
                        log.Show();
                        this.Hide();
                        
                    }
                    else { MessageBox.Show("Error"); }
                }
                else { MessageBox.Show("Password is not matched"); }
            }
            else { MessageBox.Show("User id or password are wrong"); }
            
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                Warden wr = new Warden(user);
                this.Hide();
                wr.Show();
            }
            else if (user == 2)
            {
                jailorwindow jw = new jailorwindow(user);
                this.Hide();
                jw.Show();
            }
            else if (user == 3)
            {

                Receptionist_s_Window rw = new Receptionist_s_Window(user);
                this.Hide();
                rw.Show();
            }
            else { MessageBox.Show("Error"); }

        }
    }
}
