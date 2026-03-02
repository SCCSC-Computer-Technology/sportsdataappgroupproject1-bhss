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
    public partial class BasketballStandingsForm : Form
    {
        public BasketballStandingsForm()
        {
            InitializeComponent();
            sortByDropdown.SelectedItem = "Wins";
        }

        private void nBATeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nBATeamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportInfoDataSet);

        }

        private void BasketballStandingsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportInfoDataSet.NBATeams' table. You can move, or remove it, as needed.
            this.nBATeamsTableAdapter.Fill(this.sportInfoDataSet.NBATeams);

        }

        // sort method
        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByDropdown.SelectedItem == null)
            {
                return;
            }
            else if (sortByDropdown.SelectedItem == "Wins")
            {
                nBATeamsBindingSource.Sort = "Wins DESC";
            }
            else if (sortByDropdown.SelectedItem == "Losses")
            {
                nBATeamsBindingSource.Sort = "Losses DESC";
            }
        }

        // search method
        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                nBATeamsBindingSource.RemoveFilter();
                return;
            }

            searchText = searchText.Replace("'", "''");

            string filter =
                $"[TeamName] LIKE '%{searchText}%' OR " +
                $"Convert([Wins], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([Losses], 'System.String') LIKE '%{searchText}%' OR " +
                $"[Conference] LIKE '%{searchText}%'";

            nBATeamsBindingSource.Filter = filter;
        }
    }
}
