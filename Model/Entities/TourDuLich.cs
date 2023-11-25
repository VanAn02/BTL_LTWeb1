using System;
using System.Collections.Generic;

namespace DbShop.Model.Models
{
    public  class TourDuLich
    {
        public TourDuLich()
        {
            ChiTietTours = new HashSet<ChiTietTour>();
            DatTours = new HashSet<DatTour>();
        }

        public int Id { get; set; }
        public string? TenTour { get; set; }
        public string? AnhTour { get; set; }
        public string? MoTa { get; set; }
        public decimal? Gia { get; set; }
        public int? DiaDiem { get; set; }
        public string? KhuVuc { get; set; }

        public virtual DiaDiem? IdDiaDiemNavigation { get; set; }
        public virtual ICollection<ChiTietTour> ChiTietTours { get; set; }
        public virtual ICollection<DatTour> DatTours { get; set; }
    }
}
