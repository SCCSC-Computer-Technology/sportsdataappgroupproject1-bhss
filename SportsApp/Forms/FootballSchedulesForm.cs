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
    public partial class FootballSchedulesForm : Form
    {
        public FootballSchedulesForm()
        {
            InitializeComponent();
            comboBoxMonths.Items.Add("September");
            comboBoxMonths.Items.Add("October");
            comboBoxMonths.Items.Add("November");
            comboBoxMonths.Items.Add("December");            
            comboBoxMonths.Items.Add("January");

            sortByDropdown.SelectedItem = "Date";
            comboBoxMonths.SelectedIndex = 0;
        }

        private void nflScheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nflScheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportInfoDataSet);

        }

        private void FootballSchedulesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportInfoDataSet.nflSchedule' table. You can move, or remove it, as needed.
            this.nflScheduleTableAdapter.Fill(this.sportInfoDataSet.nflSchedule);

        }

        private void sortByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByDropdown.SelectedItem == null)
            {
                return;
            }
            else if (sortByDropdown.SelectedItem == "Date")
            {
                nflScheduleBindingSource.Sort = "date";
            }
            else if (sortByDropdown.SelectedItem == "Away Team")
            {
                nflScheduleBindingSource.Sort = "away_team";
            }
            else if (sortByDropdown.SelectedItem == "Home Team")
            {
                nflScheduleBindingSource.Sort = "home_team";
            }
            else if (sortByDropdown.SelectedItem == "Kickoff")
            {
                nflScheduleBindingSource.Sort = "kickoff_et";
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
                nflScheduleBindingSource.RemoveFilter();
                return;
            }

            searchText = searchText.Replace("'", "''");

            string filter =
                $"Convert([Date], 'System.String') LIKE '%{searchText}%' OR " +
                $"Convert([away_team], 'System.String') LIKE '%{searchText}%' OR " +
                $"[home_team] LIKE '%{searchText}%' OR " +
                $"Convert([kickoff_et], 'System.String') LIKE '%{searchText}%'";

            nflScheduleBindingSource.Filter = filter;
        }

        private void comboBoxMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            int monthNumber = 0;

            if (comboBoxMonths.SelectedIndex == 0)
            {
                monthNumber = 1;
                this.nflScheduleTableAdapter.FillByMonth(this.sportInfoDataSet.nflSchedule, monthNumber);
            }
            else if (comboBoxMonths.SelectedIndex == 1)
            {
                monthNumber = 9;
                this.nflScheduleTableAdapter.FillByMonth(this.sportInfoDataSet.nflSchedule, monthNumber);
            }
            else if (comboBoxMonths.SelectedIndex == 2)
            {
                monthNumber = 10;
                this.nflScheduleTableAdapter.FillByMonth(this.sportInfoDataSet.nflSchedule, monthNumber);
            }
            else if (comboBoxMonths.SelectedIndex == 3)
            {
                monthNumber = 11;
                this.nflScheduleTableAdapter.FillByMonth(this.sportInfoDataSet.nflSchedule, monthNumber);
            }
            else if (comboBoxMonths.SelectedIndex == 4)
            {
                monthNumber = 12;
                this.nflScheduleTableAdapter.FillByMonth(this.sportInfoDataSet.nflSchedule, monthNumber);
            }                
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            sortByDropdown.SelectedIndex = -1;
            comboBoxMonths.SelectedIndex = -1;
            searchTextbox.Clear();
            this.nflScheduleTableAdapter.Fill(this.sportInfoDataSet.nflSchedule);
            nflScheduleBindingSource.Sort = "date";
        }
    }
}
