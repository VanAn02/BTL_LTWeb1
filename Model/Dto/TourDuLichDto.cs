using DbShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Model.Dto
{
    public class TourDuLichDto
    {
        public int Id { get; set; }
        public string? TenTour { get; set; }
        public string? AnhTour { get; set; }
        public string? MoTa { get; set; }
        public decimal? Gia { get; set; }
        public int? IdDiaDiem { get; set; }
        public string? KhuVuc { get; set; }

     
    }
}
