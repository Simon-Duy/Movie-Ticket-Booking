﻿using CINEMA.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CINEMA.AdminUC
{
    public partial class AccountUC : UserControl
    {
        BindingSource accountList = new BindingSource();

        public AccountUC()
        {
            InitializeComponent();
            LoadAccount();
        }

        void LoadAccount()
        {
            dtgvAccount.DataSource = accountList;
            LoadAccountList();
            AddAccountBinding();
        }
        void LoadAccountList()
        {
            accountList.DataSource = AccountDAO.GetAccountList();
        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        void AddAccountBinding()
        {
            txtUsername.DataBindings.Add("Text", dtgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never);
            nudAccountType.DataBindings.Add("Value", dtgvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never);
            LoadStaffIntoComboBox(cboStaffID_Account);
        }
        void LoadStaffIntoComboBox(ComboBox cbo)
        {
            cbo.DataSource = StaffDAO.GetStaff();
            cbo.DisplayMember = "ID";
            cbo.ValueMember = "ID";
        }

        void ResetPassword(string username)
        {
            if (AccountDAO.ResetPassword(username))
            {
                MessageBox.Show("Reset mật khẩu thành công, mật khẩu mặc định : 1");
            }
            else
            {
                MessageBox.Show("Reset mật khẩu thất bại");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string staffID = (string)dtgvAccount.SelectedCells[0].OwningRow.Cells["Mã nhân viên"].Value;
            Staff staff = StaffDAO.GetStaffByID(staffID);//The staff that we're currently selecting

            if (staff == null)
                //The case that nothing on dtgv - no result after searched
                return;

            cboStaffID_Account.SelectedItem = staff;

            int index = -1;
            int i = 0;
            foreach (Staff item in cboStaffID_Account.Items)
            {
                if (item.ID == staff.ID)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cboStaffID_Account.SelectedIndex = index;
        }

        private void cboStaffID_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff staff = cboStaffID_Account.SelectedItem as Staff;
            if (staff == null)
                return;
            txtStaffName_Account.Text = staff.Name;
        }

        void InsertAccount(string username, int accountType, string idStaff)
        {
            if (AccountDAO.InsertAccount(username, accountType, idStaff))
            {
                MessageBox.Show("Thêm tài khoản thành công, mật khẩu mặc định : 1");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
        }

        void UpdateAccount(string username, int accountType)
        {
            if (AccountDAO.UpdateAccount(username, accountType))
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }
        }

        void DeleteAccount(string username)
        {
            if (AccountDAO.DeleteAccount(username))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            string staffName = txtSearchAccount.Text;
            accountList.DataSource = AccountDAO.SearchAccountByStaffName(staffName);
        }

        private void txtSearchAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchAccount.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        }

        private void btnInsertAccount_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                int accountType = (int)nudAccountType.Value;
                string staffID = cboStaffID_Account.SelectedValue.ToString();
                InsertAccount(username, accountType, staffID);
                LoadAccountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btnUpdateAccount_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                int accountType = (int)nudAccountType.Value;
                UpdateAccount(username, accountType);
                LoadAccountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteAccount_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                DeleteAccount(username);
                LoadAccountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void btnResetPass_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            ResetPassword(username);
            LoadAccountList();
        }
    }
}
