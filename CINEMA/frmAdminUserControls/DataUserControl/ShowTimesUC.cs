using CINEMA.DAO;
using CINEMA.DTO;
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
    public partial class ShowTimesUC : UserControl
    {
        BindingSource showtimeList = new BindingSource();
        public ShowTimesUC()
        {
            InitializeComponent();
            LoadShowtime();
        }

        void LoadShowtime()
        {
            dtgvShowtime.DataSource = showtimeList;
            LoadShowtimeList();
            LoadFormatMovieIntoComboBox();
            AddShowtimeBinding();
        }
        void LoadShowtimeList()
        {
            showtimeList.DataSource = ShowTimesDAO.GetListShowtime();
        }

        private void btnShowShowtime_Click(object sender, EventArgs e)
        {
            LoadShowtimeList();
        }

        void AddShowtimeBinding()
        {
            txtShowtimeID.DataBindings.Add("Text", dtgvShowtime.DataSource, "Mã lịch chiếu", true, DataSourceUpdateMode.Never);
            dtmShowtimeDate.DataBindings.Add("Value", dtgvShowtime.DataSource, "Thời gian chiếu", true, DataSourceUpdateMode.Never);
            dtmShowtimeTime.DataBindings.Add("Value", dtgvShowtime.DataSource, "Thời gian chiếu", true, DataSourceUpdateMode.Never);
            txtTicketPrice_Showtime.DataBindings.Add("Text", dtgvShowtime.DataSource, "Giá vé", true, DataSourceUpdateMode.Never);
        }
        void LoadFormatMovieIntoComboBox()
        {
            cboFormatID_Showtime.DataSource = FormatMovieDAO.GetFormatMovie();
            cboFormatID_Showtime.DisplayMember = "ID";
        }

        private void cboFormatID_Showtime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormatID_Showtime.SelectedIndex != -1)
            {
                FormatMovie formatMovieSelecting = (FormatMovie)cboFormatID_Showtime.SelectedItem;
                txtMovieName_Showtime.Text = formatMovieSelecting.MovieName;
                txtScreenTypeName_Showtime.Text = formatMovieSelecting.ScreenTypeName;

                cboCinemaID_Showtime.DataSource = null;
                ScreenType screenType = ScreenTypeDAO.GetScreenTypeByName(formatMovieSelecting.ScreenTypeName);
                cboCinemaID_Showtime.DataSource = CinemaDAO.GetCinemaByScreenTypeID(screenType.ID);
                cboCinemaID_Showtime.DisplayMember = "Name";
            }
        }

        private void txtShowtimeID_TextChanged(object sender, EventArgs e)
        {
            toolTipCinema.SetToolTip(cboCinemaID_Showtime, "Danh sách phòng chiếu hỗ trợ loại màn hình trên");
        }

        void InsertShowtime(string id, string cinemaID, string formatMovieID, DateTime time, float ticketPrice)
        {
            if (ShowTimesDAO.InsertShowtime(id, cinemaID, formatMovieID, time, ticketPrice))
            {
                MessageBox.Show("Thêm lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm lịch chiếu thất bại");
            }
        }


        void UpdateShowtime(string id, string cinemaID, string formatMovieID, DateTime time, float ticketPrice)
        {
            if (ShowTimesDAO.UpdateShowtime(id, cinemaID, formatMovieID, time, ticketPrice))
            {
                MessageBox.Show("Sửa lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Sửa lịch chiếu thất bại");
            }
        }


        void DeleteShowtime(string id)
        {
            if (ShowTimesDAO.DeleteShowtime(id))
            {
                MessageBox.Show("Xóa lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Xóa lịch chiếu thất bại");
            }
        }


        private void btnSearchShowtime_Click(object sender, EventArgs e)
        {
            string movieName = txtSearchShowtime.Text;
            showtimeList.DataSource = ShowTimesDAO.SearchShowtimeByMovieName(movieName);
        }

        private void txtSearchShowtime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchShowtime.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        }

        private void btnInsertShowtime_Click_1(object sender, EventArgs e)
        {
           
                string showtimeID = txtShowtimeID.Text;
                string cinemaID = ((Cinema)cboCinemaID_Showtime.SelectedItem).ID;
                string formatMovieID = ((FormatMovie)cboFormatID_Showtime.SelectedItem).ID;
                DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
                //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
                float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
                InsertShowtime(showtimeID, cinemaID, formatMovieID, time, ticketPrice);
                LoadShowtimeList();
          
        }

        private void btnUpdateShowtime_Click_1(object sender, EventArgs e)
        {
                string showtimeID = txtShowtimeID.Text;
                string cinemaID = ((Cinema)cboCinemaID_Showtime.SelectedItem).ID;
                string formatMovieID = ((FormatMovie)cboFormatID_Showtime.SelectedItem).ID;
                DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
                float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
                UpdateShowtime(showtimeID, cinemaID, formatMovieID, time, ticketPrice);
                LoadShowtimeList();
         
        }

        private void btnDeleteShowtime_Click_1(object sender, EventArgs e)
        {
            string showtimeID = txtShowtimeID.Text;
            DeleteShowtime(showtimeID);
            LoadShowtimeList();
        }
    }
}
