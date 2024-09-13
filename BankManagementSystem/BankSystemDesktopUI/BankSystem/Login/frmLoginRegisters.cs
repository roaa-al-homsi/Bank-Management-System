using BankSystemBusiness;
using System;
using System.Windows.Forms;

namespace BankSystem.Login
{
    public partial class frmLoginRegisters : Form
    {

        public frmLoginRegisters()
        {
            InitializeComponent();
        }
        private void _RefreshData()
        {
            dgvAllLogins.DataSource = User.ShowLogins();
        }
        private void frmLoginRegisters_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }



    }
}
