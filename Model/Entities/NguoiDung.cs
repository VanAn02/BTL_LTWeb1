using System;
using System.Collections.Generic;

namespace DbShop.Model.Models
{
    public  class NguoiDung
    {
        public NguoiDung()
        {
            BaiViets = new HashSet<BaiViet>();
            DatTours = new HashSet<DatTour>();
        }

        public int Id { get; set; }
        public string? TenDangNhap { get; set; }
        public string? Avartar { get; set; }
        public string? MatKhau { get; set; }
        public string? HoTen { get; set; }
        public string? Email { get; set; }
        public string? SoDienThoai { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual ICollection<BaiViet> BaiViets { get; set; }
        public virtual ICollection<DatTour> DatTours { get; set; }
    }
}
