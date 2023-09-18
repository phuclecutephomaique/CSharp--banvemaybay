using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm1.DTO
{
    class LoginDTO
    {
        private string tentaikhoan;
        private string matkhau;

        public LoginDTO()
        {
        }

        public LoginDTO(string tentaikhoan, string matkhau)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
        }

        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
