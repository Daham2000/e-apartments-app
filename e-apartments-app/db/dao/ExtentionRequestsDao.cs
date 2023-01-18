using e_apartments_app.db.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.dao
{
    internal class ExtentionRequestsDao : SuperDao<ExtentionRequestsModel>
    {
        public override void Add(ExtentionRequestsModel model)
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("insert into ExtentionRequests values ('" + model.ExtentionRequestsId + "', '" + model.AgreeID
                    + "', '" + model.RequestedMonths + "', " + model.Accepted + "' );");
                dbController.closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }

        public override List<ExtentionRequestsModel> getAll()
        {
            DbController dbController = new DbController();
            dbController.init();
            List<ExtentionRequestsModel> list = new List<ExtentionRequestsModel>();

            SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM ExtentionRequests;");
            dbController.init();
            if (readerAllData.Read())
            {
                while (readerAllData.Read())
                {
                    ExtentionRequestsModel model = new ExtentionRequestsModel();
                    model.ExtentionRequestsId = readerAllData["extentionRequestsId"].ToString();
                    model.AgreeID = readerAllData["agreeID"].ToString();
                    model.RequestedMonths = Convert.ToInt32(readerAllData["requestedMonths"]);
                    model.Accepted = Convert.ToInt32(readerAllData["accepted"]);
                    list.Add(model);
                }
                return list;
            }
            else
            {
                return list;
            }
        }

        public override ExtentionRequestsModel getSingle(string id)
        {
            throw new NotImplementedException();
        }

        public override void update(string id, ExtentionRequestsModel model)
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("update ExtentionRequests set agreeID = '" +
                    model.AgreeID + "', requestedMonths  ='" + model.RequestedMonths + "', accepted = '" + model.Accepted +
                    "' where extentionRequestsId ='" + model.ExtentionRequestsId + "';");
                dbController.closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }
    }
}
