using CINEMA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEMA.DAO
{
    public class TicketDAO
    {
        public static List<Ticket> GetListTicketsByShowTimes(string showTimesID)
        {
            List<Ticket> listTicket = new List<Ticket>();
            string query = "select * from Ve where idLichChieu = '" + showTimesID + "'";
            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Ticket ticket = new Ticket(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }

        public static int BuyTicketMoMoOnline(string ticketID, int type, float price)
        {
            string query = "Update dbo.Ve set TrangThai = 1, LoaiVe = "
                + type + ", TienBanVe =" + price + ", LoaiThanhToan= N'Thanh toán MoMo Online'" + "where id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }

        public static int BuyTicketMoMoOnline(string ticketID, int type, string customerID, float price)
        {
            string query = "Update dbo.Ve set TrangThai = 1, LoaiVe = " + type
                + ", idKhachHang =N'" + customerID + "', TienBanVe =" + price + ", LoaiThanhToan= N'Thanh toán MoMo Online'" + " where id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }
        public static List<Ticket> GetListTicketsBoughtByShowTimes(string showTimesID)
        {
            List<Ticket> listTicket = new List<Ticket>();
            string query = "select * from Ve where idLichChieu = '" + showTimesID + "' and TrangThai = 1";
            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Ticket ticket = new Ticket(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }

        public static int CountToltalTicketByShowTime(string showTimesID)
        {
            string query = "Select count (id) from Ve where idLichChieu ='" + showTimesID + "'";
            return (int)DataProvider.ExecuteScalar(query);
        }
        public static int CountTheNumberOfTicketsSoldByShowTime(string showTimesID)
        {
            string query = "Select count (id) from Ve where idLichChieu ='" + showTimesID + "' and TrangThai = 1 ";
            return (int)DataProvider.ExecuteScalar(query);
        }
        public static int BuyTicket(string ticketID, int type, float price)
        {
            string query = "Update dbo.Ve set TrangThai = 1, LoaiVe = "
                + type + ", TienBanVe =" + price + ", LoaiThanhToan= N'Thanh toán Tiền mặt'" + "where id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }
        public static int BuyTicket(string ticketID, int type, string customerID, float price)
        {
            string query = "Update dbo.Ve set TrangThai = 1, LoaiVe = " + type
                + ", idKhachHang =N'" + customerID + "', TienBanVe =" + price + ", LoaiThanhToan= N'Thanh toán Tiền mặt'" + " where id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }
        public static int BuyTicketMoMo(string ticketID, int type, float price)
        {
            string query = "Update dbo.Ve set TrangThai = 1, LoaiVe = "
                + type + ", TienBanVe =" + price + ", LoaiThanhToan= N'Thanh toán MoMo'" + "where id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }
        public static int BuyTicketMoMo(string ticketID, int type, string customerID, float price)
        {
            string query = "Update dbo.Ve set TrangThai = 1, LoaiVe = " + type
                + ", idKhachHang =N'" + customerID + "', TienBanVe =" + price + ", LoaiThanhToan= N'Thanh toán MoMo'" + " where id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }

        public static int InsertTicketByShowTimes(string showTimesID, string seatName)
        {
            string query = "USP_InsertTicketByShowTimes @idlichChieu , @maGheNgoi";
            return DataProvider.ExecuteNonQuery(query, new object[] { showTimesID, seatName });
        }

        public static int DeleteTicketsByShowTimes(string showTimesID)
        {
            string query = "USP_DeleteTicketsByShowTimes @idlichChieu";
            return DataProvider.ExecuteNonQuery(query, new object[] { showTimesID });
        }
    }
}
