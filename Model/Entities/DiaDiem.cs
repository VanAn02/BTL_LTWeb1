using System;
using System.Collections.Generic;

namespace DbShop.Model.Models
{
    public  class DiaDiem
    {
        public DiaDiem()
        {
            TourDuLiches = new HashSet<TourDuLich>();
        }

        public int Id { get; set; }
        public string? TenDiaDiem { get; set; }
        public string? MoTa { get; set; }
        public string? DiaChi { get; set; }
        public string? HinhAnh { get; set; }

        public virtual ICollection<TourDuLich> TourDuLiches { get; set; }
    }
}
