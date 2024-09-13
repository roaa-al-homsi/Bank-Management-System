namespace BankSystem.Transaction
{
    partial class frmTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTransaction = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labTotalSalary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cmsDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTransfer = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransaction.ColumnHeadersHeight = 4;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransaction.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransaction.Location = new System.Drawing.Point(0, 0);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.RowHeadersWidth = 51;
            this.dgvTransaction.RowTemplate.Height = 24;
            this.dgvTransaction.Size = new System.Drawing.Size(960, 581);
            this.dgvTransaction.TabIndex = 0;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransaction.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransaction.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvTransaction.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransaction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTransaction.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransaction.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransaction.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransaction.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransaction.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTransaction.ThemeStyle.ReadOnly = true;
            this.dgvTransaction.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransaction.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransaction.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransaction.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTransaction.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTransaction.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransaction.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label
            // 
            this.label.AutoSize = false;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Silver;
            this.label.Location = new System.Drawing.Point(319, 525);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(138, 44);
            this.label.TabIndex = 1;
            this.label.Text = "Total Salary :";
            this.label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labTotalSalary
            // 
            this.labTotalSalary.AutoSize = false;
            this.labTotalSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.labTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labTotalSalary.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalSalary.ForeColor = System.Drawing.Color.Silver;
            this.labTotalSalary.Location = new System.Drawing.Point(483, 525);
            this.labTotalSalary.Name = "labTotalSalary";
            this.labTotalSalary.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.labTotalSalary.Size = new System.Drawing.Size(138, 44);
            this.labTotalSalary.TabIndex = 2;
            this.labTotalSalary.Text = "Total Salary ";
            this.labTotalSalary.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeposit,
            this.cmsWithdraw,
            this.cmsTransfer});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // cmsDeposit
            // 
            this.cmsDeposit.ForeColor = System.Drawing.Color.Silver;
            this.cmsDeposit.Name = "cmsDeposit";
            this.cmsDeposit.Size = new System.Drawing.Size(210, 24);
            this.cmsDeposit.Text = "Deposit";
            this.cmsDeposit.Click += new System.EventHandler(this.cmsDeposit_Click);
            // 
            // cmsWithdraw
            // 
            this.cmsWithdraw.ForeColor = System.Drawing.Color.Silver;
            this.cmsWithdraw.Name = "cmsWithdraw";
            this.cmsWithdraw.Size = new System.Drawing.Size(210, 24);
            this.cmsWithdraw.Text = "Withdraw";
            this.cmsWithdraw.Click += new System.EventHandler(this.cmsWithdraw_Click);
            // 
            // cmsTransfer
            // 
            this.cmsTransfer.ForeColor = System.Drawing.Color.Silver;
            this.cmsTransfer.Name = "cmsTransfer";
            this.cmsTransfer.Size = new System.Drawing.Size(210, 24);
            this.cmsTransfer.Text = "Transfer";
            this.cmsTransfer.Click += new System.EventHandler(this.cmsTransfer_Click);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 581);
            this.Controls.Add(this.labTotalSalary);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dgvTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactions";
            this.Text = "frmTransactioncs";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvTransaction;
        private Guna.UI2.WinForms.Guna2HtmlLabel label;
        private Guna.UI2.WinForms.Guna2HtmlLabel labTotalSalary;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsDeposit;
        private System.Windows.Forms.ToolStripMenuItem cmsWithdraw;
        private System.Windows.Forms.ToolStripMenuItem cmsTransfer;
    }
}