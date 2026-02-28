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
    public partial class FootballStandingsForm : Form
    {
        public FootballStandingsForm()
        {
            InitializeComponent();
        }

        private void nFLTeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nFLTeamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportInfoDataSet);

        }

        private void FootballStandingsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportInfoDataSet.NFLTeams' table. You can move, or remove it, as needed.
            this.nFLTeamsTableAdapter.Fill(this.sportInfoDataSet.NFLTeams);

        }

        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByDropdown.SelectedItem == null)
            {
                return;
            }
            else if (sortByDropdown.SelectedItem == "Wins")
            {
                nFLTeamsBindingSource.Sort = "Wins DESC";
            }
            else if (sortByDropdown.SelectedItem == "Losses")
            {
                nFLTeamsBindingSource.Sort = "Losses DESC";
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
                nFLTeamsBindingSource.RemoveFilter();
                return;
            }

            searchText = searchText.Replace("'", "''");

            string filter =
                $"[TeamName] LIKE '%{searchText}%' OR " +
                $"Convert([Wins], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Losses], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Ties], 'System.String') LIKE '%{searchText}%'";

            nFLTeamsBindingSource.Filter = filter;
        }
    }
}
