using sportsApp.Classes;
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
    public partial class BasketballStatsForm : Form
    {
        public BasketballStatsForm()
        {
            InitializeComponent();
            sortByDropdown.SelectedItem = nbaSeasonStatsBindingSource.Sort == "Wins";
            sortByDropdown.SelectedItem = "Wins";
        }

        private void nbaSeasonStatsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nbaSeasonStatsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportInfoDataSet);

        }

        private void BasketballStatsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportInfoDataSet.nbaSeasonStats' table. You can move, or remove it, as needed.
            this.nbaSeasonStatsTableAdapter.Fill(this.sportInfoDataSet.nbaSeasonStats);

        }

        // sorting method based on dropdown selection
        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByDropdown.SelectedItem == null)
            {
                return;
            }
            else if (sortByDropdown.SelectedItem == "Team")
            {
                nbaSeasonStatsBindingSource.Sort = "Team";
            }
            else if (sortByDropdown.SelectedItem == "Games Played")
            {
                nbaSeasonStatsBindingSource.Sort = "Games_Played DESC";
            }
            else if (sortByDropdown.SelectedItem == "Wins")
            {
                nbaSeasonStatsBindingSource.Sort = "Wins DESC";
            }
            else if (sortByDropdown.SelectedItem == "Losses")
            {
                nbaSeasonStatsBindingSource.Sort = "Losses DESC";
            }
            else if (sortByDropdown.SelectedItem == "Assists")
            {
                nbaSeasonStatsBindingSource.Sort = "Assists DESC";
            }
            else if (sortByDropdown.SelectedItem == "Rebounds")
            {
                nbaSeasonStatsBindingSource.Sort = "Total_Rebounds DESC";
            }
        }

        // search method based on character changes in textbox
        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                nbaSeasonStatsBindingSource.RemoveFilter();
                return;
            }

            searchText = searchText.Replace("'", "''");

            string filter =
                $"[Team] LIKE '%{searchText}%' OR " +
                $"Convert([Games_Played], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Wins], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Losses], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Winning_Percentage], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Points_Per_Game], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Field_Goals_Made], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Field_Goals_Attempted], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Three_Point_Field_Goals_Made], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Three_Point_Field_Goals_Attempted], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Free_Throws_Made], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Total_Rebounds], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Assists], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Steals], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Blocks], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Plus_Minus], 'System.String') LIKE '%{searchText}%'";

            nbaSeasonStatsBindingSource.Filter = filter;
        }
    }
}
