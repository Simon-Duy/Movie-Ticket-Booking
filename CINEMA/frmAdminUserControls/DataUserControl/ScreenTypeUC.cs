using CINEMA.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINEMA.frmAdminUserControls.DataUserControl
{
    public partial class ScreenTypeUC : UserControl
    {
        BindingSource screenTypeList = new BindingSource();

        public ScreenTypeUC()
        {
            InitializeComponent();
            LoadScreenType();
        }

        void LoadScreenType()
        {
            dtgvScreenType.DataSource = screenTypeList;
            LoadScreenTypeList();
            AddScreenTypeBinding();
        }
        void LoadScreenTypeList()
        {
            screenTypeList.DataSource = ScreenTypeDAO.GetScreenType();
        }
        void AddScreenTypeBinding()
        {
            txtScreenTypeID.DataBindings.Add("Text", dtgvScreenType.DataSource, "Mã loại màn hình", true, DataSourceUpdateMode.Never);
            txtScreenTypeName.DataBindings.Add("Text", dtgvScreenType.DataSource, "Tên màn hình", true, DataSourceUpdateMode.Never);
        }

        void InsertScreenType(string id, string name)
        {
            if (ScreenTypeDAO.InsertScreenType(id, name))
            {
                MessageBox.Show("Thêm loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Thêm loại màn hình thất bại");
            }
        }


        void UpdateScreenType(string id, string name)
        {
            if (ScreenTypeDAO.UpdateScreenType(id, name))
            {
                MessageBox.Show("Sửa loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Sửa loại màn hình thất bại");
            }
        }


        void DeleteScreenType(string id)
        {
            if (ScreenTypeDAO.DeleteScreenType(id))
            {
                MessageBox.Show("Xóa loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Xóa loại màn hình thất bại");
            }
        }


        private void btnInsertScreenType_Click_1(object sender, EventArgs e)
        {
            try
            {
                string screenTypeID = txtScreenTypeID.Text;
                string screenTypeName = txtScreenTypeName.Text;
                InsertScreenType(screenTypeID, screenTypeName);
                LoadScreenTypeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUpdateScreenType_Click_1(object sender, EventArgs e)
        {
            try
            {
                string screenTypeID = txtScreenTypeID.Text;
                string screenTypeName = txtScreenTypeName.Text;
                UpdateScreenType(screenTypeID, screenTypeName);
                LoadScreenTypeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void btnDeleteScreenType_Click_1(object sender, EventArgs e)
        {
            try
            {
                string screenTypeID = txtScreenTypeID.Text;
                DeleteScreenType(screenTypeID);
                LoadScreenTypeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
