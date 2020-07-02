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
using prisson;

using Prison_Management_System.Entities;

namespace Prison_Management_System.UI_Frames
{
    public partial class logInForm : Form
    {
        LoginServices login;
        int user;
        
        
        public logInForm()
        {
            InitializeComponent();
            login = new LoginServices();
        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (userIdBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Username or Password can not be empty");
            }
            else
            {
                int result = login.LoginValidation(userIdBox.Text, passwordTextBox.Text);
                
                    if (result == 1)
                    {
                        user = 1;
                        Warden w = new Warden(user);
                        w.Show();
                        this.Hide();
                    }
                    else if (result == 2)
                    {
                        user = 2;
                        jailorwindow j = new jailorwindow(user);
                        j.Show();
                        this.Hide();

                    }
                    else if (result == 3)
                    {
                        user = 3;
                        Receptionist_s_Window r = new Receptionist_s_Window(user);
                        r.Show();
                        this.Hide();

                    }
                    else { MessageBox.Show("Wrong Password"); }
            }
        }


                private void logInForm_Load(object sender, EventArgs e)
                {

                }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        }
    

