using e_apartments_app.db.dao;
using e_apartments_app.db.Model;

namespace e_apartments_app.View
{
    public partial class EditApartmentView : Form
    {
        ApartmentModel apartmentModel;
        BuildingModel buildingModel;
        AppartmentClassModel appartmentClassModel;
        AppartmentClassModel[] appartmentClasses;
        BuildingModel[] buildingModels;

        public EditApartmentView(ApartmentModel apartmentModel, BuildingModel buildingModel, 
            AppartmentClassModel appartmentClassModel, AppartmentClassModel[] appartmentClasses,
            BuildingModel[] buildingModels)
        {
            InitializeComponent();
            this.buildingModel = buildingModel;
            this.apartmentModel = apartmentModel;
            this.appartmentClassModel = appartmentClassModel;
            this.appartmentClasses = appartmentClasses;
            this.buildingModels = buildingModels;
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
            AppartmentClassDao appartmentClassDao = new AppartmentClassDao();
            classLabel.Text = "Current Class name: " + appartmentClassModel.ClassName;
            if (classBox.Items.Count == 0)
            {
                for (int i = 0; i < appartmentClasses.Length - 1; i++)
                {
                    classBox.Items.Add(appartmentClasses[i].ClassName);
                }
            }
            buildingLabel.Text = "Current Building: " + buildingModel.BID;

            BuildingDao buildingDao = new BuildingDao();
            if (buildingBox.Items.Count == 0)
            {
                for (int i = 0; i < buildingModels.Length -1; i++)
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
        }

        private void EditApartmentView_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
