using e_apartments_app.db.Model;
using System.Data.SqlClient;

namespace e_apartments_app.db.dao
{
    internal class ApartmentDao : SuperDao<ApartmentModel>
    {
        public override void Add(ApartmentModel model)
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("insert into Apartments values ('" + model.AID + "', '" + model.ClsID 
                    + "', '" + model.BID + "', " + model.FloorNum + ", " + model.IfAvailable + " " +
                    ", '" + model.CurrentOccupant + "' , " + model.IntDeposit + " , " 
                    + model.Monthly + " , '" + model.UnavailableReason + "' );");
                dbController.closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }

        public override List<ApartmentModel> getAll()
        {
            DbController dbController = new DbController();
            dbController.init();
            List<ApartmentModel> list = new List<ApartmentModel>();

            SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM Apartments;");
            dbController.init();
            if (readerAllData.Read())
            {
                while (readerAllData.Read())
                {
                    ApartmentModel apartmentModel = new ApartmentModel();
                    apartmentModel.AID = readerAllData["aID"].ToString();
                    apartmentModel.UnavailableReason = readerAllData["unavailableReason"].ToString();
                    apartmentModel.ClsID = readerAllData["clsID"].ToString();
                    apartmentModel.BID = readerAllData["bID"].ToString();
                    apartmentModel.FloorNum = Convert.ToInt32(readerAllData["floorNum"]);
                    apartmentModel.IfAvailable = Convert.ToInt32(readerAllData["IfAvailable"]);
                    apartmentModel.CurrentOccupant = readerAllData["currentOccupant"].ToString();
                    apartmentModel.IntDeposit = Convert.ToSingle(readerAllData["intDeposit"]);
                    apartmentModel.Monthly = Convert.ToSingle(readerAllData["monthly"]);
                    list.Add(apartmentModel);
                }
                return list;
            }
            else
            {
                return list;
            }
        }

        public override ApartmentModel getSingle(string id)
        {
            throw new NotImplementedException();
        }

        public override void update(string id, ApartmentModel model)
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("update Apartments set clsID = '" +
                    model.ClsID + "', floorNum  ='" + model.FloorNum + "', bID = '" + model.BID +
                    "', ifAvailable = '" + model.IfAvailable + "', " +
                    "currentOccupant = '" + model.CurrentOccupant + "', intDeposit = '" + model.IntDeposit +
                    "', monthly = '" + model.Monthly + "', " +
                    "unavailableReason = '" + model.UnavailableReason + "' where aID ='" + model.AID + "';");
                dbController.closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }
    }

}
