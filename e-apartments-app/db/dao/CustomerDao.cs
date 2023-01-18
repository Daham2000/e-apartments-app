using e_apartments_app.db.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.dao
{
    internal class CustomerDao : SuperDao<CustomerModel>
    {
        public override void Add(CustomerModel model)
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("insert into Customers values ('" + model.CID + "', '" + model.Name
                    + "', '" + model.Username + "', '" + model.Password + "', '" + model.Address + "' " +
                    ", '" + model.NIC1 + "' , '" + model.ContactDetails + "' );");
                dbController.closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }

        public override List<CustomerModel> GetAll()
        {
            List<CustomerModel> list = new List<CustomerModel>();
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM Customers;");
                    while (readerAllData.Read())
                    {
                        CustomerModel customerModel = new CustomerModel();
                        customerModel.CID = readerAllData["cID"].ToString();
                        customerModel.Name = readerAllData["name"].ToString();
                        customerModel.Username = readerAllData["username"].ToString();
                        customerModel.Password = readerAllData["password"].ToString();
                        customerModel.Address = readerAllData["address"].ToString();
                        customerModel.NIC1 = readerAllData["NIC"].ToString();
                        customerModel.ContactDetails = Convert.ToInt32(readerAllData["contactDetails"]);
                        list.Add(customerModel);
                    }
                return list;
            }
            catch (Exception e)
            {
                return list;
            }
        }

        public override CustomerModel GetSingle(string id)
        {
            throw new NotImplementedException();
        }

        public CustomerModel UserLogin(UserModel user)
        {
            CustomerModel customerModel = new CustomerModel();
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM Customers where username='" + user.UserName + "' AND password='" + user.Password + "';");
                if (readerAllData.Read())
                {
                    customerModel.CID = readerAllData["cID"].ToString();
                    customerModel.Name = readerAllData["name"].ToString();
                    customerModel.Username = readerAllData["username"].ToString();
                    customerModel.Password = readerAllData["password"].ToString();
                    customerModel.Address = readerAllData["address"].ToString();
                    customerModel.NIC1 = readerAllData["NIC"].ToString();
                    customerModel.ContactDetails = Convert.ToInt32(readerAllData["contactDetails"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw new Exception("Exception: " + e.ToString());
            }
            return customerModel;
        }

        public override void Update(string id, CustomerModel model)
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("update Customers set name = '" +
                    model.Name + "', username = '" + model.Username + "', password = '" + model.Password +
                    "', address = '" + model.Address +
                    "', NIC = '" + model.NIC1 +
                    "', contactDetails = '" + model.ContactDetails +
                   "' where cID = '" + model.CID + "';");
                dbController.closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }

        public List<DependentsModel> GetAllDependents() {
            List<DependentsModel> list = new List<DependentsModel>();
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM Dependents;");
                while (readerAllData.Read())
                {
                    DependentsModel model = new DependentsModel();
                    model.CID = readerAllData["cID"].ToString();
                    model.Relation = readerAllData["relation"].ToString();
                    model.Name = readerAllData["name"].ToString();
                    list.Add(model);
                }
                return list;
            }
            catch (Exception e)
            {
                return list;
            }
        }

        public void AddDependant(DependentsModel model)
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("insert into Dependents values ('" + model.DID + "', '" + model.CID
                + "', '" + model.Relation + "', '" + model.Name + "' );");
                dbController.closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }
    }
}
