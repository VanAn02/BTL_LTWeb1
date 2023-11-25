using DbShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Model.Dto
{
    public class DatTourDto
    {
        public int Id { get; set; }
        public int? IdNguoiDung { get; set; }
        public int? IdTourDuLich { get; set; }
        public DateTime? NgayDat { get; set; }
        public int? SoNguoi { get; set; }

       
    }
}
