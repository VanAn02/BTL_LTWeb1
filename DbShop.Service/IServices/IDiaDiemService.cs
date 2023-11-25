using DbShop.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Service.IServices
{
    public interface IDiaDiemService
    {
        List<DiaDiemDto> GetAll();
        DiaDiemDto Get(int id);
        bool Add(DiaDiemDto diadiem);
        bool Update(DiaDiemDto diadiem);
        bool Delete(int id);
    }
}
