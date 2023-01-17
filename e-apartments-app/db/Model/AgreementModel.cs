using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.Model
{
    public class AgreementModel
    {
        private string agreeID;
        private string aID;
        private string cID;
        private string startDate;
        private string endDate;
        private int intDepositPaid;
        private float amount;
        private float dueBalance;

        public string AgreeID { get => agreeID; set => agreeID = value; }
        public string AID { get => aID; set => aID = value; }
        public string CID { get => cID; set => cID = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public int IntDepositPaid { get => intDepositPaid; set => intDepositPaid = value; }
        public float Amount { get => amount; set => amount = value; }
        public float DueBalance { get => dueBalance; set => dueBalance = value; }
    }
}
