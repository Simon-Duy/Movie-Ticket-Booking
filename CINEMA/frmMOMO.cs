using CINEMA.DAO;
using CINEMA.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINEMA
{
    public partial class frmMOMO : Form
    {
        public frmMOMO()
        {
            InitializeComponent();
        }
        public List<Ticket> selectedSeat = new List<Ticket>();
        public Customer customer;
        public string emailcustomer, movie, showtime;
        private void button1_Click(object sender, EventArgs e)
        {
            int ret = 0;
            if (!(customer is null))
            {
                foreach (Ticket ticket in selectedSeat)
                {
                    ret += TicketDAO.BuyTicketMoMoOnline(ticket.ID, ticket.Type, customer.ID, ticket.Price);
                }
                CustomerDAO.UpdatePointCustomer(customer.ID, customer.Point);
            }
            else
            {
                foreach (Ticket ticket in selectedSeat)
                {
                    ret += TicketDAO.BuyTicketMoMoOnline(ticket.ID, ticket.Type, ticket.Price);
                }
            }
            if (ret == selectedSeat.Count)
            {
                if (customer != null)
                {
                    MessageBox.Show("Bạn đã mua vé thành công!");
                    Send_mail();
                }
                else
                {
                    MessageBox.Show("Bạn đã mua vé thành công!");
                }
            }
            this.Close();
        }

        private void Send_mail()
        {
            string from, pass, content;
            from = "ngocnt219@uef.edu.vn";
            pass = "gmweqhgfxfwmpzwl";
            content = "Bạn đã thanh toán thành công" + "\n" + movie + "\nSuất chiếu : \t" + showtime;
            MailMessage mail = new MailMessage();
            mail.To.Add(emailcustomer);
            mail.From = new MailAddress(from);
            mail.Subject = "[CGV Nguyen Xi] Xác Nhận Thanh Toán";
            mail.Body = content;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(mail);
                MessageBox.Show("Đã gửi email xác nhận");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
