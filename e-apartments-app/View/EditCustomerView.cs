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
    public partial class EditCustomerView : Form
    {
        CustomerModel customerModel = new CustomerModel();
        List<DependentsModel> dependentsModels = new List<DependentsModel>();

        public EditCustomerView(CustomerModel customerModel, List<DependentsModel> dependentsModels)
        {
            InitializeComponent();
            this.customerModel = customerModel;
            this.dependentsModels = dependentsModels;
            username.Text =customerModel.Username;
            name.Text = customerModel.Name;
            address.Text = customerModel.Address;
            nicLabel.Text =customerModel.NIC1;
            contactLabel.Text =  customerModel.ContactDetails.ToString();
            for (int i = 0; i < dependentsModels.Count; i++)
            {
                Label label = new Label();
                label.Text = i + 1 + ") " + dependentsModels[i].Name + ", Relation: " + dependentsModels[i].Relation;
                label.Size = new System.Drawing.Size(350, 20);
                flowDependant.Controls.Add(label);
            }
        }

        private void addDependantBtn_Click(object sender, EventArgs e)
        {
            CustomerDao customerDao = new CustomerDao();

            DependentsModel dependentsModel = new DependentsModel();
            dependentsModel.DID = "D0-" + Guid.NewGuid().ToString("N");
            dependentsModel.CID = customerModel.CID;
            dependentsModel.Name = newName.Text;
            dependentsModel.Relation = relationBox.Text;

            Label label = new Label();
            label.Text = dependentsModels.Count + 1 + ") " + dependentsModel.Name + ", Relation: " + dependentsModel.Relation;
            label.Size = new System.Drawing.Size(350, 20);
            flowDependant.Controls.Add(label);
            dependentsModels.Add(dependentsModel);
            customerDao.AddDependant(dependentsModel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerDao customerDao = new CustomerDao();
            customerModel.NIC1 = nicLabel.Text;
            customerModel.Username = username.Text;
            customerModel.Address = address.Text;
            customerModel.Name = name.Text;
            customerModel.ContactDetails = int.Parse(contactLabel.Text);
            customerDao.Update(customerModel.CID, customerModel);
        }
    }
}
