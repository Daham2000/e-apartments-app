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
    public partial class AddLeaseView : Form
    {
        List<ApartmentModel> apartmentModels;
        List<CustomerModel> customerList;

        public AddLeaseView(List<ApartmentModel> apartmentModels, List<CustomerModel> customerList)
        {
            InitializeComponent();
            this.apartmentModels = apartmentModels;
            this.customerList = customerList;
            foreach (ApartmentModel model in apartmentModels)
            {
                apartmentBox.Items.Add(model.AID);
            }
            foreach (CustomerModel model in customerList)
            {
                customerBox.Items.Add(model.Name);
            }
        }

        private void addLease_Click(object sender, EventArgs e)
        {
            AgreementDao agreementDao = new AgreementDao();
            AgreementModel agreementModel = new AgreementModel();
            string id = "AG_" + Guid.NewGuid().ToString("N").Substring(10);
            var customer = customerList.First(s => s.Name == customerBox.Text);
            agreementModel.StartDate = startDate.Value.ToString("dddd, dd MMMM yyyy");
            agreementModel.EndDate = endDate.Value.ToString("dddd, dd MMMM yyyy");
            agreementModel.AgreeID = id;
            agreementModel.CID = customer.CID;
            agreementModel.AID = apartmentBox.Text;
            if (float.Parse(amountBox.Text) != null)
            {
                agreementModel.IntDepositPaid = 1;
                agreementModel.Amount = float.Parse(amountBox.Text);
            }
            else
            {
                agreementModel.IntDepositPaid = 0;
            }
            agreementDao.Add(agreementModel);
            
        }
    }
}
