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
    public partial class FootballStatsForm : Form
    {
        public FootballStatsForm()
        {
            InitializeComponent();
            sortByDropdown.SelectedItem = "Team";
        }

        private void nflSeasonStatsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nflSeasonStatsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportInfoDataSet);

        }

        private void FootballStatsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportInfoDataSet.nflSeasonStats' table. You can move, or remove it, as needed.
            this.nflSeasonStatsTableAdapter.Fill(this.sportInfoDataSet.nflSeasonStats);

        }

        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByDropdown.SelectedItem == null)
            {
                return;
            }
            else if (sortByDropdown.SelectedItem.ToString() == "Team")
            {
                nflSeasonStatsBindingSource.Sort = "Team";
            }
            else if (sortByDropdown.SelectedItem.ToString() == "Games Played")
            {
                nflSeasonStatsBindingSource.Sort = "GP DESC";
            }
            else if (sortByDropdown.SelectedItem.ToString() == "Total Yards")
            {
                nflSeasonStatsBindingSource.Sort = "Total_Yards DESC";
            }
            else if (sortByDropdown.SelectedItem.ToString() == "Passing Yards")
            {
                nflSeasonStatsBindingSource.Sort = "Passing_Yards DESC";
            }
            else if (sortByDropdown.SelectedItem.ToString() == "Rushing Yards")
            {
                nflSeasonStatsBindingSource.Sort = "Rushing_Yards DESC";
            }
            else if (sortByDropdown.SelectedItem.ToString() == "Points")
            {
                nflSeasonStatsBindingSource.Sort = "Points DESC";
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
                nflSeasonStatsBindingSource.RemoveFilter();
                return;
            }

            // escape apostrophes for DataView RowFilter
            searchText = searchText.Replace("'", "''");

            string filter =
                $"[Team] LIKE '%{searchText}%' OR " +
                $"Convert([GP], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Total_Yards], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Total_Yards_Per_Game], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Passing_Yards], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Passing_Yards_Per_Game], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Rushing_Yards], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Rushing_Yards_Per_Game], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Points], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Points_Per_Game], 'System.String') LIKE '%{searchText}%'";

            nflSeasonStatsBindingSource.Filter = filter;
        }
    }
}
