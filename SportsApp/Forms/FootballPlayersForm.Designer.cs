namespace sportsApp.Forms
{
    partial class FootballPlayersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teamDropdown = new System.Windows.Forms.ComboBox();
            this.nfl_PlayersCurrentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nfl_PlayersCurrentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportInfoDataSet = new sportsApp.SportInfoDataSet();
            this.nfl_PlayersCurrentTableAdapter = new sportsApp.SportInfoDataSetTableAdapters.nfl_PlayersCurrentTableAdapter();
            this.tableAdapterManager = new sportsApp.SportInfoDataSetTableAdapters.TableAdapterManager();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nfl_PlayersCurrentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nfl_PlayersCurrentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportInfoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Football Players";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchTextbox);
            this.groupBox2.Location = new System.Drawing.Point(392, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 58);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(45, 24);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(100, 23);
            this.searchTextbox.TabIndex = 0;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teamDropdown);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 58);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Team";
            // 
            // teamDropdown
            // 
            this.teamDropdown.FormattingEnabled = true;
            this.teamDropdown.Items.AddRange(new object[] {
            "Arizona Cardinals",
            "Atlanta Falcons",
            "Baltimore Ravens",
            "Buffalo Bills",
            "Carolina Panthers",
            "Chicago Bears",
            "Cincinnati Bengals",
            "Cleveland Browns",
            "Dallas Cowboys",
            "Denver Broncos",
            "Detroit Lions",
            "Green Bay Packers",
            "Houston Texans",
            "Indianapolis Colts",
            "Jacksonville Jaguars",
            "Kansas City Chiefs",
            "Las Vegas Raiders",
            "Los Angeles Chargers",
            "Los Angeles Rams",
            "Miami Dolphins",
            "Minnesota Vikings",
            "New England Patriots",
            "New Orleans Saints",
            "New York Giants",
            "New York Jets",
            "Philadelphia Eagles",
            "Pittsburgh Steelers",
            "San Francisco 49ers",
            "Seattle Seahawks",
            "Tampa Bay Buccaneers",
            "Tennessee Titans",
            "Washington Commanders "});
            this.teamDropdown.Location = new System.Drawing.Point(40, 22);
            this.teamDropdown.Name = "teamDropdown";
            this.teamDropdown.Size = new System.Drawing.Size(121, 23);
            this.teamDropdown.TabIndex = 3;
            this.teamDropdown.SelectedIndexChanged += new System.EventHandler(this.teamDropdown_SelectedIndexChanged);
            // 
            // nfl_PlayersCurrentDataGridView
            // 
            this.nfl_PlayersCurrentDataGridView.AllowUserToResizeColumns = false;
            this.nfl_PlayersCurrentDataGridView.AllowUserToResizeRows = false;
            this.nfl_PlayersCurrentDataGridView.AutoGenerateColumns = false;
            this.nfl_PlayersCurrentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.nfl_PlayersCurrentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nfl_PlayersCurrentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn4});
            this.nfl_PlayersCurrentDataGridView.DataSource = this.nfl_PlayersCurrentBindingSource;
            this.nfl_PlayersCurrentDataGridView.Location = new System.Drawing.Point(0, 180);
            this.nfl_PlayersCurrentDataGridView.Name = "nfl_PlayersCurrentDataGridView";
            this.nfl_PlayersCurrentDataGridView.ReadOnly = true;
            this.nfl_PlayersCurrentDataGridView.RowHeadersVisible = false;
            this.nfl_PlayersCurrentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nfl_PlayersCurrentDataGridView.Size = new System.Drawing.Size(604, 311);
            this.nfl_PlayersCurrentDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Player";
            this.dataGridViewTextBoxColumn1.HeaderText = "Player";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 64;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn2.HeaderText = "Position";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Height";
            this.dataGridViewTextBoxColumn5.HeaderText = "Height";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 68;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn6.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "College";
            this.dataGridViewTextBoxColumn7.HeaderText = "College";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 72;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "YearsPlayed";
            this.dataGridViewTextBoxColumn8.HeaderText = "YearsPlayed";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 94;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 94;
            // 
            // nfl_PlayersCurrentBindingSource
            // 
            this.nfl_PlayersCurrentBindingSource.DataMember = "nfl_PlayersCurrent";
            this.nfl_PlayersCurrentBindingSource.DataSource = this.sportInfoDataSet;
            // 
            // sportInfoDataSet
            // 
            this.sportInfoDataSet.DataSetName = "SportInfoDataSet";
            this.sportInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nfl_PlayersCurrentTableAdapter
            // 
            this.nfl_PlayersCurrentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.nbaCurrentPlayersTableAdapter = null;
            this.tableAdapterManager.NBAScheduleTableAdapter = null;
            this.tableAdapterManager.NBATeamsTableAdapter = null;
            this.tableAdapterManager.nfl_PlayersCurrentTableAdapter = this.nfl_PlayersCurrentTableAdapter;
            this.tableAdapterManager.nflScheduleTableAdapter = null;
            this.tableAdapterManager.NFLTeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sportsApp.SportInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // FootballPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 491);
            this.Controls.Add(this.nfl_PlayersCurrentDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FootballPlayersForm";
            this.Text = "FootballPlayersForm";
            this.Load += new System.EventHandler(this.FootballPlayersForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nfl_PlayersCurrentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nfl_PlayersCurrentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportInfoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox teamDropdown;
        private SportInfoDataSet sportInfoDataSet;
        private System.Windows.Forms.BindingSource nfl_PlayersCurrentBindingSource;
        private SportInfoDataSetTableAdapters.nfl_PlayersCurrentTableAdapter nfl_PlayersCurrentTableAdapter;
        private SportInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nfl_PlayersCurrentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}