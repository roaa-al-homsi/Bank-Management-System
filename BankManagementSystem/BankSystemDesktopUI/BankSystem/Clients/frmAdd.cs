using BankSystemBusiness;
using System.Windows.Forms;

namespace BankSystem.Clients
{
    public partial class frmAdd : Form
    {

        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
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
            client.Save();
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






    }
}
