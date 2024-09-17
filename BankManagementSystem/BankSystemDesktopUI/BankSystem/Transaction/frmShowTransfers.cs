using BankSystemBusiness;
using System;
using System.Windows.Forms;


namespace BankSystem.Transaction
{
    public partial class frmShowTransfers : Form
    {
        public frmShowTransfers()
        {
            InitializeComponent();
        }
        private void _RefreshData()
        {
            dgvShowTransfers.DataSource = Client.Transfers();
        }

        private void frmShowTransfers_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

    }
}

