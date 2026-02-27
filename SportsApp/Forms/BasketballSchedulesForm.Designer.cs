namespace sportsApp.Forms
{
    partial class BasketballSchedulesForm
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
            this.nBAScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nBAScheduleTableAdapter = new sportsApp.SportInfoDataSetTableAdapters.NBAScheduleTableAdapter();
            this.tableAdapterManager = new sportsApp.SportInfoDataSetTableAdapters.TableAdapterManager();
            this.nBAScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortByDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sportInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBAScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBAScheduleDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basketball Schedules";
            // 
            // sportInfoDataSet
            // 
            this.sportInfoDataSet.DataSetName = "SportInfoDataSet";
            this.sportInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBAScheduleBindingSource
            // 
            this.nBAScheduleBindingSource.DataMember = "NBASchedule";
            this.nBAScheduleBindingSource.DataSource = this.sportInfoDataSet;
            // 
            // nBAScheduleTableAdapter
            // 
            this.nBAScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NBAScheduleTableAdapter = this.nBAScheduleTableAdapter;
            this.tableAdapterManager.NBATeamsTableAdapter = null;
            this.tableAdapterManager.NFLTeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sportsApp.SportInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // nBAScheduleDataGridView
            // 
            this.nBAScheduleDataGridView.AllowUserToResizeColumns = false;
            this.nBAScheduleDataGridView.AllowUserToResizeRows = false;
            this.nBAScheduleDataGridView.AutoGenerateColumns = false;
            this.nBAScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.nBAScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nBAScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.nBAScheduleDataGridView.DataSource = this.nBAScheduleBindingSource;
            this.nBAScheduleDataGridView.Location = new System.Drawing.Point(0, 180);
            this.nBAScheduleDataGridView.MultiSelect = false;
            this.nBAScheduleDataGridView.Name = "nBAScheduleDataGridView";
            this.nBAScheduleDataGridView.ReadOnly = true;
            this.nBAScheduleDataGridView.RowHeadersVisible = false;
            this.nBAScheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nBAScheduleDataGridView.Size = new System.Drawing.Size(604, 311);
            this.nBAScheduleDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 56;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 83;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VisitorTeam";
            this.dataGridViewTextBoxColumn3.HeaderText = "VisitorTeam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 94;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VisitorPoints";
            this.dataGridViewTextBoxColumn4.HeaderText = "VisitorPoints";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 98;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HomeTeam";
            this.dataGridViewTextBoxColumn5.HeaderText = "HomeTeam";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 94;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HomePoints";
            this.dataGridViewTextBoxColumn6.HeaderText = "HomePoints";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 98;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Arena";
            this.dataGridViewTextBoxColumn7.HeaderText = "Arena";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchTextbox);
            this.groupBox2.Location = new System.Drawing.Point(392, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 58);
            this.groupBox2.TabIndex = 6;
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
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By";
            // 
            // sortByDropdown
            // 
            this.sortByDropdown.FormattingEnabled = true;
            this.sortByDropdown.Items.AddRange(new object[] {
            "Date",
            "Start Time",
            "Visitor",
            "Visitor Points",
            "Home Team",
            "Home Points",
            "Arena"});
            this.sortByDropdown.Location = new System.Drawing.Point(40, 22);
            this.sortByDropdown.Name = "sortByDropdown";
            this.sortByDropdown.Size = new System.Drawing.Size(121, 23);
            this.sortByDropdown.TabIndex = 3;
            this.sortByDropdown.SelectedIndexChanged += new System.EventHandler(this.sortByDropdown_SelectedIndexChanged);
            // 
            // BasketballSchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nBAScheduleDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BasketballSchedulesForm";
            this.Text = "BasketballSchedulesForm";
            this.Load += new System.EventHandler(this.BasketballSchedulesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBAScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBAScheduleDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SportInfoDataSet sportInfoDataSet;
        private System.Windows.Forms.BindingSource nBAScheduleBindingSource;
        private SportInfoDataSetTableAdapters.NBAScheduleTableAdapter nBAScheduleTableAdapter;
        private SportInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nBAScheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sortByDropdown;
    }
}