using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.Model
{
    public class ApartmentModel
    {
        private string aID;
        private string clsID;
        private string bID;
        private int floorNum;
        private int ifAvailable;
        private string currentOccupant;
        private float intDeposit;
        private float monthly;
        private string unavailableReason;

        public string AID { get => aID; set => aID = value; }
        public string ClsID { get => clsID; set => clsID = value; }
        public string BID { get => bID; set => bID = value; }
        public int FloorNum { get => floorNum; set => floorNum = value; }
        public int IfAvailable { get => ifAvailable; set => ifAvailable = value; }
        public string CurrentOccupant { get => currentOccupant; set => currentOccupant = value; }
        public float IntDeposit { get => intDeposit; set => intDeposit = value; }
        public float Monthly { get => monthly; set => monthly = value; }
        public string UnavailableReason { get => unavailableReason; set => unavailableReason = value; }
    }
}
