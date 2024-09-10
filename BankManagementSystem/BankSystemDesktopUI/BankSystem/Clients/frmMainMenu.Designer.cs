namespace BankSystem.Clients
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.pnlOptions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnManageUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowClients = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTitle = new Guna.UI2.WinForms.Guna2Button();
            this.labUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMainMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pnlOptions.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.pnlOptions.Controls.Add(this.btnLogout);
            this.pnlOptions.Controls.Add(this.btnManageUser);
            this.pnlOptions.Controls.Add(this.btnDeleteClient);
            this.pnlOptions.Controls.Add(this.btnFindClient);
            this.pnlOptions.Controls.Add(this.btnShowClients);
            this.pnlOptions.Controls.Add(this.btnUpdateClient);
            this.pnlOptions.Controls.Add(this.btnAddNew);
            this.pnlOptions.Controls.Add(this.guna2Panel1);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(230, 712);
            this.pnlOptions.TabIndex = 0;
            // 
            // btnManageUser
            // 
            this.btnManageUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnManageUser.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.Color.White;
            this.btnManageUser.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUser.Image")));
            this.btnManageUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnManageUser.Location = new System.Drawing.Point(0, 424);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(230, 51);
            this.btnManageUser.TabIndex = 7;
            this.btnManageUser.Tag = "Manage Users";
            this.btnManageUser.Text = " Manage Users";
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnDeleteClient.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.Image")));
            this.btnDeleteClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteClient.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDeleteClient.Location = new System.Drawing.Point(0, 373);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(230, 51);
            this.btnDeleteClient.TabIndex = 6;
            this.btnDeleteClient.Tag = "Delete Client";
            this.btnDeleteClient.Text = " Delete Client";
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnFindClient.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.ForeColor = System.Drawing.Color.White;
            this.btnFindClient.Image = ((System.Drawing.Image)(resources.GetObject("btnFindClient.Image")));
            this.btnFindClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindClient.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFindClient.Location = new System.Drawing.Point(0, 322);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(230, 51);
            this.btnFindClient.TabIndex = 5;
            this.btnFindClient.Tag = "Find Client";
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnShowClients
            // 
            this.btnShowClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowClients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnShowClients.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowClients.ForeColor = System.Drawing.Color.White;
            this.btnShowClients.Image = ((System.Drawing.Image)(resources.GetObject("btnShowClients.Image")));
            this.btnShowClients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowClients.ImageSize = new System.Drawing.Size(40, 40);
            this.btnShowClients.Location = new System.Drawing.Point(0, 271);
            this.btnShowClients.Name = "btnShowClients";
            this.btnShowClients.Size = new System.Drawing.Size(230, 51);
            this.btnShowClients.TabIndex = 4;
            this.btnShowClients.Text = " Show Clients ";
            this.btnShowClients.Click += new System.EventHandler(this.btnShowClients_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnUpdateClient.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClient.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateClient.Image")));
            this.btnUpdateClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateClient.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUpdateClient.Location = new System.Drawing.Point(0, 220);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(230, 51);
            this.btnUpdateClient.TabIndex = 3;
            this.btnUpdateClient.Text = "   Update Client";
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnAddNew.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNew.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNew.Location = new System.Drawing.Point(0, 169);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(230, 51);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Tag = "";
            this.btnAddNew.Text = "Add Client";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(230, 169);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 68);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(114, 98);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.guna2Panel2.Controls.Add(this.btnTitle);
            this.guna2Panel2.Controls.Add(this.labUserName);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(230, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(978, 84);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnTitle
            // 
            this.btnTitle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTitle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTitle.FillColor = System.Drawing.Color.Transparent;
            this.btnTitle.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.White;
            this.btnTitle.Image = ((System.Drawing.Image)(resources.GetObject("btnTitle.Image")));
            this.btnTitle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTitle.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTitle.Location = new System.Drawing.Point(3, 36);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(180, 45);
            this.btnTitle.TabIndex = 2;
            this.btnTitle.Text = "Home";
            this.btnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labUserName
            // 
            this.labUserName.BackColor = System.Drawing.Color.Transparent;
            this.labUserName.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labUserName.Location = new System.Drawing.Point(827, 38);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(129, 29);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = "guna2HtmlLabel2";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(770, 38);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(51, 29);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "User :";
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(230, 84);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(978, 628);
            this.panelMainMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnLogout.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(0, 475);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(230, 51);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Tag = "Logout";
            this.btnLogout.Text = "Logout ";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 712);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.pnlOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.pnlOptions.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlOptions;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2Button btnUpdateClient;
        private Guna.UI2.WinForms.Guna2Button btnDeleteClient;
        private Guna.UI2.WinForms.Guna2Button btnFindClient;
        private Guna.UI2.WinForms.Guna2Button btnShowClients;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labUserName;
        private Guna.UI2.WinForms.Guna2Button btnTitle;
        private Guna.UI2.WinForms.Guna2Panel panelMainMenu;
        private Guna.UI2.WinForms.Guna2Button btnManageUser;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}