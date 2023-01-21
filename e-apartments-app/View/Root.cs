using e_apartments_app.db;
using e_apartments_app.ui;
using e_apartments_app.View;

namespace e_apartments_app
{
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
            initApp();
        }

        private void initApp()
        {
            DbController dbCtrl = new DbController();
            dbCtrl.init();
        }

        private void Root_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width == 808) 
            {
                timer1.Stop();
                Login login = new Login();
                AdminDashboard adminDashboard = new AdminDashboard();
                login.Show();
                this.Hide();
            }
        }
    }
}
