using DbShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Model.Dto
{
    public class DiaDiemDto
    {
        public int Id { get; set; }
        public string? TenDiaDiem { get; set; }
        public string? MoTa { get; set; }
        public string? DiaChi { get; set; }
        public string? HinhAnh { get; set; }

    }
}
