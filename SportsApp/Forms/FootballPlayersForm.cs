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
    public partial class FootballPlayersForm : Form
    {
        public FootballPlayersForm()
        {
            InitializeComponent();
        }

        private void nfl_PlayersCurrentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nfl_PlayersCurrentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportInfoDataSet);

        }

        private void FootballPlayersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportInfoDataSet.nfl_PlayersCurrent' table. You can move, or remove it, as needed.
            this.nfl_PlayersCurrentTableAdapter.Fill(this.sportInfoDataSet.nfl_PlayersCurrent);

        }

        private void teamDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamDropdown.SelectedItem == null)
            {
                return;
            }
            else if (teamDropdown.SelectedItem == "Arizona Cardinals")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 1";
            }
            else if (teamDropdown.SelectedItem == "Atlanta Falcons")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 2";
            }
            else if (teamDropdown.SelectedItem == "Baltimore Ravens")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 3";
            }
            else if (teamDropdown.SelectedItem == "Buffalo Bills")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 4";
            }
            else if (teamDropdown.SelectedItem == "Carolina Panthers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 5";
            }
            else if (teamDropdown.SelectedItem == "Chicago Bears")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 6";
            }
            else if (teamDropdown.SelectedItem == "Cincinnati Bengals")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 7";
            }
            else if (teamDropdown.SelectedItem == "Cleveland Browns")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 8";
            }
            else if (teamDropdown.SelectedItem == "Dallas Cowboys")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 9";
            }
            else if (teamDropdown.SelectedItem == "Denver Broncos")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 10";
            }
            else if (teamDropdown.SelectedItem == "Detroit Lions")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 11";
            }
            else if (teamDropdown.SelectedItem == "Green Bay Packers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 12";
            }
            else if (teamDropdown.SelectedItem == "Houston Texans")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 13";
            }
            else if (teamDropdown.SelectedItem == "Indianapolis Colts")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 14";
            }
            else if (teamDropdown.SelectedItem == "Jacksonville Jaguars")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 15";
            }
            else if (teamDropdown.SelectedItem == "Kansas City Chiefs")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 16";
            }
            else if (teamDropdown.SelectedItem == "Las Vegas Raiders")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 17";
            }
            else if (teamDropdown.SelectedItem == "Los Angeles Chargers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 18";
            }
            else if (teamDropdown.SelectedItem == "Los Angeles Rams")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 19";
            }
            else if (teamDropdown.SelectedItem == "Miami Dolphins")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 20";
            }
            else if (teamDropdown.SelectedItem == "Minnesota Vikings")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 21";
            }
            else if (teamDropdown.SelectedItem == "New England Patriots")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 22";
            }
            else if (teamDropdown.SelectedItem == "New Orleans Saints")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 23";
            }
            else if (teamDropdown.SelectedItem == "New York Giants")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 24";
            }
            else if (teamDropdown.SelectedItem == "New York Jets")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 25";
            }
            else if (teamDropdown.SelectedItem == "Philadelphia Eagles")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 26";
            }
            else if (teamDropdown.SelectedItem == "Pittsburgh Steelers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 27";
            }
            else if (teamDropdown.SelectedItem == "San Francisco 49ers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 28";
            }
            else if (teamDropdown.SelectedItem == "Seattle Seahawks")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 29";
            }
            else if (teamDropdown.SelectedItem == "Tampa Bay Buccaneers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 30";
            }
            else if (teamDropdown.SelectedItem == "Tennessee Titans")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 31";
            }
            else if (teamDropdown.SelectedItem == "Washington Commanders")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 32";
            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void ApplySearchFilter()
        {
            string searchText = searchTextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                nfl_PlayersCurrentBindingSource.RemoveFilter();
                return;
            }

            searchText = searchText.Replace("'", "''");

            string filter =
                $"[Player] LIKE '%{searchText}%' OR " +
                $"[Position] LIKE '%{searchText}%' OR " +
                $"Convert([Height], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Weight], 'System.String') LIKE '%{searchText}%' OR " +
                $"[College] LIKE '%{searchText}%' OR " +
                $"[DateOfBirth] LIKE '%{searchText}%' OR " +
                $"[YearsPlayed] LIKE '%{searchText}%'";

            nfl_PlayersCurrentBindingSource.Filter = filter;
        }
    }
}
