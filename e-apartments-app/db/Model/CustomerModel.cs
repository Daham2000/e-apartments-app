using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.Model
{
    public class CustomerModel
    {
        private string cID;
        private string name;
        private string username;
        private string password;
        private string address;
        private string NIC;
        private int contactDetails;

        public string CID { get => cID; set => cID = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public string NIC1 { get => NIC; set => NIC = value; }
        public int ContactDetails { get => contactDetails; set => contactDetails = value; }
    }
}
