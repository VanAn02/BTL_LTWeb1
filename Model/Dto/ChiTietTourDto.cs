using DbShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Model.Dto
{
    public class ChiTietTourDto
    {
        public long Id { get; set; }
        public int? IdTourDuLich { get; set; }
        public string? LichTrinh { get; set; }
        public string? ThoiGian { get; set; }
        public string? KhoiHanh { get; set; }
        public string? PhuongTien { get; set; }



    }
}
