﻿using e_apartments_app.db.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.dao
{
    internal class CustomerDao : SuperDao<CustomerModel>
    {
        public override List<CustomerModel> getAll()
        {
            List<CustomerModel> list = new List<CustomerModel>();
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM Customers;");
                if (readerAllData.Read())
                {
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
                }
                return list;
            }
            catch (Exception e)
            {
                return list;
            }
        }

        public override CustomerModel getSingle(string id)
        {
            throw new NotImplementedException();
        }

        public override void update(string id, CustomerModel model)
        {
            try {
                
            }catch(Exception e)
            {

            }
        }
    }
}