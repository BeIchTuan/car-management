using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project.Model
{
    public class NguoiDung
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string MaCX { get; set; }
        public string MaNV { get; set; }

        public NguoiDung() { }

        public NguoiDung(int id, string username, string password, string email, string role, string maCX, string maNV)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            Role = role;
            MaCX = maCX;
            MaNV = maNV;
        }
    }

}
