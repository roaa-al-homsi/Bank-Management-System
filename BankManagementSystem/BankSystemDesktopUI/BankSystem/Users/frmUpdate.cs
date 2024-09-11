﻿using BankSystemBusiness;
using System;
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

            else
            {
                _PermissionOnlyUser = 0;
            }
        }
        private void _GetNamesOptionAllowedFromUserPermission(int User_Permission)
        {

            int[] arrPermission = { 1, 2, 4, 8, 16, 32 };
            // string[] arrMainMenu = { " [1]List Clients", " [2]Add new clients", " [3]delet clients", " [4]update clients", " [5]find clients", " [6]Transaction", " [7]manage clients" };
            for (short i = 1; i <= 6; i++)
            {
                if (GlobalVariables.CheckAccessPermission(User_Permission, (GlobalVariables.enMainMenuPermission)arrPermission[i - 1]))
                {
                    // تحديد العنصر في الفهرس 2 (العنصر الثالث) كـ Checked
                    checkedListBox1.SetItemChecked(i - 1, true);

                    // العثور على الفهرس بناءً على النص
                    //int index = checkedListBox1.Items.IndexOf("اسم العنصر الذي تريد تحديده");

                    //// التحقق من أن العنصر موجود قبل التحديد
                    //if (index != -1)
                    //{
                    //    checkedListBox1.SetItemChecked(index, true);
                    //}

                }

            }

        }
    }
}
