using BankSystemBusiness;
using System;
using System.Linq;
using System.Windows.Forms;
using SystemGlobalVariables;
namespace BankSystem.Users
{
    public partial class frmUpdate : Form
    {

        private string _UserName;
        private User _User;
        int _PermissionOnlyUser = 0;
        public frmUpdate(string UserName)
        {
            InitializeComponent();
            checkedListBox1.ItemCheck += CheckedListBox1_ItemCheck;

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
                _GetNamesOptionAllowedFromUserPermission(_User.Permission);
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
        private void _UncheckAll()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
        private void _BackDefaultControls()
        {
            labUserNameInfo.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPassword.Text = string.Empty;
            _UncheckAll();
            guna2DateTimePicker1.Value = DateTime.Now;
            picboxUser.Image = Properties.Resources.icons8_user_64;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _User.FirstName = txtFirstName.Text;
            _User.LastName = txtLastName.Text;
            _User.Email = txtEmail.Text;
            _User.PhoneNumber = txtPhone.Text;
            _User.Permission = _PermissionOnlyUser;
            _User.BirthDate = guna2DateTimePicker1.Value;
            _User.Password = txtPassword.Text;
            _User.ImagePath = (picboxUser != null) ? picboxUser.ImageLocation : null;

            if (_User.Save())
            {
                MessageBox.Show("Add Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the checked list box control
            CheckedListBox checkedListBox = sender as CheckedListBox;
            string item = checkedListBox.Items[e.Index].ToString();

            // Check if the item is being checked or unchecked

            if (e.NewValue == CheckState.Checked && item == "Add Client")
            {
                _PermissionOnlyUser += (int)GlobalVariables.enMainMenuPermission.AddClient;

            }
            else if (e.NewValue == CheckState.Checked && item == "Find Client")
            {
                _PermissionOnlyUser += (int)GlobalVariables.enMainMenuPermission.FindClient;
            }
            else if (e.NewValue == CheckState.Checked && item == "Update Client")
            {
                _PermissionOnlyUser += (int)GlobalVariables.enMainMenuPermission.UpdateClient;

            }
            else if (e.NewValue == CheckState.Checked && item == "Show Clients")
            {
                _PermissionOnlyUser += (int)GlobalVariables.enMainMenuPermission.ShowClients;
            }
            else if (e.NewValue == CheckState.Checked && item == "Delete Client")
            {
                _PermissionOnlyUser += (int)GlobalVariables.enMainMenuPermission.DeleteClient;

            }
            else if (e.NewValue == CheckState.Checked && item == "Manage Users")
            {
                _PermissionOnlyUser += (int)GlobalVariables.enMainMenuPermission.ManageUsers;

            }
            else if (e.NewValue == CheckState.Checked && item == "Login Register")
            {
                _PermissionOnlyUser += (int)GlobalVariables.enMainMenuPermission.LoginRegister;

            }
            else if (e.NewValue == CheckState.Checked && item == "Transaction")
            {
                _PermissionOnlyUser += (int)GlobalVariables.enMainMenuPermission.Transaction;

            }

            else
            {
                _PermissionOnlyUser = 0;
            }
        }

        private void _GetNamesOptionAllowedFromUserPermission(int User_Permission)
        {
            int[] arrPermission = { 1, 2, 4, 8, 16, 32, 64, 128 };
            for (short i = 1; i <= arrPermission.Length; i++)
            {
                if (GlobalVariables.CheckAccessPermission(User_Permission, (GlobalVariables.enMainMenuPermission)arrPermission[i - 1]))
                {
                    checkedListBox1.SetItemChecked(i - 1, true);
                }

            }

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
