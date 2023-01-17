using e_apartments_app.db.dao;
using e_apartments_app.db.Model;

namespace e_apartments_app.View
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            populateApartments();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void populateApartments()
        {
            ApartmentDao apartmentDao = new ApartmentDao();
            AppartmentClassDao appartmentClassDao = new AppartmentClassDao();
            CustomerDao customerDao = new CustomerDao();
            BuildingDao buildingDao = new BuildingDao();
            AppartmentClassModel appartmentClass = new AppartmentClassModel();
            BuildingModel buildingModel = new BuildingModel();
            List<ApartmentModel> apartments = apartmentDao.getAll();
            ApartmentComponent[] apartmentComponents = new ApartmentComponent[apartments.Count];
            List<AppartmentClassModel> appartmentClasses = appartmentClassDao.getAll();
            List<CustomerModel> customerModels = customerDao.getAll();
            List<BuildingModel>  buildingModels = buildingDao.getAll();
            for (int i=0; i < apartments.Count ; i++)
            {
                if (apartments[i] != null)
                {
                    appartmentClass = appartmentClassDao.getSingle(apartments[i].ClsID);
                    buildingModel = buildingDao.getSingle(apartments[i].BID);
                    apartmentComponents[i] = new ApartmentComponent(apartments[i], buildingModel, appartmentClass, appartmentClasses, buildingModels, customerModels);
                    apartmentComponents[i].Title = buildingModel.Location;
                    apartmentComponents[i].ClassName = appartmentClass.ClassName;
                    apartmentComponents[i].Description = "living and dining area, self-contained kitchen/pantry unit," +
                    "\na laundry area balcony, telephone connection, broadband Internet \nconnection and " +
                    "cable TV connection. \nA gymnasium, and a swimming pool common for all \noccupants are also available.";
                    apartmentComponents[i].MonthlyPrice = apartments[i].Monthly;
                    apartmentComponents[i].DepositPrice = apartments[i].IntDeposit;
                    apartmentComponents[i].BetRoomsNum = appartmentClass.NumOfBedRooms;
                    apartmentComponents[i].AttaBathNum = appartmentClass.NumOfAttachBath;
                    apartmentComponents[i].ComBathNum = appartmentClass.NumOfCommonBath;
                    apartmentComponents[i].ServantBathNum = appartmentClass.NumOfServantBath;
                    apartmentComponents[i].ServantRoomNum = appartmentClass.NumOfServantRooms;
                    apartmentComponents[i].ComBathNum = appartmentClass.NumOfCommonBath;
                    apartmentComponents[i].IsAvailable = apartments[i].IfAvailable == 1;
                    apartmentComponents[i].Image = "https://thumbs.dreamstime.com/b/apartment-building-modern-buildings-new-westminster-british-columbia-canada-40351928.jpg";

                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    flowLayoutPanel1.Controls.Add(apartmentComponents[i]);
                }
                
            }
        }
    }
}
