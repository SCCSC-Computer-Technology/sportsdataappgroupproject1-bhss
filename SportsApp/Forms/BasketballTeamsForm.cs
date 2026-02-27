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

        }
    }
}
