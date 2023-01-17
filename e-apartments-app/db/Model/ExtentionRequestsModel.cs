using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.Model
{
    public class ExtentionRequestsModel
    {
        private string extentionRequestsId;
        private string agreeID;
        private int requestedMonths;
        private int accepted;

        public string ExtentionRequestsId { get => extentionRequestsId; set => extentionRequestsId = value; }
        public string AgreeID { get => agreeID; set => agreeID = value; }
        public int RequestedMonths { get => requestedMonths; set => requestedMonths = value; }
        public int Accepted { get => accepted; set => accepted = value; }
    }
}
