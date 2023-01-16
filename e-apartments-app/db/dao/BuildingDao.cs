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

        public override BuildingModel[] getAll()
        {
            BuildingModel[] list = new BuildingModel[GetCount()];
            try
            {
                DbController dbController = new DbController();
                dbController.init();

                SqlDataReader? readerAllData = dbController.selectData("SELECT * FROM Buildings;");
                if (readerAllData.Read())
                {
                    int i = 0;
                    while (readerAllData.Read())
                    {
                        list[i] = new BuildingModel();
                        list[i].BID = readerAllData["bID"].ToString();
                        list[i].Location = readerAllData["location"].ToString();
                        list[i].NumOfApartments = Convert.ToInt32(readerAllData["numOfApartments"]);
                        list[i].NumOfFloors = Convert.ToInt32(readerAllData["numOfFloors"]);
                        i += 1;
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
    }
}
