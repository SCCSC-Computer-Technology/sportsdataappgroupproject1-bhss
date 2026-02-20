namespace sportsApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.navControl1 = new sportsApp.NavControl();
            this.loginControl1 = new sportsApp.LoginControl();
            this.dashboardControl1 = new sportsApp.NavControl();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.loginControl2 = new sportsApp.LoginControl();
            this.SuspendLayout();
            // 
            // navControl1
            // 
            this.navControl1.BackColor = System.Drawing.Color.White;
            this.navControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navControl1.Location = new System.Drawing.Point(0, 0);
            this.navControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.navControl1.Name = "navControl1";
            this.navControl1.Size = new System.Drawing.Size(216, 491);
            this.navControl1.TabIndex = 1;
            // 
            // loginControl1
            // 
            this.loginControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginControl1.Location = new System.Drawing.Point(0, 0);
            this.loginControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(820, 490);
            this.loginControl1.TabIndex = 0;
            // 
            // dashboardControl1
            // 
            this.dashboardControl1.BackColor = System.Drawing.Color.White;
            this.dashboardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardControl1.Location = new System.Drawing.Point(0, 0);
            this.dashboardControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dashboardControl1.Name = "dashboardControl1";
            this.dashboardControl1.Size = new System.Drawing.Size(820, 490);
            this.dashboardControl1.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(216, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(604, 490);
            this.contentPanel.TabIndex = 2;
            // 
            // loginControl2
            // 
            this.loginControl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginControl2.Location = new System.Drawing.Point(0, 0);
            this.loginControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginControl2.Name = "loginControl2";
            this.loginControl2.Size = new System.Drawing.Size(818, 492);
            this.loginControl2.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 491);
            this.Controls.Add(this.loginControl2);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.navControl1);
            this.Controls.Add(this.loginControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Stats";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private LoginControl loginControl1;
        private NavControl dashboardControl1;
        private NavControl navControl1;
        private System.Windows.Forms.Panel contentPanel;
        private LoginControl loginControl2;
    }
}

