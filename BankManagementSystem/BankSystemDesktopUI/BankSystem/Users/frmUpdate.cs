using BankSystemBusiness;
using System;
using System.Windows.Forms;

namespace BankSystem.Users
{
    public partial class frmUpdate : Form
    {

        private string _UserName;
        private User _User;

        public frmUpdate(string UserName)
        {
            InitializeComponent();
            _UserName = UserName;
            _User = User.Find(_UserName);

            if (_User != null)
            {
                labUserNameInfo.Text = _UserName;
                txtFirstName.Text = _User.FirstName;
                txtLastName.Text = _User.LastName;
                txtEmail.Text = _User.Email;
                txtPhone.Text = _User.PhoneNumber;
                txtPassword.Text = _User.Password;
                txtPermission.Text = _User.Permission.ToString();
                guna2DateTimePicker1.Value = _User.BirthDate;
                if (!string.IsNullOrWhiteSpace(_User.ImagePath))
                {
                    linkLabRemove.Enabled = true;
                    picboxUser.Load(_User.ImagePath);
                    picboxUser.ImageLocation = _User.ImagePath;
                }
                else
                {
                    linkLabRemove.Enabled = false;
                    picboxUser.ImageLocation = null;
                }
            }
        }
        private void _BackDefaultControls()
        {
            labUserNameInfo.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPermission.Text = string.Empty;
            txtPassword.Text = string.Empty;
            guna2DateTimePicker1.Value = DateTime.Now;
            picboxUser.Image = Properties.Resources.icons8_user_64;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _User.FirstName = txtFirstName.Text;
            _User.LastName = txtLastName.Text;
            _User.Email = txtEmail.Text;
            _User.PhoneNumber = txtPhone.Text;
            _User.Permission = int.Parse(txtPermission.Text);
            _User.BirthDate = guna2DateTimePicker1.Value;
            _User.Password = txtPassword.Text;
            _User.ImagePath = (picboxUser != null) ? picboxUser.ImageLocation : null;

            _User.Save();
            _BackDefaultControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _BackDefaultControls();
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

                picboxUser.Load(selectedFilePath);
                picboxUser.ImageLocation = selectedFilePath;
            }
        }

        private void linkLabRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picboxUser.ImageLocation = null;
            _User.ImagePath = null;
            _User.Save();
        }



    }
}
