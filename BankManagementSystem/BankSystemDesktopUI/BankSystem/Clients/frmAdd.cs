using BankSystemBusiness;
using System.Linq;
using System.Windows.Forms;

namespace BankSystem.Clients
{
    public partial class frmAdd : Form
    {

        public frmAdd()
        {
            InitializeComponent();
        }

        private Client _CreateClientAndFillIt()
        {
            Client client = new Client();
            client.FirstName = txtFirstName.Text;
            client.LastName = txtLastName.Text;
            client.Email = txtEmail.Text;
            client.PhoneNumber = txtPhone.Text;
            client.AccountNumber = txtAccountNumber.Text;
            client.BirthDate = guna2DateTimePicker1.Value;
            client.Salary = double.Parse(txtSalary.Text);
            client.PinCode = txtPinCode.Text;

            if (picboxClient.ImageLocation != null)
            {
                client.ImagePath = picboxClient.ImageLocation;
            }
            else
            {
                client.ImagePath = null;
            }
            return client;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            Client client = _CreateClientAndFillIt();
            if (client.Save())
            {
                MessageBox.Show("Add Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                picboxClient.Load(selectedFilePath);
                picboxClient.ImageLocation = selectedFilePath;
            }
        }

        private void frmAdd_Load(object sender, System.EventArgs e)
        {

        }

        private void txtBoxLetters_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBoxNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] allowedChars = { '@', '.', '-', '_', '+' };
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !allowedChars.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
