namespace sportsApp
{
    partial class NavControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.sportSelectionPanel = new System.Windows.Forms.Panel();
            this.footballButton = new System.Windows.Forms.RadioButton();
            this.basketballButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.teamsButton = new System.Windows.Forms.Button();
            this.scoresButton = new System.Windows.Forms.Button();
            this.playersButton = new System.Windows.Forms.Button();
            this.navigationPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.sportSelectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(119)))));
            this.navigationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.navigationPanel.Controls.Add(this.headerPanel);
            this.navigationPanel.Controls.Add(this.scheduleButton);
            this.navigationPanel.Controls.Add(this.statsButton);
            this.navigationPanel.Controls.Add(this.closeButton);
            this.navigationPanel.Controls.Add(this.logOutButton);
            this.navigationPanel.Controls.Add(this.playersButton);
            this.navigationPanel.Controls.Add(this.teamsButton);
            this.navigationPanel.Controls.Add(this.scoresButton);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(216, 490);
            this.navigationPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.sportSelectionPanel);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(216, 100);
            this.headerPanel.TabIndex = 1;
            // 
            // sportSelectionPanel
            // 
            this.sportSelectionPanel.Controls.Add(this.footballButton);
            this.sportSelectionPanel.Controls.Add(this.basketballButton);
            this.sportSelectionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sportSelectionPanel.Location = new System.Drawing.Point(0, 62);
            this.sportSelectionPanel.Name = "sportSelectionPanel";
            this.sportSelectionPanel.Size = new System.Drawing.Size(216, 38);
            this.sportSelectionPanel.TabIndex = 1;
            // 
            // footballButton
            // 
            this.footballButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.footballButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(119)))));
            this.footballButton.FlatAppearance.BorderSize = 0;
            this.footballButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.footballButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.footballButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.footballButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.footballButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footballButton.ForeColor = System.Drawing.Color.White;
            this.footballButton.Location = new System.Drawing.Point(108, 0);
            this.footballButton.Name = "footballButton";
            this.footballButton.Size = new System.Drawing.Size(108, 38);
            this.footballButton.TabIndex = 0;
            this.footballButton.TabStop = true;
            this.footballButton.Text = "Football";
            this.footballButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.footballButton.UseVisualStyleBackColor = false;
            // 
            // basketballButton
            // 
            this.basketballButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.basketballButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(119)))));
            this.basketballButton.FlatAppearance.BorderSize = 0;
            this.basketballButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.basketballButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.basketballButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.basketballButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basketballButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basketballButton.ForeColor = System.Drawing.Color.White;
            this.basketballButton.Location = new System.Drawing.Point(0, 0);
            this.basketballButton.Name = "basketballButton";
            this.basketballButton.Size = new System.Drawing.Size(108, 38);
            this.basketballButton.TabIndex = 0;
            this.basketballButton.TabStop = true;
            this.basketballButton.Text = "Basketball";
            this.basketballButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.basketballButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sports Stats";
            // 
            // scheduleButton
            // 
            this.scheduleButton.BackColor = System.Drawing.Color.Transparent;
            this.scheduleButton.FlatAppearance.BorderSize = 0;
            this.scheduleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.scheduleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.scheduleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleButton.ForeColor = System.Drawing.Color.White;
            this.scheduleButton.Location = new System.Drawing.Point(0, 271);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(216, 55);
            this.scheduleButton.TabIndex = 5;
            this.scheduleButton.Text = "Schedules";
            this.scheduleButton.UseVisualStyleBackColor = false;
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.Transparent;
            this.statsButton.FlatAppearance.BorderSize = 0;
            this.statsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.statsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.statsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsButton.ForeColor = System.Drawing.Color.White;
            this.statsButton.Location = new System.Drawing.Point(0, 216);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(216, 55);
            this.statsButton.TabIndex = 4;
            this.statsButton.Text = "Stats";
            this.statsButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(0, 454);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(216, 36);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Transparent;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.logOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.logOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(0, 412);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(216, 36);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // teamsButton
            // 
            this.teamsButton.BackColor = System.Drawing.Color.Transparent;
            this.teamsButton.FlatAppearance.BorderSize = 0;
            this.teamsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.teamsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.teamsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.teamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsButton.ForeColor = System.Drawing.Color.White;
            this.teamsButton.Location = new System.Drawing.Point(0, 106);
            this.teamsButton.Name = "teamsButton";
            this.teamsButton.Size = new System.Drawing.Size(216, 55);
            this.teamsButton.TabIndex = 3;
            this.teamsButton.Text = "Teams";
            this.teamsButton.UseVisualStyleBackColor = false;
            // 
            // scoresButton
            // 
            this.scoresButton.BackColor = System.Drawing.Color.Transparent;
            this.scoresButton.FlatAppearance.BorderSize = 0;
            this.scoresButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.scoresButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.scoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.scoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoresButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresButton.ForeColor = System.Drawing.Color.White;
            this.scoresButton.Location = new System.Drawing.Point(0, 332);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(216, 55);
            this.scoresButton.TabIndex = 2;
            this.scoresButton.Text = "Scores";
            this.scoresButton.UseVisualStyleBackColor = false;
            // 
            // playersButton
            // 
            this.playersButton.BackColor = System.Drawing.Color.Transparent;
            this.playersButton.FlatAppearance.BorderSize = 0;
            this.playersButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.playersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.playersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.playersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersButton.ForeColor = System.Drawing.Color.White;
            this.playersButton.Location = new System.Drawing.Point(0, 161);
            this.playersButton.Name = "playersButton";
            this.playersButton.Size = new System.Drawing.Size(216, 55);
            this.playersButton.TabIndex = 3;
            this.playersButton.Text = "Players";
            this.playersButton.UseVisualStyleBackColor = false;
            // 
            // NavControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.navigationPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NavControl";
            this.Size = new System.Drawing.Size(216, 490);
            this.navigationPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.sportSelectionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sportSelectionPanel;
        private System.Windows.Forms.RadioButton footballButton;
        private System.Windows.Forms.RadioButton basketballButton;
        private System.Windows.Forms.Button scoresButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Button teamsButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button playersButton;
    }
}
