using System;
using System.Collections.Generic;

namespace DbShop.Model.Models
{
    public  class ChiTietTour
    {
        public int Id { get; set; }
        public int? IdTourDuLich { get; set; }
        public string AnhTour { get; set; }
        public string? LichTrinh { get; set; }
        public string? ThoiGian { get; set; }
        public  string? KhoiHanh { get; set; }
        public string? PhuongTien { get; set; }


        public virtual TourDuLich? IdTourDuLichNavigation { get; set; }
    }
}
