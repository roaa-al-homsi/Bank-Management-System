using BankSystemBusiness;
using System;
using System.Windows.Forms;

namespace BankSystem.Transaction
{
    public partial class frmWithdraw : Form
    {
        private string _AccountNumber;
        private Client _client;
        private double _Amount;
        public frmWithdraw(string AccountNumber)
        {
            InitializeComponent();
            _AccountNumber = AccountNumber;
            _client = Client.Find(AccountNumber);
            if (_client != null)
            {
                txtAccountNumber.Text = _AccountNumber;
                txtSalary.Text = _client.Salary.ToString();
            }
        }

        private void _BackDefaultForm()
        {
            txtAccountNumber.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtAmount.Text = string.Empty;
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            _Amount = Convert.ToDouble(txtAmount.Text);
            if (_Amount > _client.Salary)
            {
                MessageBox.Show("You cannot withdraw this amount from this account", "attention", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (_client.Withdraw(_Amount))
            {
                MessageBox.Show("Withdraw Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _BackDefaultForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _BackDefaultForm();
        }
    }
}
