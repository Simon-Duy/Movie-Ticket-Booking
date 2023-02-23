using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEMA.DAO
{
    public class CustomerDAO
    {
        public static DataTable GetCustomerMember(string customerID, string name)
        {
            string query = "Select * from KhachHang where id = '" + customerID + "' and HoTen = N'" + name + "'";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetListCustomer()
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetCustomer");
        }

        public static bool InsertCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt,string email, int cmnd)
        {
            string command = string.Format("EXEC USP_InsertCustomer '{0}', N'{1}', N'{2}', N'{3}','{4}', '{5}',{6} ",   id, hoTen, ngaySinh, diaChi, sdt, email, cmnd);
            int result = DataProvider.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt,  string email, int cmnd, int point)
        {
            string command = string.Format("UPDATE dbo.KhachHang SET HoTen = N'{0}', NgaySinh = '{1}', DiaChi = N'{2}', SDT = '{3}', Email='{4}', CMND = {5}, DiemTichLuy = {6} WHERE id = '{7}'", hoTen, ngaySinh, diaChi, sdt, email, cmnd, point, id);
            int result = DataProvider.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool UpdatePointCustomer(string id, int point)
        {
            string command = string.Format("UPDATE dbo.KhachHang SET  DiemTichLuy = {0} WHERE id = '{1}'", point, id);
            int result = DataProvider.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteCustomer(string id)
        {
            int result = DataProvider.ExecuteNonQuery("DELETE dbo.KhachHang WHERE id = '" + id + "'");
            return result > 0;
        }

        public static DataTable SearchCustomerByName(string name)
        {
            return DataProvider.ExecuteQuery("EXEC USP_SearchCustomer @hoTen", new object[] { name });
        }
    }
}
