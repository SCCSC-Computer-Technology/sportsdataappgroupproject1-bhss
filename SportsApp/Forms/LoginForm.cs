using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportsApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            // if email and password are within database
            // grant access
            var usersAdapter = new SportInfoDataSetTableAdapters.UsersTableAdapter();
            
            //variables
            string email = emailTextbox.Text.Trim();
            string password = passwordTextbox.Text.Trim();

            //validate
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both text boxes.","Missing info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //first check if email exists
            //returns 0 if not found
            int? emailExists = usersAdapter.EmailExists(email);            
            if (emailExists == 0)
            {
                MessageBox.Show("Email not found.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check password            
            int? checkPassword = usersAdapter.ValidateLogin(email, password);
            if (checkPassword == 0)
            {
                MessageBox.Show("Password incorrect.", "Sign In Status Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (email == "dev")
                {
                    MessageBox.Show($"Welcome Developer", "Developer Sign In Status Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"User '{email}' Signed In", "Sign In Status Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                }
                
            }
        }
    }
}
