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
        private bool isSelected = false;

        public Home()
        {
            InitializeComponent();

            // show loginform first
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();

            // ensure that the radio buttons are not selected
            basketballButton.Checked = false;
            footballButton.Checked = false;

            // auto added via dgv to pull name signed in
            var currentUserAdapter = new SportInfoDataSetTableAdapters.CurrentUserTableAdapter();
            var dataTable = new SportInfoDataSet.CurrentUserDataTable();
            currentUserAdapter.Fill(dataTable);

            // assign signed in name to welcome label
            string name = currentUserAdapter.GetName();
            lblHeader.Text = $"Welcome, {name}!";

            buttonDashboard.BackColor = Color.CornflowerBlue;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            // sign out logged in user

            // display loginform again if user logs out.
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
            var currentUserAdapter = new SportInfoDataSetTableAdapters.CurrentUserTableAdapter();
            var dataTable = new SportInfoDataSet.CurrentUserDataTable();
            currentUserAdapter.Fill(dataTable);
            string name = currentUserAdapter.GetName();
            lblHeader.Text = $"Welcome, {name}!";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // loads teams form based on radio button selected
        private void teamsButton_Click(object sender, EventArgs e)
        {
            if (basketballButton.Checked)
            {
                LoadIntoContent(new BasketballTeamsForm());
            } else if (footballButton.Checked)
            {
                LoadIntoContent(new FootballTeamsForm());
            }
            //set colors for menu            
            buttonDashboard.BackColor = Color.Transparent;            
            playersButton.BackColor = Color.Transparent;
            statsButton.BackColor = Color.Transparent;
            scheduleButton.BackColor = Color.Transparent;
            standingsButton.BackColor = Color.Transparent;
            teamsButton.BackColor = Color.CornflowerBlue;

        }

        // loads players form based on radio button selected
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
            //set colors for menu
            buttonDashboard.BackColor = Color.Transparent;
            teamsButton.BackColor = Color.Transparent;            
            statsButton.BackColor = Color.Transparent;
            scheduleButton.BackColor = Color.Transparent;
            standingsButton.BackColor = Color.Transparent;
            playersButton.BackColor = Color.CornflowerBlue;
        }

        // loads stats form based on radio button selected
        private void statsButton_Click(object sender, EventArgs e)
        {
            if (basketballButton.Checked)
            {
                LoadIntoContent(new BasketballStatsForm());
            }
            else if (footballButton.Checked)
            {
                LoadIntoContent(new FootballStatsForm());
            }
            //set colors
            buttonDashboard.BackColor = Color.Transparent;
            teamsButton.BackColor = Color.Transparent;
            playersButton.BackColor = Color.Transparent;
            scheduleButton.BackColor = Color.Transparent;
            standingsButton.BackColor = Color.Transparent;
            statsButton.BackColor = Color.CornflowerBlue;
        }

        // loads schedules form based on radio button selected
        private void scheduleButton_Click(object sender, EventArgs e)
        {
            if (basketballButton.Checked)
            {
                LoadIntoContent(new BasketballSchedulesForm());
            }
            else if (footballButton.Checked)
            {
                LoadIntoContent(new FootballSchedulesForm());
            }
            //colors
            buttonDashboard.BackColor = Color.Transparent;
            teamsButton.BackColor = Color.Transparent;
            playersButton.BackColor = Color.Transparent;
            statsButton.BackColor = Color.Transparent;            
            standingsButton.BackColor = Color.Transparent;
            scheduleButton.BackColor = Color.CornflowerBlue;
        }

        // loads scores form based on radio button selected
        private void scoresButton_Click(object sender, EventArgs e)
        {
            if (basketballButton.Checked)
            {
                LoadIntoContent(new BasketballStandingsForm());
            }
            else if (footballButton.Checked)
            {
                LoadIntoContent(new FootballStandingsForm());
            }
            //colors
            buttonDashboard.BackColor = Color.Transparent;
            teamsButton.BackColor = Color.Transparent;
            playersButton.BackColor = Color.Transparent;
            statsButton.BackColor = Color.Transparent;
            scheduleButton.BackColor = Color.Transparent;
            standingsButton.BackColor = Color.CornflowerBlue;
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

        // this clears any forms loaded into the content panel
        // then adds header label
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            //clear main panel
            contentPanel.Controls.Clear();            
            contentPanel.Controls.Add(lblHeader);            
            teamsButton.BackColor = Color.Transparent;
            playersButton.BackColor = Color.Transparent;
            statsButton.BackColor = Color.Transparent;
            scheduleButton.BackColor = Color.Transparent;
            standingsButton.BackColor = Color.Transparent;
            buttonDashboard.BackColor = Color.CornflowerBlue;
        }
    }
}
