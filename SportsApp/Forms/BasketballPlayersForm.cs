using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace sportsApp.Forms
{
    public partial class BasketballPlayersForm : Form
    {
        public BasketballPlayersForm()
        {
            InitializeComponent();
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

        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (teamDropdown.SelectedItem == null)
            {
                return;
            }
            else if (teamDropdown.SelectedItem == "Atlanta Hawks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 1";
            }
            else if (teamDropdown.SelectedItem == "Boston Celtics")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 2";
            }
            else if (teamDropdown.SelectedItem == "Brooklyn Nets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 3";
            }
            else if (teamDropdown.SelectedItem == "Charlotte Hornets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 4";
            }
            else if (teamDropdown.SelectedItem == "Chicago Bulls")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 5";
            }
            else if (teamDropdown.SelectedItem == "Cleveland Cavaliers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 6";
            }
            else if (teamDropdown.SelectedItem == "Dallas Mavericks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 7";
            }
            else if (teamDropdown.SelectedItem == "Denver Nuggets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 8";
            }
            else if (teamDropdown.SelectedItem == "Detroit Pistons")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 9";
            }
            else if (teamDropdown.SelectedItem == "Golden State Warriors")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 10";
            }
            else if (teamDropdown.SelectedItem == "Houston Rockets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 11";
            }
            else if (teamDropdown.SelectedItem == "Indiana Pacers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 12";
            }
            else if (teamDropdown.SelectedItem == "Los Angeles Clippers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 13";
            }
            else if (teamDropdown.SelectedItem == "Los Angeles Lakers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 14";
            }
            else if (teamDropdown.SelectedItem == "Memphis Grizzlies")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 15";
            }
            else if (teamDropdown.SelectedItem == "Miami Heat")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 16";
            }
            else if (teamDropdown.SelectedItem == "Milwaukee Bucks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 17";
            }
            else if (teamDropdown.SelectedItem == "Minnesota Timberwolves")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 18";
            }
            else if (teamDropdown.SelectedItem == "New Orleans Pelicans")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 19";
            }
            else if (teamDropdown.SelectedItem == "New York Knicks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 20";
            }
            else if (teamDropdown.SelectedItem == "Oklahoma City Thunder")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 21";
            }
            else if (teamDropdown.SelectedItem == "Orlando Magic")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 22";
            }
            else if (teamDropdown.SelectedItem == "Philadelphia 76ers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 23";
            }
            else if (teamDropdown.SelectedItem == "Phoenix Suns")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 24";
            }
            else if (teamDropdown.SelectedItem == "Portland Trail Blazers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 25";
            }
            else if (teamDropdown.SelectedItem == "Sacremento Kings")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 26";
            }
            else if (teamDropdown.SelectedItem == "San Antonio Spurs")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 27";
            }
            else if (teamDropdown.SelectedItem == "Toronto Raptors")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 28";
            }
            else if (teamDropdown.SelectedItem == "Utah Jazz")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 29";
            }
            else if (teamDropdown.SelectedItem == "Washington Wizards")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 30";
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
    }
}
