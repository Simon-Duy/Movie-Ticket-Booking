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
    public partial class FormatMovieUC : UserControl
    {
        BindingSource formatList = new BindingSource();
        public FormatMovieUC()
        {
            InitializeComponent();
            LoadFormatMovie();
        }

        void LoadFormatMovie()
        {
            dtgvFormat.DataSource = formatList;
            LoadFormatMovieList();
            LoadMovieIDIntoCombobox(cboFormat_MovieID);
            LoadScreenIDIntoCombobox(cboFormat_ScreenID);
            AddFormatBinding();
        }

        void LoadScreenIDIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = ScreenTypeDAO.GetListScreenType();
            comboBox.DisplayMember = "ID";
            comboBox.ValueMember = "ID";
        }

        void LoadMovieIDIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = MovieDAO.GetListMovie();
            comboBox.DisplayMember = "ID";
            comboBox.ValueMember = "ID";
        }

        void LoadFormatMovieList()
        {
            formatList.DataSource = FormatMovieDAO.GetListFormatMovie();
        }

        void AddFormatBinding()
        {
            txtFormatID.DataBindings.Add("Text", dtgvFormat.DataSource, "Mã định dạng", true, DataSourceUpdateMode.Never);
        }

        void InsertFormat(string id, string idMovie, string idScreen)
        {
            if (FormatMovieDAO.InsertFormatMovie(id, idMovie, idScreen))
            {
                MessageBox.Show("Thêm định dạng thành công");
            }
            else
            {
                MessageBox.Show("Thêm định dạng thất bại");
            }
        }

        private void cboFormat_ScreenID_SelectedValueChanged(object sender, EventArgs e)
        {
            ScreenType screenTypeSelected = cboFormat_ScreenID.SelectedItem as ScreenType;
            txtFormat_ScreenName.Text = screenTypeSelected.Name;
        }

        private void txtFormatID_TextChanged(object sender, EventArgs e)
        {
            string movieID = (string)dtgvFormat.SelectedCells[0].OwningRow.Cells["Mã phim"].Value;
            Movie movieSelecting = MovieDAO.GetMovieByID(movieID);
            //This is the Movie that we're currently selecting in dtgv

            if (movieSelecting == null)
                return;

            //cboFormat_MovieID.SelectedItem = movieSelecting;

            int indexMovie = -1;
            int iMovie = 0;
            foreach (Movie item in cboFormat_MovieID.Items)
            {
                if (item.Name == movieSelecting.Name)
                {
                    indexMovie = iMovie;
                    break;
                }
                iMovie++;
            }
            cboFormat_MovieID.SelectedIndex = indexMovie;


            string screenName = (string)dtgvFormat.SelectedCells[0].OwningRow.Cells["Tên MH"].Value;
            ScreenType screenTypeSelecting = ScreenTypeDAO.GetScreenTypeByName(screenName);
            //This is the ScreenType that we're currently selecting in dtgv

            if (screenTypeSelecting == null)
                return;

            //cboFormat_ScreenID.SelectedItem = screenTypeSelecting;

            int indexScreen = -1;
            int iScreen = 0;
            foreach (ScreenType item in cboFormat_ScreenID.Items)
            {
                if (item.Name == screenTypeSelecting.Name)
                {
                    indexScreen = iScreen;
                    break;
                }
                iScreen++;
            }
            cboFormat_ScreenID.SelectedIndex = indexScreen;
        }

        private void btnShowFormat_Click(object sender, EventArgs e)
        {
            LoadFormatMovieList();
        }

        void UpdateFormat(string id, string idMovie, string idScreen)
        {
            if (FormatMovieDAO.UpdateFormatMovie(id, idMovie, idScreen))
            {
                MessageBox.Show("Sửa định dạng thành công");
            }
            else
            {
                MessageBox.Show("Sửa định dạng thất bại");
            }
        }


        void DeleteFormat(string id)
        {
            if (FormatMovieDAO.DeleteFormatMovie(id))
            {
                MessageBox.Show("Xóa định dạng thành công");
            }
            else
            {
                MessageBox.Show("Xóa định dạng thất bại");
            }
        }


        private void cboFormat_MovieID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie movieSelected = cboFormat_MovieID.SelectedItem as Movie;
            txtFormat_MovieName.Text = movieSelected.Name;
        }

        private void btnInsertFormat_Click_1(object sender, EventArgs e)
        {
            try
            {
                string formatID = txtFormatID.Text;
                string movieID = cboFormat_MovieID.SelectedValue.ToString();
                string screenID = cboFormat_ScreenID.SelectedValue.ToString();
                InsertFormat(formatID, movieID, screenID);
                LoadFormatMovieList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateFormat_Click_1(object sender, EventArgs e)
        {
            try
            {
                string formatID = txtFormatID.Text;
                string movieID = cboFormat_MovieID.SelectedValue.ToString();
                string screenID = cboFormat_ScreenID.SelectedValue.ToString();
                UpdateFormat(formatID, movieID, screenID);
                LoadFormatMovieList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteFormat_Click_1(object sender, EventArgs e)
        {
            try
            {
                string formatID = txtFormatID.Text;
                DeleteFormat(formatID);
                LoadFormatMovieList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
