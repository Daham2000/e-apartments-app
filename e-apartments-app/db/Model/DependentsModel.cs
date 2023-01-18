using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.Model
{
    public class DependentsModel
    {
        private string dID;
        private string cID;
        private string relation;
        private string name;

        public string DID { get => dID; set => dID = value; }
        public string CID { get => cID; set => cID = value; }
        public string Relation { get => relation; set => relation = value; }
        public string Name { get => name; set => name = value; }
    }
}
