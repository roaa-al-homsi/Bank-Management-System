using BankSystemBusiness;
using System;
using System.Windows.Forms;

namespace BankSystem.Users
{
    public partial class frmAddUser : Form
    {

        public frmAddUser()
        {
            InitializeComponent();
        }
        private void _BackDefaultControls()
        {
            txtUserName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPermission.Text = string.Empty;
            txtPassword.Text = string.Empty;
            guna2DateTimePicker1.Value = DateTime.Now;



            // picboxClientUdate

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User _User = new User();
            _User.UserName = txtUserName.Text;
            _User.FirstName = txtFirstName.Text;
            _User.LastName = txtLastName.Text;
            _User.Email = txtEmail.Text;
            _User.PhoneNumber = txtPhone.Text;
            _User.Permission = int.Parse(txtPermission.Text);
            _User.BirthDate = guna2DateTimePicker1.Value;
            _User.Password = txtPassword.Text;

            if (picboxUser != null)
            {
                _User.ImagePath = picboxUser.ImageLocation;
            }
            else
            {
                _User.ImagePath = null;
            }
            _User.Save();
            _BackDefaultControls();
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

                picboxUser.Load(selectedFilePath);
                picboxUser.ImageLocation = selectedFilePath;
            }

        }
    }
}
