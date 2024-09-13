namespace BankSystem.Login
{
    partial class frmLoginRegisters
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
            this.dgvAllLogins = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLogins)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllLogins
            // 
            this.dgvAllLogins.AllowUserToAddRows = false;
            this.dgvAllLogins.AllowUserToDeleteRows = false;
            this.dgvAllLogins.AllowUserToOrderColumns = true;
            this.dgvAllLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllLogins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllLogins.Location = new System.Drawing.Point(0, 0);
            this.dgvAllLogins.Name = "dgvAllLogins";
            this.dgvAllLogins.ReadOnly = true;
            this.dgvAllLogins.RowHeadersWidth = 51;
            this.dgvAllLogins.RowTemplate.Height = 24;
            this.dgvAllLogins.Size = new System.Drawing.Size(978, 628);
            this.dgvAllLogins.TabIndex = 0;
            // 
            // frmLoginRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(978, 628);
            this.Controls.Add(this.dgvAllLogins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginRegisters";
            this.Text = "frmLoginRegisters";
            this.Load += new System.EventHandler(this.frmLoginRegisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLogins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllLogins;
    }
}