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

//Atlanta Hawks
//Boston Celtics
//Brooklyn Nets
//Charlotte Hornets
//Chicago Bulls
//Cleveland Cavaliers
//Dallas Mavericks
//Denver Nuggets
//Detroit Pistons
//Golden State Warriors
//Houston Rockets
//Indiana Pacers
//Los Angeles Clippers
//Los Angeles Lakers
//Memphis Grizzlies
//Miami Heat
//Milwaukee Bucks
//Minnesota Timberwolves
//New Orleans Pelicans
//New York Knicks
//Oklahoma City Thunder
//Orlando Magic
//Philadelphia 76ers
//Phoenix Suns
//Portland Trail Blazers
//Sacramento Kings
//San Antonio Spurs
//Toronto Raptors
//Utah Jazz
//Washington Wizards

            if (sortByDropdown.SelectedItem == null)
            {
                return;
            }
            else if (sortByDropdown.SelectedItem == "Atlanta Hawks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 1";
            }
            else if (sortByDropdown.SelectedItem == "Boston Celtics")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 2";
            }
            else if (sortByDropdown.SelectedItem == "Brooklyn Nets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 3";
            }
            else if (sortByDropdown.SelectedItem == "Charlotte Hornets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 4";
            }
            else if (sortByDropdown.SelectedItem == "Chicago Bulls")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 5";
            }
            else if (sortByDropdown.SelectedItem == "Cleveland Cavaliers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 6";
            }
            else if (sortByDropdown.SelectedItem == "Dallas Mavericks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 7";
            }
            else if (sortByDropdown.SelectedItem == "Denver Nuggets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 8";
            }
            else if (sortByDropdown.SelectedItem == "Detroit Pistons")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 9";
            }
            else if (sortByDropdown.SelectedItem == "Golden State Warriors")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 10";
            }
            else if (sortByDropdown.SelectedItem == "Houston Rockets")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 11";
            }
            else if (sortByDropdown.SelectedItem == "Indiana Pacers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 12";
            }
            else if (sortByDropdown.SelectedItem == "Los Angeles Clippers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 13";
            }
            else if (sortByDropdown.SelectedItem == "Los Angeles Lakers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 14";
            }
            else if (sortByDropdown.SelectedItem == "Memphis Grizzlies")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 15";
            }
            else if (sortByDropdown.SelectedItem == "Miami Heat")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 16";
            }
            else if (sortByDropdown.SelectedItem == "Milwaukee Bucks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 17";
            }
            else if (sortByDropdown.SelectedItem == "Minnesota Timberwolves")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 18";
            }
            else if (sortByDropdown.SelectedItem == "New Orleans Pelicans")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 19";
            }
            else if (sortByDropdown.SelectedItem == "New York Knicks")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 20";
            }
            else if (sortByDropdown.SelectedItem == "Oklahoma City Thunder")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 21";
            }
            else if (sortByDropdown.SelectedItem == "Orlando Magic")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 22";
            }
            else if (sortByDropdown.SelectedItem == "Philadelphia 76ers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 23";
            }
            else if (sortByDropdown.SelectedItem == "Phoenix Suns")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 24";
            }
            else if (sortByDropdown.SelectedItem == "Portland Trail Blazers")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 25";
            }
            else if (sortByDropdown.SelectedItem == "Sacremento Kings")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 26";
            }
            else if (sortByDropdown.SelectedItem == "San Antonio Spurs")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 27";
            }
            else if (sortByDropdown.SelectedItem == "Toronto Raptors")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 28";
            }
            else if (sortByDropdown.SelectedItem == "Utah Jazz")
            {
                nbaCurrentPlayersBindingSource.Filter = "TeamID = 29";
            }
            else if (sortByDropdown.SelectedItem == "Washington Wizards")
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
                $"Convert([Date], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([StartTime], 'System.String') LIKE '%{searchText}%' OR " +
                $"[VisitorTeam] LIKE '%{searchText}%' OR " +
                $"Convert([VisitorPoints], 'System.String') LIKE '%{searchText}%' OR " +
                $"[HomeTeam] LIKE '%{searchText}%' OR " +
                $"Convert([HomePoints], 'System.String') LIKE '%{searchText}%' OR " +
                $"[Arena] LIKE '%{searchText}%'";

            nbaCurrentPlayersBindingSource.Filter = filter;
        }



    }
}
