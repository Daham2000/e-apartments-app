using e_apartments_app.db.Model;
using System.Data;
using System.Data.SqlClient;

namespace e_apartments_app.db.dao
{
    internal class AppartmentClassDao : SuperDao<AppartmentClassModel>
    {
        public override AppartmentClassModel getSingle(string id)
        {
            AppartmentClassModel appartmentClassModel = new AppartmentClassModel();
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                SqlDataReader? reader = dbController.selectData("SELECT * FROM ApartmentsClass where clsID='" + id + "';");
                if (reader.Read() & reader != null)
                {
                    appartmentClassModel.ClassName = reader["className"].ToString();
                    appartmentClassModel.NumOfBedRooms = Convert.ToInt32(reader["numOfBedRooms"]);
                    appartmentClassModel.NumOfCommonBath = Convert.ToInt32(reader["numOfCommonBath"]);
                    appartmentClassModel.NumOfAttachBath = Convert.ToInt32(reader["numOfAttachBath"]);
                    appartmentClassModel.NumOfServantRooms = Convert.ToInt32(reader["numOfServantRooms"]);
                    appartmentClassModel.NumOfServantBath = Convert.ToInt32(reader["numOfServantBath"]);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e.ToString());
            }
            return appartmentClassModel;
        }

        public int GetCount()
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                SqlDataReader? sqlDataReader = dbController.selectData("SELECT COUNT(*) AS Rows FROM ApartmentsClass;");
                if (sqlDataReader.Read() & sqlDataReader != null)
                {
                    return Convert.ToInt32(sqlDataReader["Rows"]);
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        public override AppartmentClassModel[] getAll()
        {
            AppartmentClassModel[] list = new AppartmentClassModel[GetCount()];
            try
            {
                DbController dbController = new DbController();
                dbController.init();

                SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM ApartmentsClass;");
                if (readerAllData.Read())
                {
                    int i = 0;
                    while (readerAllData.Read())
                    {
                        list[i] = new AppartmentClassModel();
                        list[i].ClsID = readerAllData["clsID"].ToString();
                        list[i].ClassName = readerAllData["className"].ToString();
                        list[i].NumOfBedRooms = Convert.ToInt32(readerAllData["numOfBedRooms"]);
                        list[i].NumOfCommonBath = Convert.ToInt32(readerAllData["numOfCommonBath"]);
                        list[i].NumOfAttachBath = Convert.ToInt32(readerAllData["numOfAttachBath"]);
                        list[i].NumOfServantRooms = Convert.ToInt32(readerAllData["numOfServantRooms"]);
                        list[i].NumOfServantBath = Convert.ToInt32(readerAllData["numOfServantBath"]);
                        i += 1;
                    }
                }
                return list;
            }
            catch(Exception e)
            {
                return list;
            }
        }
    }
}
