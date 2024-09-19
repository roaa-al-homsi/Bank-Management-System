using BankSystem.Login;
using BankSystem.Transaction;
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
                if (_currentButton != null)
                {
                    _currentButton.BackColor = Color.FromArgb(53, 41, 123);
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

                _currentButton = (Guna2Button)btnSender;
                _currentButton.BackColor = Color.White;
                _currentButton.ForeColor = Color.FromArgb(53, 41, 123);
                _currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        public void OpenChildFormAsync(Form childForm, object btnSender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

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

        public void OpenChildFormAsync(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
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

        private void _MessageAccessDenied()
        {
            MessageBox.Show("Access Denied!! You don't have permission to use this feature." +
                     "Please contact your administrator for assistance..", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void btnShowClients_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.CheckAccessPermission(GlobalVariables.enMainMenuPermission.ShowClients))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnShowClients.Image;
            OpenChildFormAsync(new frmShowClients(this), sender);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.CheckAccessPermission(GlobalVariables.enMainMenuPermission.AddClient))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnAddNew.Image;
            OpenChildFormAsync(new frmAdd(), sender);
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.CheckAccessPermission(GlobalVariables.enMainMenuPermission.FindClient))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnFindClient.Image;
            OpenChildFormAsync(new frmFind(), sender);
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.CheckAccessPermission(GlobalVariables.enMainMenuPermission.UpdateClient))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnUpdateClient.Image;
            OpenChildFormAsync(new frmUpdate(), sender);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.CheckAccessPermission(GlobalVariables.enMainMenuPermission.DeleteClient))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnDeleteClient.Image;
            OpenChildFormAsync(new frmDelete(), sender);
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.CheckAccessPermission(GlobalVariables.enMainMenuPermission.ManageUsers))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnManageUser.Image;
            OpenChildFormAsync(new frmMainManageUsers(this), sender);
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            labUserName.Text = GlobalVariables.CurrentUser.UserName;
            GlobalVariables.DateLoginToSystem = DateTime.Now;
            //Timer for Date time .
            labDateTime.Text = GlobalVariables.DateLoginToSystem.ToString("dddd/MMMM/yyyy");
            labAnotherDateFormat.Text = DateTime.Now.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            GlobalVariables.DateLogoutFromSystem = DateTime.Now;
            GlobalVariables.CurrentUser.RegisterLogins(GlobalVariables.DateLoginToSystem, GlobalVariables.DateLogoutFromSystem, GlobalVariables.CurrentUser.Id);
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

        }

        private void btnLoginRegisters_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.CheckAccessPermission(GlobalVariables.enMainMenuPermission.LoginRegister))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnLoginRegisters.Image;
            OpenChildFormAsync(new frmLoginRegisters(), sender);

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.CheckAccessPermission(GlobalVariables.enMainMenuPermission.Transaction))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnTransaction.Image;
            OpenChildFormAsync(new frmTransactions(this), sender);
        }

        private void btnShowTransfer_Click(object sender, EventArgs e)
        {
            if (!GlobalVariables.CheckAccessPermission(GlobalVariables.enMainMenuPermission.Transfers))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnShowTransfer.Image;
            OpenChildFormAsync(new frmShowTransfers(), sender);
        }
    }
}

