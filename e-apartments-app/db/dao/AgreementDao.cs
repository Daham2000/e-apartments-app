using e_apartments_app.db.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.dao
{
    public class AgreementDao : SuperDao<AgreementModel>
    {
        public override void Add(AgreementModel model)
        {
            throw new NotImplementedException();
        }

        public override List<AgreementModel> getAll()
        {
            DbController dbController = new DbController();
            dbController.init();
            List<AgreementModel> list = new List<AgreementModel>();

            SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM Agreements;");
            if (readerAllData.Read())
            {
                while (readerAllData.Read())
                {
                    AgreementModel agreementModel = new AgreementModel();
                    agreementModel.AgreeID = readerAllData["agreeID"].ToString();
                    agreementModel.AID = readerAllData["aID"].ToString();
                    agreementModel.CID = readerAllData["cID"].ToString();
                    agreementModel.StartDate = readerAllData["startDate"].ToString();
                    agreementModel.EndDate = readerAllData["endDate"].ToString();
                    agreementModel.IntDepositPaid = Convert.ToInt32(readerAllData["intDepositPaid"]);
                    agreementModel.Amount = float.Parse(readerAllData["intDepositPaid"].ToString());
                    agreementModel.DueBalance = float.Parse(readerAllData["dueBalance"].ToString());
                    list.Add(agreementModel);
                }
                return list;
            }
            else
            {
                return list;
            }
        }

        public override AgreementModel getSingle(string id)
        {
            throw new NotImplementedException();
        }

        public override void update(string id, AgreementModel model)
        {
            throw new NotImplementedException();
        }
    }
}
