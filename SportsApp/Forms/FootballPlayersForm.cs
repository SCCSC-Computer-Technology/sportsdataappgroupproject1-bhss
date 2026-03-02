using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportsApp.Forms
{
    public partial class FootballPlayersForm : Form
    {
        string currentSort = "Player ASC";

        public FootballPlayersForm()
        {
            InitializeComponent();
            teamDropdown.SelectedIndex = 0;
            sortByDropdown.SelectedIndex = 0;
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

            // import current user
            var currentUserAdapter = new SportInfoDataSetTableAdapters.CurrentUserTableAdapter();
            var dataTable = new SportInfoDataSet.CurrentUserDataTable();
            currentUserAdapter.Fill(dataTable);
            int nflTeam = Convert.ToInt32(currentUserAdapter.GetNFLTeam());

            //show favorite team on load
            nfl_PlayersCurrentBindingSource.Filter = $"TeamID = {nflTeam}";
            nfl_PlayersCurrentBindingSource.Sort = currentSort;

            if (nflTeam > 0 && nflTeam <= 32)
            {
                teamDropdown.SelectedIndex = nflTeam - 1;
            }
        }

        // team selection
        private void teamDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamDropdown.SelectedItem == null)
            {
                return;
            }
            else if (teamDropdown.SelectedItem == "Arizona Cardinals")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 1";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Atlanta Falcons")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 2";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Baltimore Ravens")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 3";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Buffalo Bills")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 4";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Carolina Panthers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 5";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Chicago Bears")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 6";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Cincinnati Bengals")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 7";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Cleveland Browns")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 8";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Dallas Cowboys")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 9";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Denver Broncos")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 10";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Detroit Lions")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 11";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Green Bay Packers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 12";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Houston Texans")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 13";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Indianapolis Colts")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 14";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Jacksonville Jaguars")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 15";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Kansas City Chiefs")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 16";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Las Vegas Raiders")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 17";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Los Angeles Chargers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 18";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Los Angeles Rams")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 19";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Miami Dolphins")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 20";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Minnesota Vikings")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 21";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "New England Patriots")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 22";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "New Orleans Saints")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 23";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "New York Giants")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 24";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "New York Jets")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 25";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Philadelphia Eagles")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 26";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Pittsburgh Steelers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 27";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "San Francisco 49ers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 28";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Seattle Seahawks")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 29";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Tampa Bay Buccaneers")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 30";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Tennessee Titans")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 31";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Washington Commanders")
            {
                nfl_PlayersCurrentBindingSource.Filter = "TeamID = 32";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
        }

        // search method
        private void searchTextbox_TextChanged(object sender, EventArgs e)
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
            nfl_PlayersCurrentBindingSource.Sort = currentSort;
        }

        // clear all filters
        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            nfl_PlayersCurrentBindingSource.RemoveFilter();
            teamDropdown.SelectedIndex = -1;
            sortByDropdown.SelectedIndex = -1;
            searchTextbox.Clear();

            currentSort = "Player ASC";
            nfl_PlayersCurrentBindingSource.Sort = currentSort;
        }

        // once team is selected. this sorts the team data
        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByDropdown.SelectedIndex == -1)
            {
                return;
            }
            else if (sortByDropdown.SelectedItem == "Player")
            {
                currentSort = "Player ASC";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (sortByDropdown.SelectedItem == "Position")
            {
                currentSort = "Position ASC";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (sortByDropdown.SelectedItem == "Height")
            {
                currentSort = "Height ASC";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (sortByDropdown.SelectedItem == "Weight")
            {
                currentSort = "Weight ASC";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (sortByDropdown.SelectedItem == "College")
            {
                currentSort = "College ASC";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (sortByDropdown.SelectedItem == "DateOfBirth")
            {
                currentSort = "DateOfBirth ASC";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
            else if (sortByDropdown.SelectedItem == "YearsPlayed")
            {
                currentSort = "YearsPlayed ASC";
                nfl_PlayersCurrentBindingSource.Sort = currentSort;
            }
        }
    }
}