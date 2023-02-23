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
    public partial class MovieUC : UserControl
    {
        BindingSource movieList = new BindingSource();

        public MovieUC()
        {
            InitializeComponent();
            LoadMovie();
        }

        void LoadMovie()
        {
            dtgvMovie.DataSource = movieList;
            LoadMovieList();
            AddMovieBinding();
        }
        void LoadMovieList()
        {
            movieList.DataSource = MovieDAO.GetMovie();
        }

        void AddMovieBinding()
        {
            txtMovieID.DataBindings.Add("Text", dtgvMovie.DataSource, "Mã phim", true, DataSourceUpdateMode.Never);
            txtMovieName.DataBindings.Add("Text", dtgvMovie.DataSource, "Tên phim", true, DataSourceUpdateMode.Never);
            txtMovieDesc.DataBindings.Add("Text", dtgvMovie.DataSource, "Mô tả", true, DataSourceUpdateMode.Never);
            txtMovieLength.DataBindings.Add("Text", dtgvMovie.DataSource, "Thời lượng", true, DataSourceUpdateMode.Never);
            dtmMovieStart.DataBindings.Add("Value", dtgvMovie.DataSource, "Ngày khởi chiếu", true, DataSourceUpdateMode.Never);
            dtmMovieEnd.DataBindings.Add("Value", dtgvMovie.DataSource, "Ngày kết thúc", true, DataSourceUpdateMode.Never);
            txtMovieProductor.DataBindings.Add("Text", dtgvMovie.DataSource, "Sản xuất", true, DataSourceUpdateMode.Never);
            txtMovieDirector.DataBindings.Add("Text", dtgvMovie.DataSource, "Đạo diễn", true, DataSourceUpdateMode.Never);
            txtMovieYear.DataBindings.Add("Text", dtgvMovie.DataSource, "Năm SX", true, DataSourceUpdateMode.Never);
            LoadGenreIntoCheckedList(clbMovieGenre);
        }
        void LoadGenreIntoCheckedList(CheckedListBox checkedList)
        {
            List<Genre> genreList = GenreDAO.GetListGenre();
            checkedList.DataSource = genreList;
            checkedList.DisplayMember = "Name";
        }

        private void txtMovieID_TextChanged(object sender, EventArgs e)
        {
            picFilm.Image = null;
            for (int i = 0; i < clbMovieGenre.Items.Count; i++)
            {
                clbMovieGenre.SetItemChecked(i, false);
                //Uncheck all CheckBox first
            }

            List<Genre> listGenreOfMovie = MovieByGenreDAO.GetListGenreByMovieID(txtMovieID.Text);
            for (int i = 0; i < clbMovieGenre.Items.Count; i++)
            {
                Genre genre = (Genre)clbMovieGenre.Items[i];
                foreach (Genre item in listGenreOfMovie)
                {
                    if (genre.ID == item.ID)
                    {
                        clbMovieGenre.SetItemChecked(i, true);
                        break;
                    }
                }
            }

            Movie movie = MovieDAO.GetMovieByID(txtMovieID.Text);

            if (movie == null)
                return;

            if (movie.Poster != null)
                picFilm.Image = MovieDAO.byteArrayToImage(movie.Poster);
        }


        void InsertMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            if (MovieDAO.InsertMovie(id, name, desc, length, startDate, endDate, productor, director, year, image))
            {
                MessageBox.Show("Thêm phim thành công");
            }
            else
            {
                MessageBox.Show("Thêm phim thất bại");
            }
        }

        void InsertMovie_Genre(string movieID, CheckedListBox checkedListBox)
        //Insert into table 'PhanLoaiPhim'
        {
            List<Genre> checkedGenreList = new List<Genre>();
            foreach (Genre checkedItem in checkedListBox.CheckedItems)
            {
                checkedGenreList.Add(checkedItem);
            }
            MovieByGenreDAO.InsertMovie_Genre(movieID, checkedGenreList);
        }


        void UpdateMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            if (MovieDAO.UpdateMovie(id, name, desc, length, startDate, endDate, productor, director, year, image))
            {
                MessageBox.Show("Sửa phim thành công");
            }
            else
            {
                MessageBox.Show("Sửa phim thất bại");
            }
        }

        void UpdateMovie_Genre(string movieID, CheckedListBox checkedListBox)
        {
            List<Genre> checkedGenreList = new List<Genre>();
            foreach (Genre checkedItem in checkedListBox.CheckedItems)
            {
                checkedGenreList.Add(checkedItem);
            }
            MovieByGenreDAO.UpdateMovie_Genre(movieID, checkedGenreList);
        }

        void DeleteMovie(string id)
        {
            if (MovieDAO.DeleteMovie(id))
            {
                MessageBox.Show("Xóa phim thành công");
            }
            else
            {
                MessageBox.Show("Xóa phim thất bại");
            }
        }


        private void btnAddMovie_Click_1(object sender, EventArgs e)
        {
            try
            {
                string movieID = txtMovieID.Text;
                string movieName = txtMovieName.Text;
                string movieDesc = txtMovieDesc.Text;
                float movieLength = float.Parse(txtMovieLength.Text);
                DateTime startDate = dtmMovieStart.Value;
                DateTime endDate = dtmMovieEnd.Value;
                string productor = txtMovieProductor.Text;
                string director = txtMovieDirector.Text;
                int year = int.Parse(txtMovieYear.Text);
                if (picFilm.Image == null)
                {
                    MessageBox.Show("Mời bạn thêm hình ảnh cho phim trước");
                    return;
                }
                InsertMovie(movieID, movieName, movieDesc, movieLength, startDate, endDate, productor, director, year, MovieDAO.imageToByteArray(picFilm.Image));
                InsertMovie_Genre(movieID, clbMovieGenre);
                LoadMovieList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUpdateMovie_Click_1(object sender, EventArgs e)
        {
            try
            {
                string movieID = txtMovieID.Text;
                string movieName = txtMovieName.Text;
                string movieDesc = txtMovieDesc.Text;
                float movieLength = float.Parse(txtMovieLength.Text);
                DateTime startDate = dtmMovieStart.Value;
                DateTime endDate = dtmMovieEnd.Value;
                string productor = txtMovieProductor.Text;
                string director = txtMovieDirector.Text;
                int year = int.Parse(txtMovieYear.Text);
                if (picFilm.Image == null)
                {
                    MessageBox.Show("Mời bạn thêm hình ảnh cho phim trước");
                    return;
                }
                UpdateMovie(movieID, movieName, movieDesc, movieLength, startDate, endDate, productor, director, year, MovieDAO.imageToByteArray(picFilm.Image));
                UpdateMovie_Genre(movieID, clbMovieGenre);
                LoadMovieList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDeleteMovie_Click_1(object sender, EventArgs e)
        {
            try
            {
                string movieID = txtMovieID.Text;
                DeleteMovie(movieID);
                LoadMovieList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUpLoadPictureFilm_Click_1(object sender, EventArgs e)
        {
            try
            {
                string filePathImage = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePathImage = openFile.FileName;
                    picFilm.Image = Image.FromFile(filePathImage.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
