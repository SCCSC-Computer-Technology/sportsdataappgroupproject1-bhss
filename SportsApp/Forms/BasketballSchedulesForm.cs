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
    public partial class BasketballSchedulesForm : Form
    {
        public BasketballSchedulesForm()
        {
            InitializeComponent();
        }

        private void nBAScheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nBAScheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportInfoDataSet);

        }

        private void BasketballSchedulesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportInfoDataSet.NBASchedule' table. You can move, or remove it, as needed.
            this.nBAScheduleTableAdapter.Fill(this.sportInfoDataSet.NBASchedule);
            sortByDropdown.SelectedIndex = 0;

        }

        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByDropdown.SelectedItem == null)
            {
                return;
            }
            else if (sortByDropdown.SelectedItem == "Date")
            {
                nBAScheduleBindingSource.Sort = "Date";
            }
            else if (sortByDropdown.SelectedItem == "Start Time")
            {
                nBAScheduleBindingSource.Sort = "StartTime";
            }
            else if (sortByDropdown.SelectedItem == "Visitor")
            {
                nBAScheduleBindingSource.Sort = "VisitorTeam";
            }
            else if (sortByDropdown.SelectedItem == "Visitor Points")
            {
                nBAScheduleBindingSource.Sort = "VisitorPoints DESC";
            }
            else if (sortByDropdown.SelectedItem == "Home Team")
            {
                nBAScheduleBindingSource.Sort = "HomeTeam";
            }
            else if (sortByDropdown.SelectedItem == "Home Points")
            {
                nBAScheduleBindingSource.Sort = "HomePoints DESC";
            }
            else if (sortByDropdown.SelectedItem == "Arena")
            {
                nBAScheduleBindingSource.Sort = "Arena";
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
                nBAScheduleBindingSource.RemoveFilter();
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

            nBAScheduleBindingSource.Filter = filter;
        }
    }
}
