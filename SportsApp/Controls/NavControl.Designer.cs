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
            this.soccerButton = new System.Windows.Forms.RadioButton();
            this.hockeyButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.scoresButton = new System.Windows.Forms.Button();
            this.navigationPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.sportSelectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.DimGray;
            this.navigationPanel.Controls.Add(this.headerPanel);
            this.navigationPanel.Controls.Add(this.scheduleButton);
            this.navigationPanel.Controls.Add(this.button2);
            this.navigationPanel.Controls.Add(this.closeButton);
            this.navigationPanel.Controls.Add(this.button1);
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
            this.sportSelectionPanel.Controls.Add(this.soccerButton);
            this.sportSelectionPanel.Controls.Add(this.hockeyButton);
            this.sportSelectionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sportSelectionPanel.Location = new System.Drawing.Point(0, 62);
            this.sportSelectionPanel.Name = "sportSelectionPanel";
            this.sportSelectionPanel.Size = new System.Drawing.Size(216, 38);
            this.sportSelectionPanel.TabIndex = 1;
            // 
            // soccerButton
            // 
            this.soccerButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.soccerButton.AutoSize = true;
            this.soccerButton.BackColor = System.Drawing.Color.DimGray;
            this.soccerButton.FlatAppearance.BorderSize = 0;
            this.soccerButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.soccerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.soccerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.soccerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soccerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soccerButton.ForeColor = System.Drawing.Color.White;
            this.soccerButton.Location = new System.Drawing.Point(108, 5);
            this.soccerButton.Name = "soccerButton";
            this.soccerButton.Size = new System.Drawing.Size(57, 27);
            this.soccerButton.TabIndex = 0;
            this.soccerButton.TabStop = true;
            this.soccerButton.Text = "Soccer";
            this.soccerButton.UseVisualStyleBackColor = false;
            // 
            // hockeyButton
            // 
            this.hockeyButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.hockeyButton.AutoSize = true;
            this.hockeyButton.BackColor = System.Drawing.Color.DimGray;
            this.hockeyButton.FlatAppearance.BorderSize = 0;
            this.hockeyButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.hockeyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.hockeyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.hockeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hockeyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hockeyButton.ForeColor = System.Drawing.Color.White;
            this.hockeyButton.Location = new System.Drawing.Point(49, 5);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(63, 27);
            this.hockeyButton.TabIndex = 0;
            this.hockeyButton.TabStop = true;
            this.hockeyButton.Text = "Hockey";
            this.hockeyButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 11);
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
            this.scheduleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.scheduleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.scheduleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleButton.ForeColor = System.Drawing.Color.White;
            this.scheduleButton.Location = new System.Drawing.Point(0, 153);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(216, 36);
            this.scheduleButton.TabIndex = 5;
            this.scheduleButton.Text = "Schedules";
            this.scheduleButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stats";
            this.button2.UseVisualStyleBackColor = false;
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
            this.closeButton.ForeColor = System.Drawing.Color.LightCoral;
            this.closeButton.Location = new System.Drawing.Point(0, 454);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(216, 36);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Teams";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // scoresButton
            // 
            this.scoresButton.BackColor = System.Drawing.Color.Transparent;
            this.scoresButton.FlatAppearance.BorderSize = 0;
            this.scoresButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.scoresButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.scoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.scoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoresButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresButton.ForeColor = System.Drawing.Color.White;
            this.scoresButton.Location = new System.Drawing.Point(0, 111);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(216, 36);
            this.scoresButton.TabIndex = 2;
            this.scoresButton.Text = "Scores";
            this.scoresButton.UseVisualStyleBackColor = false;
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
            this.sportSelectionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sportSelectionPanel;
        private System.Windows.Forms.RadioButton soccerButton;
        private System.Windows.Forms.RadioButton hockeyButton;
        private System.Windows.Forms.Button scoresButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeButton;
    }
}
