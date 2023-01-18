using e_apartments_app.db.dao;
using e_apartments_app.db.Model;
using e_apartments_app.ui;

namespace e_apartments_app.View
{
    public partial class CustomerDashboard : Form
    {
        AgreementDao agreementDao = new AgreementDao();
        List<AgreementModel> agreementModelList = new List<AgreementModel>();
        CustomerModel customerModel = new CustomerModel();

        public CustomerDashboard(CustomerModel customerModel)
        {
            InitializeComponent();
            this.customerModel = customerModel;
            loadData();
        }

        private void loadData()
        {
            agreementModelList = agreementDao.GetUserAgreement(customerModel.CID);
            flowLayout.Controls.Clear();

            MyAppartmentView[] agreementCompos = new MyAppartmentView[agreementModelList.Count];
            for (int i = 0; i < agreementModelList.Count; i++)
            {
                if (agreementModelList[i] != null)
                {
                    agreementCompos[i] = new MyAppartmentView(agreementModelList[i]);
                    flowLayout.Controls.Add(agreementCompos[i]);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
