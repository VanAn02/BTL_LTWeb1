using System;
using System.Collections.Generic;

namespace DbShop.Model.Models
{
    public class BaiViet
    {
        public int Id { get; set; }
        public string? TieuDe { get; set; }
        public string? NoiDung { get; set; }
        public DateTime? NgayDang { get; set; }
        public int? IdNguoiDung { get; set; }

        public virtual NguoiDung? IdNguoiDungNavigation { get; set; }
    }
}
