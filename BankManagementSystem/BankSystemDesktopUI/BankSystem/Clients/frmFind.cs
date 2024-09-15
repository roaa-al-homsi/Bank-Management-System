using BankSystemBusiness;
using System;
using System.Windows.Forms;
namespace BankSystem.Clients
{
    public partial class frmFind : Form
    {
        public frmFind()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Client client = Client.Find(txtSearchAccountNum.Text);
            if (client != null)
            {
                txtFirstName.Text = client.FirstName;
                txtLastName.Text = client.LastName;
                txtEmail.Text = client.Email;
                txtAccountNumber.Text = client.AccountNumber;
                txtPhone.Text = client.PhoneNumber;
                txtPinCode.Text = client.PinCode;
                txtSalary.Text = client.Salary.ToString();
                guna2DateTimePicker1.Value = client.BirthDate;

                if (client.ImagePath != null)
                {

                    //  picboxClientFind.Load(client.ImagePath);
                    picboxClientFind.ImageLocation = client.ImagePath;

                }
            }
            else
            {
                MessageBox.Show("There isn't client with this account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchAccountNum.Text = "";
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
