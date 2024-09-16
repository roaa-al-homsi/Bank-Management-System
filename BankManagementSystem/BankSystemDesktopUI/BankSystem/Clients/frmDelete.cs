using BankSystemBusiness;
using System;
using System.Windows.Forms;

namespace BankSystem.Clients
{
    public partial class frmDelete : Form
    {

        private Client _client;
        public frmDelete()
        {
            InitializeComponent();

        }

        private void _BackDefaultControls()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPinCode.Text = string.Empty;
            txtSalary.Text = string.Empty;
            guna2DateTimePicker1.Value = DateTime.Now;

            txtSearchAccountNum.Text = string.Empty;

            picboxClient.Image = Properties.Resources.icons8_user_64;

        }
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            _client = Client.Find(txtSearchAccountNum.Text);
            if (_client != null)
            {
                txtFirstName.Text = _client.FirstName;
                txtLastName.Text = _client.LastName;
                txtEmail.Text = _client.Email;
                txtPhone.Text = _client.PhoneNumber;
                txtPinCode.Text = _client.PinCode;
                txtSalary.Text = _client.Salary.ToString();
                guna2DateTimePicker1.Value = _client.BirthDate;

                if (_client.ImagePath != null)
                {
                    picboxClient.ImageLocation = _client.ImagePath;
                    // picboxClient.Load(_client.ImagePath);
                }
            }
            else
            {
                MessageBox.Show("There isn't client with this account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchAccountNum.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this client?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Client.Delete(txtSearchAccountNum.Text);
                _BackDefaultControls();
            }
            else
            {
                _BackDefaultControls();
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

    }
}
