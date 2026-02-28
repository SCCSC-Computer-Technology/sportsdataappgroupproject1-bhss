namespace sportsApp.Forms
{
    partial class FootballSchedulesForm
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
            this.sortByDropdown = new System.Windows.Forms.ComboBox();
            this.sportInfoDataSet = new sportsApp.SportInfoDataSet();
            this.nflScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nflScheduleTableAdapter = new sportsApp.SportInfoDataSetTableAdapters.nflScheduleTableAdapter();
            this.tableAdapterManager = new sportsApp.SportInfoDataSetTableAdapters.TableAdapterManager();
            this.nflScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nflScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nflScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Football Schedules";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchTextbox);
            this.groupBox2.Location = new System.Drawing.Point(392, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 58);
            this.groupBox2.TabIndex = 8;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 58);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By";
            // 
            // sortByDropdown
            // 
            this.sortByDropdown.FormattingEnabled = true;
            this.sortByDropdown.Items.AddRange(new object[] {
            "Date",
            "Away Team",
            "Home Team",
            "Kickoff"});
            this.sortByDropdown.Location = new System.Drawing.Point(40, 22);
            this.sortByDropdown.Name = "sortByDropdown";
            this.sortByDropdown.Size = new System.Drawing.Size(121, 23);
            this.sortByDropdown.TabIndex = 3;
            this.sortByDropdown.SelectedIndexChanged += new System.EventHandler(this.sortByDropdown_SelectedIndexChanged);
            // 
            // sportInfoDataSet
            // 
            this.sportInfoDataSet.DataSetName = "SportInfoDataSet";
            this.sportInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nflScheduleBindingSource
            // 
            this.nflScheduleBindingSource.DataMember = "nflSchedule";
            this.nflScheduleBindingSource.DataSource = this.sportInfoDataSet;
            // 
            // nflScheduleTableAdapter
            // 
            this.nflScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.nbaCurrentPlayersTableAdapter = null;
            this.tableAdapterManager.NBAScheduleTableAdapter = null;
            this.tableAdapterManager.NBATeamsTableAdapter = null;
            this.tableAdapterManager.nflScheduleTableAdapter = this.nflScheduleTableAdapter;
            this.tableAdapterManager.NFLTeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sportsApp.SportInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // nflScheduleDataGridView
            // 
            this.nflScheduleDataGridView.AllowUserToResizeColumns = false;
            this.nflScheduleDataGridView.AllowUserToResizeRows = false;
            this.nflScheduleDataGridView.AutoGenerateColumns = false;
            this.nflScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nflScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nflScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.nflScheduleDataGridView.DataSource = this.nflScheduleBindingSource;
            this.nflScheduleDataGridView.Location = new System.Drawing.Point(0, 180);
            this.nflScheduleDataGridView.Name = "nflScheduleDataGridView";
            this.nflScheduleDataGridView.ReadOnly = true;
            this.nflScheduleDataGridView.RowHeadersVisible = false;
            this.nflScheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nflScheduleDataGridView.Size = new System.Drawing.Size(604, 311);
            this.nflScheduleDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "away_team";
            this.dataGridViewTextBoxColumn3.HeaderText = "Away Team";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "home_team";
            this.dataGridViewTextBoxColumn4.HeaderText = "Home Team";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "kickoff_et";
            this.dataGridViewTextBoxColumn6.HeaderText = "Kickoff (ET)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // FootballSchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 491);
            this.Controls.Add(this.nflScheduleDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FootballSchedulesForm";
            this.Text = "FootballSchedulesForm";
            this.Load += new System.EventHandler(this.FootballSchedulesForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sportInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nflScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nflScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sortByDropdown;
        private SportInfoDataSet sportInfoDataSet;
        private System.Windows.Forms.BindingSource nflScheduleBindingSource;
        private SportInfoDataSetTableAdapters.nflScheduleTableAdapter nflScheduleTableAdapter;
        private SportInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nflScheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}