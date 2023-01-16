using e_apartments_app.db.Model;
using e_apartments_app.util;
using Microsoft.Extensions.Caching.Memory;

namespace e_apartments_app.Controllers
{
    internal class RootController
    {

        public bool loginAction(UserModel user)
        {
            AdminManage admin = new AdminManage();
            // implement login action with rootController class
            if (user.UserName == admin.getAdminUserName())
            {
                if(user.Password == admin.getAdminHash()){
                    return true;
                }
            }
            else
            {

            }
            return false;
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
