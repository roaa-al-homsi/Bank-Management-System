using BankSystem.Clients;
using BankSystemBusiness;
using System.Windows.Forms;
using SystemGlobalVariables;

namespace BankSystem.Login
{
    public partial class frmLogin : Form
    {
        private byte _CounterFailedLogin = 0;
        private short _CounterTick = 60;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, System.EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            GlobalVariables.CurrentUser = User.Find(txtUserName.Text, txtPassword.Text);
            if (GlobalVariables.CurrentUser != null)
            {
                this.Hide();
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();

            }
            else
            {
                _CounterFailedLogin++;
                labCheckLogin.Visible = true;
                if (_CounterFailedLogin == 3)
                {
                    txtPassword.Enabled = false;
                    txtUserName.Enabled = false;
                    labCheckLogin.Text = $"System Lock, Wait a few seconds to log in again";
                    _CounterFailedLogin = 0;
                    timer1.Enabled = true;
                    labTimer.Visible = true;
                }
                else
                { labCheckLogin.Text = $"Invalid username or password, You have {3 - _CounterFailedLogin} tries to login"; }
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            labTimer.Text = "00:" + _CounterTick.ToString();
            _CounterTick--;
            if (_CounterTick == 0)
            {
                timer1.Enabled = false;
                txtPassword.Enabled = true;
                txtUserName.Enabled = true;
                labTimer.Visible = false;
                labCheckLogin.Visible = false;
                _CounterTick = 60;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}

