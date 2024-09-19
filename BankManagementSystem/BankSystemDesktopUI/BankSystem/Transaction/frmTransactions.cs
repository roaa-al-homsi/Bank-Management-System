using BankSystem.Clients;
using BankSystemBusiness;
using System;
using System.Windows.Forms;

namespace BankSystem.Transaction
{
    public partial class frmTransactions : Form
    {
        private frmMainMenu _frmMainMenu;
        public frmTransactions(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            _frmMainMenu = frmMainMenu;
        }
        private void _RefreshData()
        {
            dgvTransaction.DataSource = Client.Transaction();
        }
        private double _TotalSalary()
        {
            return Client.TotalSalaries();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            _RefreshData();
            labTotalSalary.Text = _TotalSalary().ToString();
        }

        private void cmsDeposit_Click(object sender, EventArgs e)
        {
            string AccountNumber = (string)dgvTransaction.CurrentRow.Cells[1].Value;
            _frmMainMenu.OpenChildFormAsync(new frmDeposit(AccountNumber));
        }

        private void cmsWithdraw_Click(object sender, EventArgs e)
        {
            string AccountNumber = (string)dgvTransaction.CurrentRow.Cells[1].Value;
            _frmMainMenu.OpenChildFormAsync(new frmWithdraw(AccountNumber));
        }

        private void cmsTransfer_Click(object sender, EventArgs e)
        {
            string AccountNumber = (string)dgvTransaction.CurrentRow.Cells[1].Value;
            _frmMainMenu.OpenChildFormAsync(new frmTransfer(AccountNumber));
        }
    }
}
