using sportsApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace sportsApp.Forms
{
    public partial class BasketballPlayersForm : Form
    {
        string currentSort = "Name ASC";

        public BasketballPlayersForm()
        {
            InitializeComponent();
            teamDropdown.SelectedIndex = 0;
            comboBoxSortTeams.SelectedItem = "Name";
        }

        private void nbaCurrentPlayersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nbaCurrentPlayersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportInfoDataSet);

        }

        private void BasketballPlayersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportInfoDataSet.nbaCurrentPlayers' table. You can move, or remove it, as needed.
            this.nbaCurrentPlayersTableAdapter.Fill(this.sportInfoDataSet.nbaCurrentPlayers);

        }

        // team sort
        // team sort
        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamDropdown.SelectedItem == null)
            {
                return;
            }
            else if (teamDropdown.SelectedItem == "Atlanta Hawks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 1";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Boston Celtics")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 2";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Brooklyn Nets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 3";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Charlotte Hornets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 4";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Chicago Bulls")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 5";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Cleveland Cavaliers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 6";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Dallas Mavericks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 7";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Denver Nuggets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 8";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Detroit Pistons")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 9";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Golden State Warriors")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 10";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Houston Rockets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 11";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Indiana Pacers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 12";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Los Angeles Clippers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 13";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Los Angeles Lakers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 14";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Memphis Grizzlies")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 15";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Miami Heat")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 16";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Milwaukee Bucks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 17";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Minnesota Timberwolves")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 18";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "New Orleans Pelicans")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 19";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "New York Knicks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 20";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Oklahoma City Thunder")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 21";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Orlando Magic")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 22";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Philadelphia 76ers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 23";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Phoenix Suns")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 24";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Portland Trail Blazers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 25";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Sacremento Kings")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 26";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "San Antonio Spurs")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 27";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Toronto Raptors")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 28";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Utah Jazz")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 29";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (teamDropdown.SelectedItem == "Washington Wizards")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 30";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
        }

        // sort by dropdown
        private void comboBoxSortTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSortTeams.SelectedIndex == -1)
            {
                return;
            }
            else if (comboBoxSortTeams.SelectedItem == "Name")
            {
                currentSort = "Name ASC";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (comboBoxSortTeams.SelectedItem == "Position")
            {
                currentSort = "Position ASC";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (comboBoxSortTeams.SelectedItem == "Height")
            {
                currentSort = "Height ASC";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (comboBoxSortTeams.SelectedItem == "Weight")
            {
                currentSort = "Weight ASC";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (comboBoxSortTeams.SelectedItem == "YearsInLeague")
            {
                currentSort = "YearsInLeague ASC";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (comboBoxSortTeams.SelectedItem == "BornIn")
            {
                currentSort = "BornIn ASC";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (comboBoxSortTeams.SelectedItem == "BirthYear")
            {
                currentSort = "BirthYear ASC";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (comboBoxSortTeams.SelectedItem == "DraftYear")
            {
                currentSort = "DraftYear ASC";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (comboBoxSortTeams.SelectedItem == "DraftRound")
            {
                currentSort = "DraftRound ASC";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
            else if (comboBoxSortTeams.SelectedItem == "DraftPick")
            {
                currentSort = "DraftPick ASC";
                nbaCurrentPlayersBindingSource.Sort = currentSort;
            }
        }

        // search method
        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                nbaCurrentPlayersBindingSource.RemoveFilter();
                return;
            }

            searchText = searchText.Replace("'", "''");

            string filter =
                $"[Name] LIKE '%{searchText}%' OR " +
                $"[Position] LIKE '%{searchText}%' OR " +
                $"Convert([Height], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Weight], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([YearsInLeague], 'System.String') LIKE '%{searchText}%' OR " +
                $"[BornIn] LIKE '%{searchText}%' OR " +
                $"Convert([BirthYear], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([DraftYear], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([DraftRound], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([DraftPick], 'System.String') LIKE '%{searchText}%'";

            nbaCurrentPlayersBindingSource.Filter = filter;
        }

        // clear all filters
        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            teamDropdown.SelectedIndex = -1;
            comboBoxSortTeams.SelectedIndex = -1;
            searchTextbox.Clear();
            nbaCurrentPlayersBindingSource.RemoveFilter();
            nbaCurrentPlayersBindingSource.Sort = "name";
        }
    }
}
