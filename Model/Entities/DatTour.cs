using System;
using System.Collections.Generic;

namespace DbShop.Model.Models
{
    public  class DatTour
    {
        public int Id { get; set; }
        public int? IdNguoiDung { get; set; }
        public int? IdTourDuLich { get; set; }
        public DateTime? NgayDat { get; set; }
        public int? SoNguoi { get; set; }

        public virtual NguoiDung? IdNguoiDungNavigation { get; set; }
        public virtual TourDuLich? IdTourDuLichNavigation { get; set; }
    }
}
