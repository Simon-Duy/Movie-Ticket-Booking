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
    public partial class CinemaUC : UserControl
    {

        BindingSource cinemaList = new BindingSource();
        public CinemaUC()
        {
            InitializeComponent();
            LoadCinema();
        }

        void LoadCinema()
        {
            dtgvCinema.DataSource = cinemaList;
            LoadCinemaList();
            AddCinemaBinding();
        }
        void LoadCinemaList()
        {
            cinemaList.DataSource = CinemaDAO.GetListCinema();
        }
        void AddCinemaBinding()
        {
            txtCinemaID.DataBindings.Add("Text", dtgvCinema.DataSource, "Mã phòng", true, DataSourceUpdateMode.Never);
            txtCinemaName.DataBindings.Add("Text", dtgvCinema.DataSource, "Tên phòng", true, DataSourceUpdateMode.Never);
            txtCinemaSeats.DataBindings.Add("Text", dtgvCinema.DataSource, "Số chỗ ngồi", true, DataSourceUpdateMode.Never);
            cbCinemaStatus.DataBindings.Add("Text", dtgvCinema.DataSource, "Tình trạng", true, DataSourceUpdateMode.Never);
            txtNumberOfRows.DataBindings.Add("Text", dtgvCinema.DataSource, "Số hàng ghế", true, DataSourceUpdateMode.Never);
            txtSeatsPerRow.DataBindings.Add("Text", dtgvCinema.DataSource, "Ghế mỗi hàng", true, DataSourceUpdateMode.Never);
            LoadScreenTypeIntoComboBox(cboCinemaScreenType);
        }
        void LoadScreenTypeIntoComboBox(ComboBox cbo)
        {
            cbo.DataSource = ScreenTypeDAO.GetListScreenType();
            cbo.DisplayMember = "Name";
            cbo.ValueMember = "ID";
        }

        void InsertCinema(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRow)
        {
            if (CinemaDAO.InsertCinema(id, name, idMH, seats, status, numberOfRows, seatsPerRow))
            {
                MessageBox.Show("Thêm phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm phòng chiếu thất bại");
            }
        }


        void UpdateCinema(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRow)
        {
            if (CinemaDAO.UpdateCinema(id, name, idMH, seats, status, numberOfRows, seatsPerRow))
            {
                MessageBox.Show("Sửa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Sửa phòng chiếu thất bại");
            }
        }

        void DeleteCinema(string id)
        {
            if (CinemaDAO.DeleteCinema(id))
            {
                MessageBox.Show("Xóa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Xóa phòng chiếu thất bại");
            }
        }

        static bool CheckSeat (int soghe, int hang, int tong)
        {
            //int a, b, c;
            //Int32.TryParse(soghe, out a);
            //Int32.TryParse(hang, out b);
            //Int32.TryParse(tong, out c);
            //int a = Int32.Parse(soghe);
            //int b = Int32.Parse(hang);
            //int c = Int32.Parse(tong);
            if (soghe*hang==tong)
            return true ;
           else
             return false ;
        }

        private void btnInsertCinema_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cinemaID = txtCinemaID.Text;
                string cinemaName = txtCinemaName.Text;
                string screenTypeID = cboCinemaScreenType.SelectedValue.ToString();
                int cinemaSeats = int.Parse(txtCinemaSeats.Text);
                int cinemaStatus = int.Parse(cbCinemaStatus.SelectedItem.ToString());
                int numberOfRows = int.Parse(txtNumberOfRows.Text);
                int seatsPerRows = int.Parse(txtSeatsPerRow.Text);
               
                if (CheckSeat(seatsPerRows,numberOfRows,cinemaSeats)==true)
                {
                    InsertCinema(cinemaID, cinemaName, screenTypeID, cinemaSeats, cinemaStatus, numberOfRows, seatsPerRows);
                    LoadCinemaList();
                }
                else
                {
                    MessageBox.Show("Số ghế mỗi hàng và số hàng không tương thích với Tổng số ghế");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCinema_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cinemaID = txtCinemaID.Text;
                DeleteCinema(cinemaID);
                LoadCinemaList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateCinema_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cinemaID = txtCinemaID.Text;
                string cinemaName = txtCinemaName.Text;
                string screenTypeID = cboCinemaScreenType.SelectedValue.ToString();
                int cinemaSeats = int.Parse(txtCinemaSeats.Text);
                int cinemaStatus = int.Parse(cbCinemaStatus.SelectedValue.ToString());
                int numberOfRows = int.Parse(txtNumberOfRows.Text);
                int seatsPerRows = int.Parse(txtSeatsPerRow.Text);
                if (CheckSeat(seatsPerRows, numberOfRows, cinemaSeats) == true)
                {
                    UpdateCinema(cinemaID, cinemaName, screenTypeID, cinemaSeats, cinemaStatus, numberOfRows, seatsPerRows);
                    LoadCinemaList();
                }
                else
                {
                    MessageBox.Show("Số ghế mỗi hàng và số hàng không tương thích với Tổng số ghế");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
