using BankSystem.Clients;
using BankSystemBusiness;
using System.Windows.Forms;
using SystemGlobalVariables;

namespace BankSystem.Login
{
    public partial class frmLogin : Form
    {
        private byte CounterFailedLogin = 0;
        private int _CounterTick = 60;
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
                CounterFailedLogin++;
                labCheckLogin.Visible = true;
                if (CounterFailedLogin == 3)
                {
                    txtPassword.Enabled = false;
                    txtUserName.Enabled = false;
                    labCheckLogin.Text = $"Lock System. You can login after 1 minute";
                    CounterFailedLogin = 0;
                    timer1.Enabled = true;
                    labTimer.Visible = true;
                }
                else
                { labCheckLogin.Text = $"Invalid username or password, You have {3 - CounterFailedLogin} tries to login"; }
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



    }
}
