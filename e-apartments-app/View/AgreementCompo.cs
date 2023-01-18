using e_apartments_app.db.dao;
using e_apartments_app.db.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_apartments_app.View
{
    public partial class AgreementCompo : UserControl
    {
        AgreementModel agreementModel;
        List<ApartmentModel> apartments = new List<ApartmentModel>();
        List<CustomerModel> customerModels;

        public AgreementCompo(AgreementModel agreementModel, CustomerModel customerModel, 
            ExtentionRequestsModel requestsModel, List<ApartmentModel> apartments, List<CustomerModel> customerModels)
        {
            InitializeComponent();
            this.agreementModel = agreementModel;
            agreeId.Text = "Agreement ID: " + agreementModel.AgreeID;
            apartmentID.Text = "Apartment ID: " + agreementModel.AID;
            customerID.Text = "Customer ID: " + agreementModel.CID;
            cusName.Text = "Customer Name: " + customerModel.Name;
            sDate.Text = "Start Date:  " + agreementModel.StartDate;
            eDate.Text = "End Date:  " + agreementModel.EndDate;
            amount.Text = "Amount: Rs " + agreementModel.Amount.ToString();
            dueLable.Text = "Due Balance: Rs " + agreementModel.DueBalance.ToString();
            if (agreementModel.IntDepositPaid == 1)
            {
                dPaid.Text = "Deposit Paid: Yes";
            }
            else
            {
                dPaid.Text = "Deposit Paid: No";
            }
            this.apartments = apartments;
            this.customerModels = customerModels;
        }

        private void AgreementCompo_Load(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditAgreementView editAgreementView = new EditAgreementView(agreementModel, apartments, customerModels);
            editAgreementView.Show();
        }
    }
}
