using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEMA.DTO
{
    public class Customer
    {
        public Customer(string iD, string name, DateTime birth, string address,
            string phone, string email, int identityCard, int point)
        {
            this.ID = iD;
            this.Name = name;
            this.BirthDate = birth;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.IdentityCard = identityCard;
            this.Point = point;
        }

        public Customer(DataRow row)
        {
            ID = row["id"].ToString();
            Name = row["HoTen"].ToString();
            BirthDate = DateTime.Parse(row["NgaySinh"].ToString());
            Address = row["DiaChi"].ToString();
            Phone = row["SDT"].ToString();
            Email = row["Email"].ToString();
            IdentityCard = (int)row["CMND"];
            Point = (int)row["DiemTichLuy"];
        }

        public string ID { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int IdentityCard { get; set; }

        public int Point { get; set; }
    }
}
