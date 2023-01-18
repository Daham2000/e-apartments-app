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
    public partial class CustomerCard : UserControl
    {
        CustomerModel customerModel = new CustomerModel();
        List<DependentsModel> dependentsModels = new List<DependentsModel>();

        public CustomerCard(CustomerModel customerModel, List<DependentsModel> dependentsModels)
        {
            InitializeComponent();
            this.customerModel = customerModel;
            this.dependentsModels = dependentsModels;
            userNameLabel.Text = "Customer User Name: " + customerModel.Username;
            name.Text = "Customer Name: " + customerModel.Name;
            addressLabel.Text = "Customer Address: " + customerModel.Address;
            nicLabel.Text = "Customer NIC: " + customerModel.NIC1;
            contactLabel.Text = "Customer Contact Number: +94" + customerModel.ContactDetails.ToString();
            for(int i=0; i < dependentsModels.Count; i++)
            {
                Label label = new Label();
                label.Text = i+1 + ") " + dependentsModels[i].Name + ", Relation: " + dependentsModels[i].Relation;
                label.Size = new System.Drawing.Size(350, 20);
                flowDependant.Controls.Add(label);
            }
        }

        private void CustomerCard_Load(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditCustomerView editCustomerView = new EditCustomerView(customerModel, dependentsModels);
            editCustomerView.Show();
        }
    }
}
