﻿using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace e_apartments_app.db
{
    internal class DbController
    {

        SqlConnection connection;
        public DbController()
        {

        }

        public bool init()
        {
            string connetionString = @"Data Source=LAPTOP-4TJS1BE6;Integrated security=true; User ID=LAPTOP-4TJS1BE6\acer;Password=";
            connection = new SqlConnection(connetionString);
            connection.Open();
            initDb();
            seedInitData();
            return true;
        }

        public void closeConnection()
        {
            connection.Close();
        }

        public bool restartConn() 
        {
            try
            {
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void dropDb()
        {
            restartConn();
            runQuery("DROP DATABASE eapartments;");
            closeConnection();
        }

        public void initDb()
        {
            try
            {
                runQuery("CREATE DATABASE eapartments;");
                closeConnection();

                string connetionString = @"Data Source=LAPTOP-4TJS1BE6;Initial Catalog=eapartments; Integrated security=true; User ID=LAPTOP-4TJS1BE6\acer;Password=";
                connection = new SqlConnection(connetionString);
                restartConn();

                //Sql table Buildings
                string query = "create table Buildings (bID varchar(100) NOT null, location varchar(100) NOT null, numOfApartments int NOT null, numOfFloors int NOT null, primary key (bID));";
                runQuery(query);

                //Sql table Customers
                query = "create table Customers (cID varchar(100) NOT null, name varchar(100) NOT null, address varchar(100) NOT null, NIC varchar(100) NOT null, contactDetails int NOT null, primary key (cID));";
                runQuery(query);

                //Sql table Dependents
                query = "create table Dependents (dID varchar(100) NOT null, cID varchar(100) NOT null, relation varchar(100) NOT null, name varchar(100) NOT null, primary key (dID), FOREIGN KEY (cID) REFERENCES Customers(cID));";
                runQuery(query);

                //Sql table ApartmentsClass
                query = "create table ApartmentsClass (clsID varchar(100) Not null, className varchar(100) Not null, numOfBedRooms int Not null, numOfCommonBath int not null, numOfAttachBath int not null, numOfServantRooms int not null, numOfServantBath int not null, primary KEY (clsID));";
                runQuery(query);

                //Sql table Apartments
                query = "create table Apartments (aID varchar(100) NOT null, clsID varchar(100) Not null, bID varchar(100) NOT null, floorNum int NOT null, ifAvailable int NOT null, currentOccupant varchar(100), intDeposit float NOT null, monthly float NOT null, unavailableReason varchar(100) not null, primary key (aID), FOREIGN KEY (clsID) REFERENCES ApartmentsClass(clsID), FOREIGN KEY (bID) REFERENCES Buildings(bID));";
                runQuery(query);

                //Sql table Agreement
                query = "create table Agreements (agreeID varchar(100) NOT null, aID varchar(100) NOT null, cID varchar(100) NOT null, startDate varchar(100) NOT null, endDate varchar(100) NOT null, intDepositPaid int NOT null, amount float NOT null, dueBalance float NOT null, primary key (agreeID), FOREIGN KEY (cID) REFERENCES Customers(cID), FOREIGN KEY (aID) REFERENCES Apartments(aID));";
                runQuery(query);

                //Sql table ExtentionRequests
                query = "create table ExtentionRequests (extentionRequestsId varchar(100) NOT null, agreeID varchar(100) NOT null, requestedMonths int NOT null, accepted int NOT null, primary key (extentionRequestsId), FOREIGN KEY (agreeID) REFERENCES Agreements(agreeID));";
                runQuery(query);

                //Sql table Payment
                query = "create table Payment (payID varchar(100) NOT null, agreeID varchar(100) NOT null,  month int NOT null, amount float NOT null, primary key (payID), FOREIGN KEY (agreeID) REFERENCES Agreements(agreeID));";
                runQuery(query);
            }
            catch (Exception e) {
                Console.WriteLine($"Exception: {e}");
            }
        }

        public void seedInitData()
        {
            string query = "insert into ApartmentsClass values ('cls0001', 'Class 1', 1, 1, 0,0,0);";
            runQuery(query);
            query = "insert into ApartmentsClass values ('cls0002', 'Class 2', 2, 1, 1,0,0);";
            runQuery(query);
            query = "insert into ApartmentsClass values ('cls0003', 'Class 3', 3, 2, 1,0,0);";
            runQuery(query);
            query = "insert into ApartmentsClass values ('cls0004', 'Class Suite', 4, 1, 3,1,1);";
            runQuery(query);

            query = "insert into Buildings values ('B000233', 'Colombo 02', 20, 3);";
            runQuery(query);
            query = "insert into Buildings values ('B00033', 'Moratuwa', 10, 3);";
            runQuery(query);

            query = "insert into Apartments values ('A000112', 'cls0001', 'B000233', 2, 1, 'Nipun Silva', 12000, 6000, 'rented');";
            runQuery(query);

            query = "insert into Apartments values ('A000221', 'cls0003', 'B00033', 2, 1, 'Nipun Silva', 69000, 20000, 'rented');";
            runQuery(query);

            query = "insert into Apartments values ('A00032', 'cls0001', 'B000233', 2, 0, '', 12000, 6000, '');";
            runQuery(query);
            query = "insert into Apartments values ('A00042', 'cls0001', 'B00033', 2, 0, '', 70000, 10000, '');";
            runQuery(query);
        }

        public bool runQuery(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                return true;
            }catch (Exception e) { 
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public SqlDataReader? selectData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception selectData: " + e.ToString());
                return null;
            }
        }

    }
}
