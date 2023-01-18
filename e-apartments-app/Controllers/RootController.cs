using e_apartments_app.db.dao;
using e_apartments_app.db.Model;
using e_apartments_app.util;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.VisualBasic.ApplicationServices;

namespace e_apartments_app.Controllers
{
    internal class RootController
    {
        CustomerModel customerModel = new CustomerModel();

        public bool loginAction(UserModel user)
        {
            AdminManage admin = new AdminManage();
            //Check admin user credencials
            //Password is encrypted
            if (user.UserName == admin.getAdminUserName())
            {
                if(user.Password == admin.getAdminHash()){
                    return true;
                }
            }
            else
            {
                //Check customer user credencials with database
                CustomerDao customerDao = new CustomerDao();
                customerModel = customerDao.UserLogin(user);
                if(customerModel.CID != null)
                {
                    return true;
                }
            }
            return false;
        }

        public CustomerModel getCustomerModel()
        {
            return customerModel;
        }

        public bool ifLoggedIn()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
