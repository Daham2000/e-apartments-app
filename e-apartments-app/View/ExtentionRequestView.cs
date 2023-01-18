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
    public partial class ExtentionRequestView : UserControl
    {
        AgreementModel agreementModel = new AgreementModel();
        ExtentionRequestsModel extentionRequestsModel = new ExtentionRequestsModel();
        List<ApartmentModel> apartments = new List<ApartmentModel>();
        List<CustomerModel> customerModels;
        ExtentionRequestsDao requestsDao= new ExtentionRequestsDao();

        public ExtentionRequestView(AgreementModel agreementModel, CustomerModel customerModel,
            ExtentionRequestsModel requestsModel, List<ApartmentModel> apartments, 
            List<CustomerModel> customerModels, ExtentionRequestsModel extentionRequestsModel)
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
            this.extentionRequestsModel = extentionRequestsModel;
            monthsLabel.Text = "Requested Months: " + extentionRequestsModel.RequestedMonths;

            if (extentionRequestsModel.Accepted == 1)
            {
                acceptedLabel.Text = "Accepted";
                acceptedLabel.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
                rejectBtn.Hide();
                actBtn.Hide();
            }
            if (extentionRequestsModel.Accepted == 2)
            {
                acceptedLabel.Text = "Pending";
                acceptedLabel.ForeColor = System.Drawing.Color.Orange;
                rejectBtn.Show();
                actBtn.Show();
            }
            if (extentionRequestsModel.Accepted == 0)
            {
                acceptedLabel.Text = "Rejected";
                acceptedLabel.ForeColor = System.Drawing.Color.Red;
                rejectBtn.Hide();
                actBtn.Hide();
            }
        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            extentionRequestsModel.Accepted = 0;
            requestsDao.update(extentionRequestsModel.AgreeID, extentionRequestsModel);
        }

        private void actBtn_Click(object sender, EventArgs e)
        {
            extentionRequestsModel.Accepted = 1;
            requestsDao.update(extentionRequestsModel.AgreeID, extentionRequestsModel);
        }
    }
}
