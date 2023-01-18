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
    public partial class EditAgreementView : Form
    {
        AgreementModel agreementModel;
        AgreementDao agreementDao = new AgreementDao();
        List<ApartmentModel> apartmentModels;
        List<CustomerModel> customerModels;

        public EditAgreementView(AgreementModel agreementModel, List<ApartmentModel> apartmentModels,
            List<CustomerModel> customerModels)
        {
            InitializeComponent();
            this.agreementModel = agreementModel;
            this.apartmentModels = apartmentModels;
            this.customerModels = customerModels;

            agreeLabel.Text = "Agreement ID: " + agreementModel.AgreeID;
            if (apartmentBox.Items.Count == 0)
            {
                for (int i = 0; i < apartmentModels.Count; i++)
                {
                    apartmentBox.Items.Add(apartmentModels[i].AID);
                }
            }
            apartmentBox.Text = agreementModel.AID;
            if (customerBox.Items.Count == 0)
            {
                for (int i = 0; i < customerModels.Count; i++)
                {
                    customerBox.Items.Add(customerModels[i].Name);
                }
            }
            if(agreementModel.IntDepositPaid == 1)
            {
                depositStatus.Text = "Paid";
            }
            else
            {
                depositStatus.Text = "Unpaid";
            }
            depositStatus.Items.Add("Paid");
            depositStatus.Items.Add("Unpaid");
            startDateBox.Value = Convert.ToDateTime("Fri, 27 Feb 2009 03:11:21 GMT");
            endDateBox.Value = Convert.ToDateTime("Fri, 27 Feb 2009 03:11:21 GMT");
            var customer = customerModels.First(s => s.CID == agreementModel.CID);
            customerBox.Text = customer.Name;
            amountBox.Text = agreementModel.Amount.ToString();
            dueBox.Text = agreementModel.DueBalance.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            agreementModel.AID = apartmentBox.Text;
            var customer = customerModels.First(s => s.Name == customerBox.Text);
            agreementModel.CID = customer.CID;
            agreementModel.StartDate = startDateBox.Value.ToString("dddd, dd MMMM yyyy");
            agreementModel.EndDate = endDateBox.Value.ToString("dddd, dd MMMM yyyy");
            if(depositStatus.Text == "Paid")
            {
                agreementModel.IntDepositPaid = 1;
            }
            else
            {
                agreementModel.IntDepositPaid = 0;
            }
            agreementModel.Amount = float.Parse(amountBox.Text);
            agreementModel.DueBalance = float.Parse(dueBox.Text);
            agreementDao.update(agreementModel.AgreeID, agreementModel);
        }
    }
}
