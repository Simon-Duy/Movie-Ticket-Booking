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
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        public frmDashBoard(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
        }

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        void ChangeAccount(int type)
        {
            if (loginAccount.Type == 2) btnManage.Enabled = false;
            lblAccountInfo.Text += "\t\t"+ LoginAccount.UserName;
        }

        private void btnChangePassWord_Click_1(object sender, EventArgs e)
        {
            frmAccountSettings frm = new frmAccountSettings(loginAccount);
            frm.ShowDialog();
            this.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminManage frm = new frmAdminManage();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSeller_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSeller frm = new frmSeller();
            frm.ShowDialog();
            this.Show();
        }

        private void guna2ControlBox_Exit_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
