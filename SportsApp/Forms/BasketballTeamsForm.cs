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
    public partial class BasketballTeamsForm : Form
    {
        public BasketballTeamsForm()
        {
            InitializeComponent();
        }

        private void nBATeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nBATeamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportInfoDataSet);

        }

        private void BasketballTeamsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportInfoDataSet.NBATeams' table. You can move, or remove it, as needed.
            this.nBATeamsTableAdapter.Fill(this.sportInfoDataSet.NBATeams);
            sortByDropdown.SelectedIndex = 0;

        }

        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByDropdown.SelectedItem == null)
            {
                return;
            }
            else if (sortByDropdown.SelectedItem == "Team Name")
            {
                nBATeamsBindingSource.Sort = "TeamName";
            }
            else if (sortByDropdown.SelectedItem == "Conference")
            {
                nBATeamsBindingSource.Sort = "Conference";
            }
            else if (sortByDropdown.SelectedItem == "Wins")
            {
                nBATeamsBindingSource.Sort = "Wins DESC";
            }
            else if (sortByDropdown.SelectedItem == "Losses")
            {
                nBATeamsBindingSource.Sort = "Losses DESC";
            }
            else if (sortByDropdown.SelectedItem == "Arena")
            {
                nBATeamsBindingSource.Sort = "Arena";
            }
        }

        


        private void ApplySearchFilter()
        {
            string searchText = searchTextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                nBATeamsBindingSource.RemoveFilter();
                return;
            }

            // Escape single quotes for RowFilter syntax
            searchText = searchText.Replace("'", "''");

            string filter =
                $"TeamName LIKE '%{searchText}%' OR " +
                $"Conference LIKE '%{searchText}%' OR " +
                $"Arena LIKE '%{searchText}%' OR " +
                $"Convert(Wins, 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert(Losses, 'System.String') LIKE '%{searchText}%'";

            nBATeamsBindingSource.Filter = filter;
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }
    }
}
