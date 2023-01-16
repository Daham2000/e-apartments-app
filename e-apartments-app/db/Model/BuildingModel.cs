using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.Model
{
    public class BuildingModel
    {
        private string bID;
        private string location;
        private int numOfApartments;
        private int numOfFloors;

        public string BID { get => bID; set => bID = value; }
        public string Location { get => location; set => location = value; }
        public int NumOfApartments { get => numOfApartments; set => numOfApartments = value; }
        public int NumOfFloors { get => numOfFloors; set => numOfFloors = value; }
    }
}
