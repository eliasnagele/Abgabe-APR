using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nagele_Jahresprojekt
{
    public partial class Login : Form
    {
        public static bool userisadmin = false;        //if userisadmin is true datagridview can be edited

        public Login()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            bool usernameexists = false;

            string username = tb_UsernameLogin.Text;        //getting username and password from textboxxes
            string password = tb_PasswordLogin.Text;

            usernameexists = SQLCommunication.CheckUsername(username);      //checking if username exists

            if (usernameexists.Equals(true))
            {
                bool matchingpassword = SQLCommunication.GetPassword(username, password);       //calling method 'GetPassword' which checks if password exists

                if (matchingpassword.Equals(true))
                {
                    userisadmin = SQLCommunication.CheckIfAdmin(username);
                    MessageBox.Show("Logged in");
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            bool usernameexists = false;

            string username = tb_UsernameRegister.Text;
            string password = tb_PasswordRegister.Text;                         //getting values from textboxes
            string confirmpassword = tb_ConfirmPasswordRegister.Text;

            usernameexists = SQLCommunication.CheckUsername(username);

            if(usernameexists.Equals(true)) 
            {
                MessageBox.Show("Username has already been taken");
                return;
            }
            else if(username.Equals("") || password.Equals("") || confirmpassword.Equals(""))
            {
                MessageBox.Show("Please fill all boxes");
                return;
            }
            else if (password.Equals(confirmpassword))         //checking if password and confirmpassword are identical
            {
                SQLCommunication.Register(username, password);      //calling method 'Register', which adds data to table 'login'
                MessageBox.Show("Registration successful");
                return;
            }
            else
            {
                MessageBox.Show("Passwords aren`t identical");
                return;
            }                       
        }

        private void bt_CloseLogin_Click(object sender, EventArgs e)        //close the application
        {
            Environment.Exit(0);
        }

        private void bt_ReturnLogin_Click(object sender, EventArgs e)       //return to form "Home"
        {
            this.Hide();
        }
    }
}
