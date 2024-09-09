using BankSystem.Clients;
using BankSystemBusiness;
using System;
using System.Windows.Forms;

namespace BankSystem.Users
{
    public partial class frmMainManageUsers : Form
    {
        public frmMainMenu _frmMainMenu;
        public frmMainManageUsers(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            _frmMainMenu = frmMainMenu;
        }

        private void _RefreshUserData()
        {
            dgvAllUsers.DataSource = User.All();
        }
        private void frmMainManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUserData();
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string UserName = (string)dgvAllUsers.CurrentRow.Cells[1].Value;
            _frmMainMenu._OpenChildFormAsync(new frmUpdate(UserName));

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this user?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                string UserName = (string)dgvAllUsers.CurrentRow.Cells[1].Value;
                User.Delete(UserName);

                _RefreshUserData();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _frmMainMenu._OpenChildFormAsync(new frmAddUser());
        }
    }
}
