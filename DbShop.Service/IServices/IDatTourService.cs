using DbShop.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Service.IServices
{
    public interface IDatTourService
    {
        List<DatTourDto> GetAll();
        DatTourDto Get(int id);
        bool Add(DatTourDto dattour);
        bool Update(DatTourDto dattour);
        bool Delete(int id);
    }
}
