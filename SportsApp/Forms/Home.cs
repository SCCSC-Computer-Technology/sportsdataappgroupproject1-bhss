using sportsApp.Forms;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            // sign out logged in user

            // display loginform
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
