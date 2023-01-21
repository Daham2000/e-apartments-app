﻿using e_apartments_app.db.dao;
using e_apartments_app.db.Model;
using e_apartments_app.ui;
using Microsoft.VisualBasic;

namespace e_apartments_app.View
{
    public partial class AdminDashboard : Form
    {
        ApartmentDao apartmentDao = new ApartmentDao();
        AppartmentClassDao appartmentClassDao = new AppartmentClassDao();
        AgreementDao agreementDao= new AgreementDao();
        ExtentionRequestsDao extentionRequestsDao = new ExtentionRequestsDao();
        CustomerDao customerDao = new CustomerDao();
        BuildingDao buildingDao = new BuildingDao();
        List<AppartmentClassModel> appartmentClasses;
        List<CustomerModel> customerModels;
        List<BuildingModel> buildingModels;
        List<AgreementModel> agreementModels = new List<AgreementModel>();
        List<ApartmentModel> appartmentsAvailable = new List<ApartmentModel>();
        List<ApartmentModel> apartments = new List<ApartmentModel>();
        List<ExtentionRequestsModel> requestList = new List<ExtentionRequestsModel>();
        List<DependentsModel> dependentsModels = new List<DependentsModel>();

        public AdminDashboard()
        {
            InitializeComponent();
            appartmentClasses = appartmentClassDao.GetAll();
            customerModels = customerDao.GetAll();
            buildingModels = buildingDao.GetAll();
            agreementModels = agreementDao.GetAll();
            populateApartments();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void populateApartments()
        {

            AppartmentClassModel appartmentClass = new AppartmentClassModel();
            BuildingModel buildingModel = new BuildingModel();
            if(apartments.Count == 0)
            {
                apartments = apartmentDao.GetAll();
            }
            ApartmentComponent[] apartmentComponents = new ApartmentComponent[apartments.Count];

            for (int i=0; i < apartments.Count ; i++)
            {
                if (apartments[i] != null)
                {
                    appartmentClass = appartmentClasses.First(s => s.ClsID == apartments[i].ClsID);
                    buildingModel = buildingModels.First(s => s.BID == apartments[i].BID);

                    //appartmentClass = appartmentClassDao.getSingle(apartments[i].ClsID);
                    //buildingModel = buildingDao.getSingle(apartments[i].BID);
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

                    if (apartmentListFlow.Controls.Count < 0)
                    {
                        apartmentListFlow.Controls.Clear();
                    }
                    apartmentListFlow.Controls.Add(apartmentComponents[i]);
                }
                
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if(titleLabel.Text == "Manage Customer Details")
            {
                apartmentListFlow.Controls.Clear();
                dependentsModels = customerDao.GetAllDependents();
                customerModels = customerDao.GetAll();
                loadCustomerDetails();
            }
            if(titleLabel.Text == "Lease Details")
            {
                AddLeaseView addLeaseView = new AddLeaseView(appartmentsAvailable, customerModels);
                addLeaseView.Show();
            }
            else
            {
                apartmentListFlow.Controls.Clear();
                populateApartments();
            }
        }

        private void leaseBtn_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Lease Details";
            refreshBtn.Text = "Add Lease";
            appartmentsAvailable = apartmentDao.GetAllAvailable();
            apartmentListFlow.Controls.Clear();
            if (agreementModels.Count == 0)
            {
                agreementModels = agreementDao.GetAll();
            }
            AgreementCompo[] agreementCompos = new AgreementCompo[agreementModels.Count];
            for (int i = 0; i < agreementModels.Count; i++)
            {
                if (agreementModels[i] != null)
                {
                    var customerModel = customerModels.First(s => s.CID == agreementModels[i].CID);
                    agreementCompos[i] = new AgreementCompo(agreementModels[i], customerModel, new ExtentionRequestsModel(), apartments, customerModels);
                    apartmentListFlow.Controls.Add(agreementCompos[i]);
                }
            }
        }

        private void apartmentBtn_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Apartment details";
            refreshBtn.Text = "Refresh";
            apartmentListFlow.Controls.Clear();
            refreshBtn.Show();
            populateApartments();
        }

        private void editClassBtn_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Edit Apartment Class Details";
            refreshBtn.Hide();
            apartmentListFlow.Controls.Clear();

            if (appartmentClasses.Count == 0)
            {
                appartmentClasses = appartmentClassDao.GetAll();
            }
            EditClassView[] editClassViews = new EditClassView[appartmentClasses.Count];
            for (int i = 0; i < appartmentClasses.Count; i++)
            {
                if (appartmentClasses[i] != null)
                {
                    var customerModel = customerModels.First(s => s.CID == agreementModels[i].CID);
                    editClassViews[i] = new EditClassView(appartmentClasses[i]);
                    apartmentListFlow.Controls.Add(editClassViews[i]);
                }
            }
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            loadCustomerDetails();
        }

        private void loadCustomerDetails()
        {
            titleLabel.Text = "Manage Customer Details";
            refreshBtn.Show();
            refreshBtn.Text = "Refresh";
            apartmentListFlow.Controls.Clear();
            if (dependentsModels.Count == 0)
            {
                dependentsModels = customerDao.GetAllDependents();
            }

            CustomerCard[] customerCards = new CustomerCard[customerModels.Count];
            for (int i = 0; i < customerModels.Count; i++)
            {
                if (customerModels[i] != null)
                {
                    List<DependentsModel> dependantList = dependentsModels.Where(s => s.CID == customerModels[i].CID).ToList();
                    customerCards[i] = new CustomerCard(customerModels[i], dependantList);
                    apartmentListFlow.Controls.Add(customerCards[i]);
                }
            }
        }

        private void requestViewBtn_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Lease Extention Requests";
            refreshBtn.Hide();
            apartmentListFlow.Controls.Clear();
            try {
                if (requestList.Count == 0)
                {
                    requestList = extentionRequestsDao.GetAll();
                }
                ExtentionRequestView[] extentionRequestViews = new ExtentionRequestView[requestList.Count];
                for (int i = 0; i < requestList.Count; i++)
                {
                    if (requestList[i] != null)
                    {
                        var agreementModel = agreementModels.First(s => s.AgreeID == requestList[i].AgreeID);
                        var customerModel = customerModels.First(s => s.CID == agreementModel.CID);
                        extentionRequestViews[i] = new ExtentionRequestView(agreementModel, customerModel, new ExtentionRequestsModel(), apartments, customerModels, requestList[i]);
                        apartmentListFlow.Controls.Add(extentionRequestViews[i]);
                    }
                }
            } catch (Exception ee)
            {
                MessageBox.Show("Error occured...  " + ee);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Admin Reports";
            refreshBtn.Hide();
            apartmentListFlow.Controls.Clear();
        }
    }
}
