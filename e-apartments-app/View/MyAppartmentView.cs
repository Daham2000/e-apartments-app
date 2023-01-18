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
    public partial class MyAppartmentView : UserControl
    {
        AgreementModel agreementModel = new AgreementModel();

        public MyAppartmentView(AgreementModel agreementModel)
        {
            InitializeComponent();
            this.agreementModel = agreementModel;

            leaseID.Text = "Lease ID: " + agreementModel.AgreeID;
            apartmentID.Text = "Apartment ID: " + agreementModel.AID;
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
        }

        private void reqBtn_Click(object sender, EventArgs e)
        {
            ExtentionRequestsDao extentionRequestsDao = new ExtentionRequestsDao();
            ExtentionRequestsModel extention = new ExtentionRequestsModel();
            extention.Accepted = 2;
            extention.RequestedMonths = 3;
            extention.AgreeID = agreementModel.AgreeID;
            extention.ExtentionRequestsId = "EX00-" + Guid.NewGuid().ToString("N");
            extentionRequestsDao.Add(extention);
        }
    }
}
