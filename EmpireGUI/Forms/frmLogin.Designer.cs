namespace EmpireGUI
{
    partial class frmLogin
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
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtServerAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtServerPort = new MetroFramework.Controls.MetroTextBox();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblSrvPort = new MetroFramework.Controls.MetroLabel();
            this.lblSrvHost = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAPIToken = new MetroFramework.Controls.MetroTextBox();
            this.tglAPI = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(25, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 82);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Black;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(239, 298);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(192, 82);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Black;
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtUsername.Location = new System.Drawing.Point(25, 62);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.Size = new System.Drawing.Size(192, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "checky";
            this.txtUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(239, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(192, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "@YWitb13";
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(25, 123);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerAddress.Size = new System.Drawing.Size(192, 23);
            this.txtServerAddress.TabIndex = 2;
            this.txtServerAddress.Text = "192.168.2.157";
            this.txtServerAddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(239, 123);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerPort.Size = new System.Drawing.Size(192, 23);
            this.txtServerPort.TabIndex = 3;
            this.txtServerPort.Text = "1337";
            this.txtServerPort.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(25, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 19);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            this.lblUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblSrvPort
            // 
            this.lblSrvPort.AutoSize = true;
            this.lblSrvPort.Location = new System.Drawing.Point(239, 101);
            this.lblSrvPort.Name = "lblSrvPort";
            this.lblSrvPort.Size = new System.Drawing.Size(76, 19);
            this.lblSrvPort.TabIndex = 10;
            this.lblSrvPort.Text = "Server Port";
            this.lblSrvPort.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblSrvHost
            // 
            this.lblSrvHost.AutoSize = true;
            this.lblSrvHost.Location = new System.Drawing.Point(25, 101);
            this.lblSrvHost.Name = "lblSrvHost";
            this.lblSrvHost.Size = new System.Drawing.Size(110, 19);
            this.lblSrvHost.TabIndex = 9;
            this.lblSrvHost.Text = "Server Hostname";
            this.lblSrvHost.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(239, 40);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 19);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            this.lblPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(83, 224);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "API Token";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAPIToken
            // 
            this.txtAPIToken.Location = new System.Drawing.Point(155, 220);
            this.txtAPIToken.Name = "txtAPIToken";
            this.txtAPIToken.Size = new System.Drawing.Size(192, 23);
            this.txtAPIToken.TabIndex = 4;
            this.txtAPIToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAPIToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tglAPI
            // 
            this.tglAPI.AutoSize = true;
            this.tglAPI.Location = new System.Drawing.Point(248, 185);
            this.tglAPI.Name = "tglAPI";
            this.tglAPI.Size = new System.Drawing.Size(80, 17);
            this.tglAPI.TabIndex = 12;
            this.tglAPI.Text = "Off";
            this.tglAPI.UseVisualStyleBackColor = true;
            this.tglAPI.CheckedChanged += new System.EventHandler(this.tglAPI_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(68, 183);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(174, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Login with API Token Instead";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(475, 403);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tglAPI);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtAPIToken);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblSrvHost);
            this.Controls.Add(this.lblSrvPort);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.txtServerAddress);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtServerAddress;
        private MetroFramework.Controls.MetroTextBox txtServerPort;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblSrvPort;
        private MetroFramework.Controls.MetroLabel lblSrvHost;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAPIToken;
        private MetroFramework.Controls.MetroToggle tglAPI;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}