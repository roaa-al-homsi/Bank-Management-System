using BankSystemBusiness;
using System.Windows.Forms;


namespace BankSystem.Clients
{
    public partial class frmShowClients : Form
    {
        private frmMainMenu _frmMainMenu;

        public frmShowClients(frmMainMenu frmMain)
        {
            InitializeComponent();

            _frmMainMenu = frmMain;

        }


        private void _RefreshClientsList()
        {
            dgvAllClients.DataSource = Client.All();
        }

        private void frmShowClients_Load(object sender, System.EventArgs e)
        {
            _RefreshClientsList();
        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            string AccountNumber = (string)dgvAllClients.CurrentRow.Cells[7].Value;
            _frmMainMenu._OpenChildFormAsync(new frmUpdate(AccountNumber));
        }

        private void toolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this client?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                int ClientID = (int)dgvAllClients.CurrentRow.Cells[0].Value;

                if (Client.Delete(ClientID))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _RefreshClientsList();
            }
        }
    }
}
