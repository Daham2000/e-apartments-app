using e_apartments_app.db.dao;
using e_apartments_app.db.Model;
using System.Net;

namespace e_apartments_app.View
{
    public partial class EditApartmentView : Form
    {
        ApartmentModel apartmentModel;
        BuildingModel buildingModel;
        AppartmentClassModel appartmentClassModel;
        List<AppartmentClassModel> appartmentClasses;
        List<BuildingModel> buildingModels;
        List<CustomerModel> customerModels;

        public EditApartmentView(ApartmentModel apartmentModel, BuildingModel buildingModel, 
            AppartmentClassModel appartmentClassModel, List<AppartmentClassModel> appartmentClasses,
            List<BuildingModel> buildingModels, List<CustomerModel> customerModels)
        {
            InitializeComponent();
            this.buildingModel = buildingModel;
            this.apartmentModel = apartmentModel;
            this.appartmentClassModel = appartmentClassModel;
            this.appartmentClasses = appartmentClasses;
            this.buildingModels = buildingModels;
            this.customerModels = customerModels;
        }

        private void loadData()
        {

            aIDLabel.Text = "Apartment ID: " + apartmentModel.AID;
            locationLa.Text = buildingModel.Location;
            if (apartmentModel.IfAvailable == 1)
            {
                statusBox.Text = "Available";
            }
            else
            {
                statusBox.Text = "Unavailable";
            }
            reasonLabel.Text = apartmentModel.UnavailableReason;
            floorLabel.Text = apartmentModel.FloorNum.ToString();
            classLabel.Text = "Current Class name: " + appartmentClassModel.ClassName;
            if (classBox.Items.Count == 0)
            {
                for (int i = 0; i < appartmentClasses.Count; i++)
                {
                    classBox.Items.Add(appartmentClasses[i].ClassName);
                }
            }
            buildingLabel.Text = "Current Building: " + buildingModel.BID + ": " + buildingModel.Location;

            if (buildingBox.Items.Count == 0)
            {
                for (int i = 0; i < buildingModels.Count; i++)
                {
                    buildingBox.Items.Add(buildingModels[i].BID);
                }
            }

            if (apartmentModel.CurrentOccupant == "")
            {
                occupantLabel.Text = "No Occupant: Available Apartment";
            }
            else
            {
                occupantLabel.Text = "Current Occupant: " + apartmentModel.CurrentOccupant;
            }
            if (occupantBox.Items.Count == 0)
            {
                for (int i = 0; i < customerModels.Count; i++)
                {
                    occupantBox.Items.Add(customerModels[i].Name);
                }
            }

            depositPrice.Text = apartmentModel.IntDeposit.ToString();
            monthlyPrice.Text = apartmentModel.Monthly.ToString();
        }

        private void EditApartmentView_Load(object sender, EventArgs e)
        {
            loadData();
            var request = WebRequest.Create("https://thumbs.dreamstime.com/b/apartment-building-modern-buildings-new-westminster-british-columbia-canada-40351928.jpg");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                imgBox.Image = Bitmap.FromStream(stream);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try {
                ApartmentDao apartmentDao = new ApartmentDao();
                apartmentModel.Monthly = float.Parse(monthlyPrice.Text);
                if (statusBox.Text == "Available")
                {
                    apartmentModel.IfAvailable = 1;
                }
                else
                {
                    apartmentModel.IfAvailable = 0;
                }
                apartmentModel.FloorNum = int.Parse(floorLabel.Text);
                var classModelSele = appartmentClasses.First(s => s.ClassName == classBox.Text);
                apartmentModel.ClsID = classModelSele.ClsID;
                apartmentModel.BID = buildingBox.Text;
                apartmentModel.CurrentOccupant = occupantBox.Text;
                apartmentModel.UnavailableReason = reasonLabel.Text;
                apartmentModel.IntDeposit = float.Parse(depositPrice.Text);
                apartmentModel.Monthly = float.Parse(monthlyPrice.Text);

                apartmentDao.update(apartmentModel.AID, apartmentModel);
                MessageBox.Show("Date Updated Sucess...");
            } catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            
        }

        private void imgBox_Click(object sender, EventArgs e)
        {

        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
