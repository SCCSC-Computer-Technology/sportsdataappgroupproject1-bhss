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

            // show loginform first
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
            basketballButton.Checked = false;
            footballButton.Checked = false;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            // sign out logged in user

            // display loginform again if user logs out.
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teamsButton_Click(object sender, EventArgs e)
        {
            if (basketballButton.Checked)
            {
                LoadIntoContent(new BasketballTeamsForm());
            } else if (footballButton.Checked)
            {
                LoadIntoContent(new FootballTeamsForm());
            }

        }

        private void playersButton_Click(object sender, EventArgs e)
        {
            if (basketballButton.Checked)
            {
                LoadIntoContent(new BasketballPlayersForm());
            }
            else if (footballButton.Checked)
            {
                LoadIntoContent(new FootballPlayersForm());
            }
        }











        // this is a method to place the selected tab's form
        // in the content Panel as opposed to a random screen location.
        private void LoadIntoContent(Form child)
        {
            contentPanel.Controls.Clear();

            child.TopLevel = false;
            child.Dock = DockStyle.Fill;

            contentPanel.Controls.Add(child);
            child.Show();
        }
    }
}
