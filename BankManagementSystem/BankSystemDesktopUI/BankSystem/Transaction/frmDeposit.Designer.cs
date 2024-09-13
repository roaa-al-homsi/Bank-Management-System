namespace BankSystem.Transaction
{
    partial class frmDeposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.labAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.labSalary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Animated = true;
            this.txtAccountNumber.AutoRoundedCorners = true;
            this.txtAccountNumber.BorderRadius = 17;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.DefaultText = "";
            this.txtAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.txtAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Location = new System.Drawing.Point(504, 55);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.PlaceholderText = "";
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.Size = new System.Drawing.Size(210, 37);
            this.txtAccountNumber.TabIndex = 36;
            // 
            // labAccount
            // 
            this.labAccount.AutoSize = false;
            this.labAccount.BackColor = System.Drawing.Color.Transparent;
            this.labAccount.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.labAccount.Location = new System.Drawing.Point(205, 55);
            this.labAccount.Name = "labAccount";
            this.labAccount.Size = new System.Drawing.Size(206, 32);
            this.labAccount.TabIndex = 35;
            this.labAccount.Text = "Account Number";
            // 
            // txtSalary
            // 
            this.txtSalary.Animated = true;
            this.txtSalary.AutoRoundedCorners = true;
            this.txtSalary.BorderRadius = 17;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Location = new System.Drawing.Point(504, 120);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderText = "";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(210, 37);
            this.txtSalary.TabIndex = 38;
            // 
            // labSalary
            // 
            this.labSalary.AutoSize = false;
            this.labSalary.BackColor = System.Drawing.Color.Transparent;
            this.labSalary.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.labSalary.Location = new System.Drawing.Point(249, 120);
            this.labSalary.Name = "labSalary";
            this.labSalary.Size = new System.Drawing.Size(115, 36);
            this.labSalary.TabIndex = 37;
            this.labSalary.Text = "Salary";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BorderRadius = 21;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnSearch.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(298, 449);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 45);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Deposit";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Animated = true;
            this.txtAmount.AutoRoundedCorners = true;
            this.txtAmount.BorderRadius = 17;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(504, 314);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(210, 37);
            this.txtAmount.TabIndex = 42;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(202, 314);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(250, 37);
            this.guna2HtmlLabel9.TabIndex = 41;
            this.guna2HtmlLabel9.Text = " Enter deposit amount  ";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 21;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnCancel.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(525, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 45);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(960, 581);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.labSalary);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.labAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeposit";
            this.Text = "frmDeposit";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel labAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private Guna.UI2.WinForms.Guna2HtmlLabel labSalary;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}