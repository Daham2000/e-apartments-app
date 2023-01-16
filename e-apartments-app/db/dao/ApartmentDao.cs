using e_apartments_app.db.Model;
using System.Data.SqlClient;

namespace e_apartments_app.db.dao
{
    internal class ApartmentDao
    {
        public ApartmentModel[] getAll()
        {
            DbController dbController = new DbController();
            dbController.init();

            SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM Apartments;");
            dbController.init();
            SqlDataReader? sqlDataReader = dbController.selectData("SELECT COUNT(*) AS Rows FROM Apartments;");
            if (sqlDataReader.Read() & readerAllData.Read())
            {
                ApartmentModel[] apartments = new ApartmentModel[sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Rows"))];
                int i = 0;
                while (readerAllData.Read())
                {
                    apartments[i] = new ApartmentModel();
                    apartments[i].AID = readerAllData["aID"].ToString();
                    apartments[i].UnavailableReason = readerAllData["unavailableReason"].ToString();
                    apartments[i].ClsID = readerAllData["clsID"].ToString();
                    apartments[i].BID = readerAllData["bID"].ToString();
                    apartments[i].FloorNum = Convert.ToInt32(readerAllData["floorNum"]);
                    apartments[i].IfAvailable = Convert.ToInt32(readerAllData["IfAvailable"]);
                    apartments[i].CurrentOccupant = readerAllData["currentOccupant"].ToString();
                    apartments[i].IntDeposit = Convert.ToSingle(readerAllData["intDeposit"]);
                    apartments[i].Monthly = Convert.ToSingle(readerAllData["monthly"]);
                    i += 1;
                }
                return apartments;
            }
            else
            {
                ApartmentModel[] apartments = new ApartmentModel[0];
                return apartments;
            }
        }
    }

}
