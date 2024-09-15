using BankSystemBusiness;
using System;
using System.Windows.Forms;
using SystemGlobalVariables;

namespace BankSystem.Transaction
{
    public partial class frmTransfer : Form
    {
        private string _AccountNumber;
        private double _Amount;
        private Client _SourceClient;
        private Client _DestinationClient;
        public frmTransfer(string AccountNumber)
        {
            InitializeComponent();
            _AccountNumber = AccountNumber;
            _SourceClient = Client.Find(AccountNumber);
            if (_SourceClient != null)
            {
                txtAccountNumber.Text = _AccountNumber;
                txtSalary.Text = _SourceClient.Salary.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _DestinationClient = Client.Find(txtToSearchAccount.Text);
            if (_DestinationClient != null)
            {
                txtDesAccountNum.Text = _DestinationClient.AccountNumber;
                txtDesSalary.Text = _DestinationClient.Salary.ToString();

            }
            else
            {
                MessageBox.Show("There is no client with this account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void _BackDefaultForm()
        {
            txtAccountNumber.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtToSearchAccount.Text = string.Empty;
            _Amount = 0;
        }


        private void txtBoxNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only numbers
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;// Prevent invalid characters
            }
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only numbers and char
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTransfer_Click_1(object sender, EventArgs e)
        {
            _Amount = Convert.ToDouble(txtAmount.Text);
            if (_Amount > _SourceClient.Salary)
            {
                MessageBox.Show("You cannot transfer this amount from this account", "attention", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (_SourceClient.Transfer(_Amount, _DestinationClient, GlobalVariables.CurrentUser.Id))
            { MessageBox.Show("Transfer Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); _BackDefaultForm(); }
        }


    }

}