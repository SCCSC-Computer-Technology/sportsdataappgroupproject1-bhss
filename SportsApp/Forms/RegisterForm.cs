using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using sportsApp.SportInfoDataSetTableAdapters;

namespace sportsApp.Forms
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var usersAdapter = new SportInfoDataSetTableAdapters.UsersTableAdapter();

            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text))
            {
                MessageBox.Show("Please enter a first name.", "Info missing",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBoxLastName.Text))
            {
                MessageBox.Show("Please enter a last name.", "Info missing",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text)) 
            {
                MessageBox.Show("Please enter a valid email.", "Info missing",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBoxPassword.Text)) 
            {
                MessageBox.Show("Please enter a valid password.", "Info missing",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }                       

            //validate email
            string email = txtBoxEmail.Text.Trim();
            int? exists = usersAdapter.EmailExists(email);
            if (exists > 0)
            {
                MessageBox.Show("That email is already registered.",
                    "Registration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (lstBoxBasketballTeams.SelectedValue == null || lstBoxFootballTeams.SelectedValue == null)
            {
                MessageBox.Show("Please select both teams.");
                return;
            }             

            int nbaTeamID = (int)lstBoxBasketballTeams.SelectedValue;
            int nflTeamID = (int)lstBoxFootballTeams.SelectedValue;

            usersAdapter.Insert(
                txtBoxFirstName.Text,
                txtBoxLastName.Text,
                txtBoxEmail.Text,
                txtBoxPassword.Text,
                nbaTeamID,
                nflTeamID
              );
               
            MessageBox.Show("Account registered!", "Account Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                this.Close();
        }
                    
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //create table adapters to get favorite team and id
            var nbaAdapter = new SportInfoDataSetTableAdapters.NBATeamsTableAdapter();
            var nflAdapter = new SportInfoDataSetTableAdapters.NFLTeamsTableAdapter();

            var nbaTeams = nbaAdapter.GetData();
            var nflTeams = nflAdapter.GetData();

            lstBoxBasketballTeams.DataSource = nbaTeams;
            lstBoxBasketballTeams.DisplayMember = "TeamName";     
            lstBoxBasketballTeams.ValueMember = "NBATeamID";    

            lstBoxFootballTeams.DataSource = nflTeams;
            lstBoxFootballTeams.DisplayMember = "TeamName";
            lstBoxFootballTeams.ValueMember = "NFLTeamID";
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.UseSystemPasswordChar == true)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
