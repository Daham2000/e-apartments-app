using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.util
{
    internal class AdminManage
    {
        private string AdminUserName = "Admin";
        private string AdminPasswordHash = "37gxbxZk6NWh628InAZ1EwRrLDFyirBbXTjFB1x5yJI=\r\n";

        public string getAdminHash()
        {
            Encoder encoder = new Encoder();
            return encoder.Decrypt(AdminPasswordHash);
        }

        public string getAdminUserName()
        {
            return AdminUserName;
        }
    }
}
