using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportsApp
{
    public partial class RegistrationControl : UserControl
    {

        List<User> usersList = new List<User>();

        public RegistrationControl()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextbox.Text;
            string lastName = lastNameTextbox.Text;
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email)     || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Ensure all fields are complete.");
                return;
            }

            User newUser = new User(email, password, firstName, lastName);

            usersList.Add(newUser);

            MessageBox.Show("Registration Successful");

            firstNameTextbox.Clear();
            lastNameTextbox.Clear();
            emailTextbox.Clear();
            passwordTextbox.Clear();

            this.Parent.Controls.Remove(this);
        }

        private void RegistrationControl_Load(object sender, EventArgs e)
        {
            firstNameTextbox.Focus();
        }
    }
}
