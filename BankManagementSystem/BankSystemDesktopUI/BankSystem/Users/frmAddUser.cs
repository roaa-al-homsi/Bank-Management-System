using BankSystemBusiness;
using System;
using System.Windows.Forms;
using SystemGlobalVariables;

namespace BankSystem.Users
{
    public partial class frmAddUser : Form
    {

        private int _PermissionOnlyUser = 0;
        public frmAddUser()
        {
            InitializeComponent();
            checkedListBox1.ItemCheck += CheckedListBox1_ItemCheck;

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
            txtUserName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            _UncheckAll();
            txtPassword.Text = string.Empty;
            guna2DateTimePicker1.Value = DateTime.Now;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User _User = new User();
            _User.UserName = txtUserName.Text;
            _User.FirstName = txtFirstName.Text;
            _User.LastName = txtLastName.Text;
            _User.Email = txtEmail.Text;
            _User.PhoneNumber = txtPhone.Text;
            _User.Permission = _PermissionOnlyUser;
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

    }
}
