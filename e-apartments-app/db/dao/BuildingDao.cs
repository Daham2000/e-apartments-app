using e_apartments_app.db.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace e_apartments_app.db.dao
{
    internal class BuildingDao : SuperDao<BuildingModel>
    {
        public int GetCount()
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                SqlDataReader? sqlDataReader = dbController.selectData("SELECT COUNT(*) AS Rows FROM Buildings;");
                if (sqlDataReader.Read() & sqlDataReader != null)
                {
                    return Convert.ToInt32(sqlDataReader["Rows"]);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public override List<BuildingModel> getAll()
        {
            List<BuildingModel> list = new List<BuildingModel>();
            try
            {
                DbController dbController = new DbController();
                dbController.init();

                SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM Buildings;");
                if (readerAllData.Read())
                {
                    while (readerAllData.Read())
                    {
                        BuildingModel buildingModel = new BuildingModel();
                        buildingModel.BID = readerAllData["bID"].ToString();
                        buildingModel.Location = readerAllData["location"].ToString();
                        buildingModel.NumOfApartments = Convert.ToInt32(readerAllData["numOfApartments"]);
                        buildingModel.NumOfFloors = Convert.ToInt32(readerAllData["numOfFloors"]);
                        list.Add(buildingModel);
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                return list;
            }
        }

        public override BuildingModel getSingle(string id)
        {
            BuildingModel buildingModel = new BuildingModel();
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                SqlDataReader? reader = dbController.selectData("SELECT * FROM Buildings where bID='" + id + "';");
                if (reader.Read() & reader != null)
                {
                    buildingModel.BID = reader["bID"].ToString();
                    buildingModel.Location = reader["location"].ToString();
                    buildingModel.NumOfApartments = Convert.ToInt32(reader["numOfApartments"]);
                    buildingModel.NumOfFloors = Convert.ToInt32(reader["numOfFloors"]);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e.ToString());
            }
            return buildingModel;
        }

        public override void update(string id, BuildingModel model)
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("update Buildings set location = '" +
                    model.Location + "', numOfApartments = '" + model.NumOfApartments + "', numOfFloors = '" + model.NumOfFloors +
                   "' where bID = " + model.BID + ";");
                dbController.closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }

        public override void Add(BuildingModel model)
        {
            try
            {
                DbController dbController = new DbController();
                dbController.init();
                dbController.runQueryUpdate("insert into Buildings values ('" + model.BID + "', '" + model.Location
                    + "', " + model.NumOfApartments + ", " + model.NumOfFloors + " );");
                dbController.closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception("Exception: " + e);
            }
        }
    }
}
