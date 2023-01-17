using e_apartments_app.db.dao;
using e_apartments_app.db.Model;
using System.ComponentModel;
using System.Net;

namespace e_apartments_app.View
{
    public partial class ApartmentComponent : UserControl
    {
        ApartmentModel apartmentModel;
        BuildingModel buildingModel;
        AppartmentClassModel appartmentClassModel;
        List<AppartmentClassModel> appartmentClasses;
        List<BuildingModel> buildingModels;
        List<CustomerModel> customerModels;

        public ApartmentComponent(ApartmentModel apartmentModel, BuildingModel buildingModel,
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

        #region Properties

        private string title;
        private string className;
        private string image;
        private int betRoomsNum;
        private int attaBathNum;
        private int comBathNum;
        private int servantBathNum;
        private int servantRoomNum;
        private string description;
        private double monthlyPrice;
        private double depositPrice;
        private bool isAvailable;

        [Category("Custom Props")]
        public string Title
        {
            get { return title; }
            set { title = value; titleLabel.Text = "Apartment in " + value; }
        }
        [Category("Custom Props")]
        public string ClassName { get => className; set { className = value; classLabel.Text = value; } }

        [Category("Custom Props")]
        public string Image { get => image; set { 
                image = value;
                var request = WebRequest.Create(image);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    picBox.Image = Bitmap.FromStream(stream);
                }
            }
        }

        [Category("Custom Props")]
        public int BetRoomsNum { get => betRoomsNum; set { betRoomsNum = value; bedLabel.Text =  value + " bed-room"; } }

        [Category("Custom Props")]
        public int AttaBathNum { get => attaBathNum; set { attaBathNum = value; attachBathLabel.Text = value + " attached bathrooms"; } }

        [Category("Custom Props")]
        public int ComBathNum { get => comBathNum; set { comBathNum = value; coBathLabel.Text = value + " common bathroom"; } }

        [Category("Custom Props")]
        public bool IsAvailable { get => isAvailable; set { isAvailable = value; if(value)
                {
                    isAvailableLabel.Text = "Available";
                    isAvailableLabel.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
                }
                else
                {
                    isAvailableLabel.Text = "Unavailable";
                    isAvailableLabel.ForeColor = System.Drawing.Color.Red;
                }; } }

        [Category("Custom Props")]
        public string Description { get => description; set { description = value; commonText.Text = value; } }

        [Category("Custom Props")]
        public double MonthlyPrice { get => monthlyPrice; set { monthlyPrice = value; monthlyLabel.Text = "Rs " + value.ToString() + "/Month"; } }

        [Category("Custom Props")]
        public double DepositPrice { get => depositPrice; set { depositPrice = value; depositLabel.Text = "Deposit Price: Rs " + value.ToString(); } }

        [Category("Custom Props")]
        public int ServantBathNum { get => servantBathNum; set {
                servantBathNum = value;
                servantBathRoom.Text = value + " Servant Bathrooms";
            }
        }

        [Category("Custom Props")]
        public int ServantRoomNum { get => servantRoomNum; set {
                servantRoomNum = value;
                servantRoom.Text = value + " Servant Room";
            } }

        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            EditApartmentView editView = new EditApartmentView(apartmentModel, buildingModel, appartmentClassModel, appartmentClasses,
                buildingModels, customerModels);
            editView.Show();
        }

        private void apartmentDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApartmentComponent_Load(object sender, EventArgs e)
        {

        }
    }
}