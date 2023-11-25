using DbShop.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Service.IServices
{
    public interface ITourDuLichService
    {
        List<TourDuLichDto> GetAll();
        TourDuLichDto Get(int id);
        bool Add(TourDuLichDto tourdulich);
        bool Update(TourDuLichDto tourdulich);
        bool Delete(int id);
    }
}
