using e_apartments_app.db.dao;
using e_apartments_app.db.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_apartments_app.View
{
    public partial class EditClassView : UserControl
    {
        AppartmentClassModel appartmentClassModel;
        public EditClassView(AppartmentClassModel appartmentClassModel)
        {
            InitializeComponent();
            this.appartmentClassModel = appartmentClassModel;
            name.Text = appartmentClassModel.ClassName;
            bedRooms.Text = appartmentClassModel.NumOfBedRooms.ToString();
            commonBath.Text = appartmentClassModel.NumOfCommonBath.ToString();
            attachBathNum.Text = appartmentClassModel.NumOfAttachBath.ToString();
            servantRoomNum.Text = appartmentClassModel.NumOfServantRooms.ToString();
            servantBathNum.Text = appartmentClassModel.NumOfServantBath.ToString();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            appartmentClassModel.ClassName = name.Text;
            appartmentClassModel.NumOfBedRooms = int.Parse(bedRooms.Text);
            appartmentClassModel.NumOfAttachBath = int.Parse(attachBathNum.Text);
            appartmentClassModel.NumOfServantRooms = int.Parse(servantRoomNum.Text);
            appartmentClassModel.NumOfServantBath = int.Parse(servantBathNum.Text);
            appartmentClassModel.NumOfCommonBath = int.Parse(commonBath.Text);
            AppartmentClassDao classDao= new AppartmentClassDao();
            classDao.Update(appartmentClassModel.ClsID, appartmentClassModel);
        }
    }
}
