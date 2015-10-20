using System;
using System.Linq;
using System.Windows.Forms;
using AircraftStore.WinForms.Account;

namespace AircraftStore.WinForms.Views
{
    public partial class UcLogin : UserControl
    {       
        public MainForm MainForm { get; set; }

        public UcLogin()
        {
            InitializeComponent();
        }        
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        private void Authenticate()
        {
            if (cmbUserName.SelectedIndex == -1) return;

            var user = (LoginUser) cmbUserName.SelectedItem;
            if (user.VerifyPassword(txtPassword.Text))
            {
                MainForm.LoadAdminConsole();
            }
            else
            {
                MessageBox.Show(@"Login Failed");
            }
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            var loginUsers = DataHelper.GetLoginUsers().Where(i => i.Roles.Any(x => x.Name == "Admin"));
            foreach (var loginUser in loginUsers)
            {
                cmbUserName.Items.Add(loginUser);
            }
            if (cmbUserName.Items.Count > 0)
                cmbUserName.SelectedIndex = 0;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authenticate();
            }
        }
    }
}
