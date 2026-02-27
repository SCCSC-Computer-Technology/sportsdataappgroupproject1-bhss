namespace sportsApp.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFavFootballTeam = new System.Windows.Forms.Label();
            this.lblFavBasketballTeam = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lstBoxFootballTeams = new System.Windows.Forms.ListBox();
            this.lstBoxBasketballTeams = new System.Windows.Forms.ListBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewPass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(55, 30);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(232, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Sports Stats Registration";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(51, 78);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 17);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(51, 114);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(70, 17);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(87, 150);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(57, 186);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblFavFootballTeam
            // 
            this.lblFavFootballTeam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavFootballTeam.Location = new System.Drawing.Point(8, 246);
            this.lblFavFootballTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFavFootballTeam.Name = "lblFavFootballTeam";
            this.lblFavFootballTeam.Size = new System.Drawing.Size(159, 20);
            this.lblFavFootballTeam.TabIndex = 5;
            this.lblFavFootballTeam.Text = "Favorite Football Team";
            this.lblFavFootballTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFavBasketballTeam
            // 
            this.lblFavBasketballTeam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavBasketballTeam.Location = new System.Drawing.Point(175, 242);
            this.lblFavBasketballTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFavBasketballTeam.Name = "lblFavBasketballTeam";
            this.lblFavBasketballTeam.Size = new System.Drawing.Size(159, 20);
            this.lblFavBasketballTeam.TabIndex = 6;
            this.lblFavBasketballTeam.Text = "Favorite Basketball Team";
            this.lblFavBasketballTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(318, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 103;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(146, 78);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(152, 23);
            this.txtBoxFirstName.TabIndex = 104;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(146, 114);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(152, 23);
            this.txtBoxLastName.TabIndex = 105;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(146, 150);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(152, 23);
            this.txtBoxEmail.TabIndex = 106;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(146, 186);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(152, 23);
            this.txtBoxPassword.TabIndex = 107;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // lstBoxFootballTeams
            // 
            this.lstBoxFootballTeams.FormattingEnabled = true;
            this.lstBoxFootballTeams.ItemHeight = 15;
            this.lstBoxFootballTeams.Location = new System.Drawing.Point(8, 266);
            this.lstBoxFootballTeams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstBoxFootballTeams.Name = "lstBoxFootballTeams";
            this.lstBoxFootballTeams.Size = new System.Drawing.Size(159, 154);
            this.lstBoxFootballTeams.TabIndex = 108;
            // 
            // lstBoxBasketballTeams
            // 
            this.lstBoxBasketballTeams.FormattingEnabled = true;
            this.lstBoxBasketballTeams.ItemHeight = 15;
            this.lstBoxBasketballTeams.Location = new System.Drawing.Point(175, 266);
            this.lstBoxBasketballTeams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstBoxBasketballTeams.Name = "lstBoxBasketballTeams";
            this.lstBoxBasketballTeams.Size = new System.Drawing.Size(159, 154);
            this.lstBoxBasketballTeams.TabIndex = 109;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(112, 446);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(119, 33);
            this.btnRegister.TabIndex = 110;
            this.btnRegister.Text = "&Register Account";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewPass);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.lstBoxBasketballTeams);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.lstBoxFootballTeams);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.txtBoxPassword);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.txtBoxEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtBoxLastName);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtBoxFirstName);
            this.panel1.Controls.Add(this.lblFavFootballTeam);
            this.panel1.Controls.Add(this.lblFavBasketballTeam);
            this.panel1.Location = new System.Drawing.Point(475, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 491);
            this.panel1.TabIndex = 112;
            // 
            // btnViewPass
            // 
            this.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewPass.Location = new System.Drawing.Point(305, 186);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(26, 23);
            this.btnViewPass.TabIndex = 111;
            this.btnViewPass.Text = "*";
            this.btnViewPass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewPass.UseVisualStyleBackColor = true;
            this.btnViewPass.Click += new System.EventHandler(this.btnViewPass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(818, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFavFootballTeam;
        private System.Windows.Forms.Label lblFavBasketballTeam;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.ListBox lstBoxFootballTeams;
        private System.Windows.Forms.ListBox lstBoxBasketballTeams;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewPass;
    }
}