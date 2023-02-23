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

namespace CINEMA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmConnectData frm = new frmConnectData();
            frm.ShowDialog();
        }

        private int Login(string userName, string passWord)
        {
            return AccountDAO.Login(userName, passWord);
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

  
           
        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int result = Login(username, password);
            if (result == 1)
            {
                Account loginaccount = AccountDAO.GetAccountByUserName(username);
                frmDashBoard frm = new frmDashBoard(loginaccount);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else if (result == 0)
            {
                MessageBox.Show("sai tên tài khoản hoặc mật khẩu!!!!", "thông báo");
            }
            else
            {
                MessageBox.Show("kết nối thất bại", "thông báo");
            }
            btnLogin.Enabled = true;
        }

        private void guna2ControlBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDashBoard frm = new frmDashBoard();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
    }
