using BankSystemBusiness;
using System;
using System.Windows.Forms;

namespace BankSystem.Transaction
{
    public partial class frmDeposit : Form
    {

        private string _AccountNumber;
        private double _Amount;
        private Client _client;

        public frmDeposit(string AccountNumber)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Amount = Convert.ToDouble(txtAmount.Text);
            if (_client.Deposit(_Amount))
            {
                MessageBox.Show("Deposit Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _BackDefaultForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _BackDefaultForm();
        }

    }
}
