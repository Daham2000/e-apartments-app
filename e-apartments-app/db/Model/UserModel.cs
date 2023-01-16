using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.Model
{
    internal class UserModel
    {
        private string username;
        private string password;

        public String UserName
        {

            get
            {
                return username;
            }

            set
            {
                username = value;
            }

        }

        // using accessors to get and 
        // set the value of studentAge
        public String Password
        {

            get
            {
                return password;
            }

            set
            {
                password = value;
            }

        }
    }
}
