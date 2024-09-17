using BankSystemBusiness;
using System;
using System.Windows.Forms;

namespace BankSystem.Clients
{
    public partial class frmUpdate : Form
    {
        private Client _client;
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void _FindClient(string AccountNumber)
        {
            _client = Client.Find(AccountNumber);
            if (_client != null)
            {
                txtFirstName.Text = _client.FirstName;
                txtLastName.Text = _client.LastName;
                txtEmail.Text = _client.Email;
                txtPhone.Text = _client.PhoneNumber;
                txtPinCode.Text = _client.PinCode;
                txtSalary.Text = _client.Salary.ToString();
                guna2DateTimePicker1.Value = _client.BirthDate;

                if (string.IsNullOrWhiteSpace(_client.ImagePath))
                {
                    linkLabRemove.Enabled = false;
                    picboxClientUpdate.ImageLocation = null;
                }
                else
                {
                    linkLabRemove.Enabled = true;
                    picboxClientUpdate.Load(_client.ImagePath);
                    picboxClientUpdate.ImageLocation = _client.ImagePath;
                }
                //linkLabRemove.Enabled = (_SourceClient.ImagePath != null);

            }
            else
            {
                MessageBox.Show("There isn't client with this account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchAccountNum.Text = "";
            }
        }
        public frmUpdate(string AccountNumber)
        {
            InitializeComponent();

            txtSearchAccountNum.Text = AccountNumber;
            _FindClient(txtSearchAccountNum.Text);
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

            picboxClientUpdate.Image = Properties.Resources.icons8_user_64;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _FindClient(txtSearchAccountNum.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _client.FirstName = txtFirstName.Text;
            _client.LastName = txtLastName.Text;
            _client.Email = txtEmail.Text;
            _client.PhoneNumber = txtPhone.Text;
            _client.Salary = double.Parse(txtSalary.Text);
            _client.BirthDate = guna2DateTimePicker1.Value;
            _client.PinCode = txtPinCode.Text;

            _client.ImagePath = (picboxClientUpdate != null) ? picboxClientUpdate.ImageLocation : null;

            if (_client.Save())
            {
                MessageBox.Show("Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _BackDefaultControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _BackDefaultControls();
            return;
        }

        private void LinkLabSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                picboxClientUpdate.Load(selectedFilePath);
                picboxClientUpdate.ImageLocation = selectedFilePath;
            }
        }

        private void linkLabRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picboxClientUpdate.ImageLocation = null;
            _client.ImagePath = null;
            _client.Save();
        }

        private void txtBoxLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only char
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;// Prevent invalid characters
            }
        }
        private void txtBoxNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent invalid numbers
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
