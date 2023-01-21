using e_apartments_app.db.dao;
using e_apartments_app.db.Model;
using e_apartments_app.util;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
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
            DateTime enteredDateE = DateTime.Parse(agreementModel.EndDate);
            var dateSpan = DateTimeSpan.CompareDates(enteredDateE, DateTime.Now);
            var compare = DateTime.Compare(enteredDateE, DateTime.Now);

            if(compare > 0 & dateSpan.Months > 0) {
                extention.Accepted = 2;
                extention.RequestedMonths = 3;
                extention.AgreeID = agreementModel.AgreeID;
                extention.ExtentionRequestsId = "EX00-" + Guid.NewGuid().ToString("N").Substring(10);
                extentionRequestsDao.Add(extention);
            }
            else
            {
                MessageBox.Show("You can only make a extention request 2 months before lease expire.");
            }
        }
    }
}
