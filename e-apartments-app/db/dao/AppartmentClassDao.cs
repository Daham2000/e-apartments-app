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

        public override List<AppartmentClassModel> getAll()
        {
            List<AppartmentClassModel> list = new List<AppartmentClassModel>();
            try
            {
                DbController dbController = new DbController();
                dbController.init();

                SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM ApartmentsClass;");
                    while (readerAllData.Read())
                    {
                        AppartmentClassModel model = new AppartmentClassModel();
                        model.ClsID = readerAllData["clsID"].ToString();
                        model.ClassName = readerAllData["className"].ToString();
                        model.NumOfBedRooms = Convert.ToInt32(readerAllData["numOfBedRooms"]);
                        model.NumOfCommonBath = Convert.ToInt32(readerAllData["numOfCommonBath"]);
                        model.NumOfAttachBath = Convert.ToInt32(readerAllData["numOfAttachBath"]);
                        model.NumOfServantRooms = Convert.ToInt32(readerAllData["numOfServantRooms"]);
                        model.NumOfServantBath = Convert.ToInt32(readerAllData["numOfServantBath"]);
                        list.Add(model);
                    }
                return list;
            }
            catch(Exception e)
            {
                return list;
            }
        }

        public override void update(string id, AppartmentClassModel model)
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("update ApartmentsClass set className = '" +
                    model.ClassName + "', numOfBedRooms  ='" + model.NumOfBedRooms + "', numOfCommonBath = '" 
                    + model.NumOfCommonBath +
                    "', numOfAttachBath = '" + model.NumOfAttachBath + "', " +
                    "numOfServantRooms = '" + model.NumOfServantRooms + "', numOfServantBath = '" + model.NumOfServantBath +
                    "' where clsID ='" + model.ClsID + "';");
                dbController.closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }

        public override void Add(AppartmentClassModel model)
        {
            try {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("insert into ApartmentsClass values ('"+ model.ClsID + "', '" + model.ClassName
                    + "', '" + model.NumOfBedRooms + "', '" + model.NumOfCommonBath + "', '" + model.NumOfAttachBath + "' " +
                    ", '" + model.NumOfServantRooms + "' , '" + model.NumOfServantBath + "' );");
                dbController.closeConnection();
            }
            catch(Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }
    }
}
