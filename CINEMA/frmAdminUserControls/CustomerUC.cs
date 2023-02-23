using CINEMA.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINEMA.AdminUC
{

    public partial class CustomerUC : UserControl
    {

        BindingSource customerList = new BindingSource();
        public CustomerUC()
        {
            InitializeComponent();
            LoadCustomer();

        }

        void LoadCustomer()
        {
            dtgvCustomer.DataSource = customerList;
            LoadCustomerList();
            AddCustomerBinding();
        }

        void AddCustomerBinding()
        {
            txtCusID.DataBindings.Add("Text", dtgvCustomer.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never);
            txtCusName.DataBindings.Add("Text", dtgvCustomer.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            txtCusBirth.DataBindings.Add("Text", dtgvCustomer.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtCusAddress.DataBindings.Add("Text", dtgvCustomer.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtCusPhone.DataBindings.Add("Text", dtgvCustomer.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtCusEmail.DataBindings.Add("Text", dtgvCustomer.DataSource, "Email", true, DataSourceUpdateMode.Never);
            txtCusINumber.DataBindings.Add("Text", dtgvCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            nudPoint.DataBindings.Add("Value", dtgvCustomer.DataSource, "Điểm tích lũy", true, DataSourceUpdateMode.Never);
        }

        void LoadCustomerList()
        {
            customerList.DataSource = CustomerDAO.GetListCustomer();
        }

        void InsertCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, string email, int cmnd)
        {
            if (CustomerDAO.InsertCustomer(id, hoTen, ngaySinh, diaChi, sdt, email, cmnd))
            {
                MessageBox.Show("Thêm khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
        }


        void UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, string email, int cmnd, int point)
        {
            if (CustomerDAO.UpdateCustomer(id, hoTen, ngaySinh, diaChi, sdt, email, cmnd, point))
            {
                MessageBox.Show("Sửa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại");
            }
        }


        void DeleteCustomer(string id)
        {
            if (CustomerDAO.DeleteCustomer(id))
            {
                MessageBox.Show("Xóa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
            }
        }


        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            string cusName = txtSearchCus.Text;
            customerList.DataSource = CustomerDAO.SearchCustomerByName(cusName);
        }

        private void txtSearchCus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchCus.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        }

        bool ValidateEmail(string email)
        {

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;

        }

        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cusID = txtCusID.Text;
                string cusName = txtCusName.Text;
                DateTime cusBirth = DateTime.Parse(txtCusBirth.Text);
                string cusAddress = txtCusAddress.Text;
                string cusPhone = txtCusPhone.Text;
                string cusEmail = txtCusEmail.Text;
                int cusINumber = Int32.Parse(txtCusINumber.Text);
                if (ValidateEmail(cusEmail))
                {
                    InsertCustomer(cusID, cusName, cusBirth, cusAddress, cusPhone, cusEmail, cusINumber);
                }
                else
                {
                    MessageBox.Show("Email không hợp lệ!");
                    txtCusEmail.Clear();
                }

                LoadCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string cusID = txtCusID.Text;
                string cusName = txtCusName.Text;
                DateTime cusBirth = DateTime.Parse(txtCusBirth.Text);
                string cusAddress = txtCusAddress.Text;
                string cusPhone = txtCusPhone.Text;
                string cusEmail = txtCusEmail.Text;
                int cusINumber = Int32.Parse(txtCusINumber.Text);
                int cusPoint = (int)nudPoint.Value;
                UpdateCustomer(cusID, cusName, cusBirth, cusAddress, cusPhone, cusEmail, cusINumber, cusPoint);
                LoadCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteCustomer_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cusID = txtCusID.Text;
                DeleteCustomer(cusID);
                LoadCustomerList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
