using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.Model
{
    public class AppartmentClassModel
    {
        private string clsID;
        private string className;
        private int numOfBedRooms;
        private int numOfCommonBath;
        private int numOfAttachBath;
        private int numOfServantRooms;
        private int numOfServantBath;

        public string ClsID { get => clsID; set => clsID = value; }
        public string ClassName { get => className; set => className = value; }
        public int NumOfBedRooms { get => numOfBedRooms; set => numOfBedRooms = value; }
        public int NumOfCommonBath { get => numOfCommonBath; set => numOfCommonBath = value; }
        public int NumOfAttachBath { get => numOfAttachBath; set => numOfAttachBath = value; }
        public int NumOfServantRooms { get => numOfServantRooms; set => numOfServantRooms = value; }
        public int NumOfServantBath { get => numOfServantBath; set => numOfServantBath = value; }
    }
}
