namespace sportsApp.Forms
{
    partial class FootballStandingsForm
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
            this.sportInfoDataSet = new sportsApp.SportInfoDataSet();
            this.nFLTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFLTeamsTableAdapter = new sportsApp.SportInfoDataSetTableAdapters.NFLTeamsTableAdapter();
            this.tableAdapterManager = new sportsApp.SportInfoDataSetTableAdapters.TableAdapterManager();
            this.nFLTeamsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortByDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sportInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFLTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFLTeamsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Football Standings";
            // 
            // sportInfoDataSet
            // 
            this.sportInfoDataSet.DataSetName = "SportInfoDataSet";
            this.sportInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nFLTeamsBindingSource
            // 
            this.nFLTeamsBindingSource.DataMember = "NFLTeams";
            this.nFLTeamsBindingSource.DataSource = this.sportInfoDataSet;
            // 
            // nFLTeamsTableAdapter
            // 
            this.nFLTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.nbaCurrentPlayersTableAdapter = null;
            this.tableAdapterManager.NBAScheduleTableAdapter = null;
            this.tableAdapterManager.NBATeamsTableAdapter = null;
            this.tableAdapterManager.nfl_PlayersCurrentTableAdapter = null;
            this.tableAdapterManager.nflScheduleTableAdapter = null;
            this.tableAdapterManager.NFLTeamsTableAdapter = this.nFLTeamsTableAdapter;
            this.tableAdapterManager.UpdateOrder = sportsApp.SportInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // nFLTeamsDataGridView
            // 
            this.nFLTeamsDataGridView.AutoGenerateColumns = false;
            this.nFLTeamsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nFLTeamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nFLTeamsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.nFLTeamsDataGridView.DataSource = this.nFLTeamsBindingSource;
            this.nFLTeamsDataGridView.Location = new System.Drawing.Point(0, 180);
            this.nFLTeamsDataGridView.MultiSelect = false;
            this.nFLTeamsDataGridView.Name = "nFLTeamsDataGridView";
            this.nFLTeamsDataGridView.ReadOnly = true;
            this.nFLTeamsDataGridView.RowHeadersVisible = false;
            this.nFLTeamsDataGridView.Size = new System.Drawing.Size(604, 311);
            this.nFLTeamsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeamName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TeamName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Wins";
            this.dataGridViewTextBoxColumn6.HeaderText = "Wins";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Losses";
            this.dataGridViewTextBoxColumn7.HeaderText = "Losses";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Ties";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ties";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchTextbox);
            this.groupBox2.Location = new System.Drawing.Point(392, 69);
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
            this.groupBox1.Controls.Add(this.sortByDropdown);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 58);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By";
            // 
            // sortByDropdown
            // 
            this.sortByDropdown.FormattingEnabled = true;
            this.sortByDropdown.Items.AddRange(new object[] {
            "Wins",
            "Losses"});
            this.sortByDropdown.Location = new System.Drawing.Point(40, 22);
            this.sortByDropdown.Name = "sortByDropdown";
            this.sortByDropdown.Size = new System.Drawing.Size(121, 23);
            this.sortByDropdown.TabIndex = 3;
            this.sortByDropdown.SelectedIndexChanged += new System.EventHandler(this.sortByDropdown_SelectedIndexChanged);
            // 
            // FootballStandingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nFLTeamsDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FootballStandingsForm";
            this.Text = "FootballScoresForm";
            this.Load += new System.EventHandler(this.FootballStandingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFLTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFLTeamsDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SportInfoDataSet sportInfoDataSet;
        private System.Windows.Forms.BindingSource nFLTeamsBindingSource;
        private SportInfoDataSetTableAdapters.NFLTeamsTableAdapter nFLTeamsTableAdapter;
        private SportInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nFLTeamsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sortByDropdown;
    }
}