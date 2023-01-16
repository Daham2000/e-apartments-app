using e_apartments_app.Controllers;
using e_apartments_app.db.Model;
using e_apartments_app.View;

namespace e_apartments_app.ui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (username.Text.Length == 0)
            {
                userValida.Text = "User name can't be empty...";
            }
            else
            {
                userValida.Text = "";
            }
            if (password.Text.Length == 0)
            {
                passwordVali.Text = "Password can't be empty...";
            }
            else
            {
                passwordVali.Text = "";
            }
            if (username.Text.Length != 0 & password.Text.Length != 0)
            {
                RootController rootController = new RootController();
                UserModel user = new UserModel();
                user.UserName = username.Text;
                user.Password = password.Text;
                bool loginSuccess = rootController.loginAction(user);
                if (loginSuccess)
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Worng credentials, try again...", "Failed", buttons, MessageBoxIcon.Error);
                }
            }
        }
    }
}
