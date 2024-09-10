using BankSystem.Users;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SystemGlobalVariables;

namespace BankSystem.Clients
{
    public partial class frmMainMenu : Form
    {
        private Guna2Button _currentButton;
        private Form _activeForm;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void _ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Guna2Button)btnSender)
                {
                    _DisableMenuButton();
                    _currentButton = (Guna2Button)btnSender;
                    _currentButton.BackColor = Color.White;
                    _currentButton.ForeColor = Color.FromArgb(53, 41, 123);
                    _currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void _DisableMenuButton()
        {
            Guna2Button gunaButton = new Guna2Button();

            foreach (Control previousBtn in panelMainMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2Button))
                {
                    gunaButton = (Guna2Button)previousBtn;

                    previousBtn.BackColor = Color.FromArgb(53, 41, 123);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void _OpenChildFormAsync(Form childForm, object btnSender)
        {
            _activeForm?.Close();

            _ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(childForm);
            panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
            {
                btnTitle.Text = childForm.Tag.ToString();

            }
            else
            {
                btnTitle.Text = childForm.Text;
            }
        }

        public void _OpenChildFormAsync(Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(childForm);
            panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
            {
                btnTitle.Text = childForm.Tag.ToString();

            }
            else
            {
                btnTitle.Text = childForm.Text;
            }
        }

        private void btnShowClients_Click(object sender, EventArgs e)
        {
            btnTitle.Image = btnShowClients.Image;
            _OpenChildFormAsync(new frmShowClients(this), sender);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnTitle.Image = btnAddNew.Image;
            _OpenChildFormAsync(new frmAdd(), sender);
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            btnTitle.Image = btnFindClient.Image;
            _OpenChildFormAsync(new frmFind(), sender);
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            btnTitle.Image = btnUpdateClient.Image;
            _OpenChildFormAsync(new frmUpdate(), sender);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            btnTitle.Image = btnDeleteClient.Image;
            _OpenChildFormAsync(new frmDelete(), sender);
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            btnTitle.Image = btnManageUser.Image;
            _OpenChildFormAsync(new frmMainManageUsers(this), sender);
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            labUserName.Text = GlobalVariables.CurrentUser.UserName;
        }
    }
}

