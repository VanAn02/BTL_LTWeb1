using DbShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Model.Dto
{
    public class NguoiDungDto
    {
        public int Id { get; set; }
        public string? TenDangNhap { get; set; }
        public string? Avartar { get; set; }

        public string? MatKhau { get; set; }
        public string? HoTen { get; set; }
        public string? Email { get; set; }
        public string? SoDienThoai { get; set; }
        public bool? IsAdmin { get; set; }

     
    }
}
