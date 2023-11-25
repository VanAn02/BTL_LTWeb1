using DbShop.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Service.IServices
{
    public interface IChiTietTourService
    {
        List<ChiTietTourDto> GetAll();
        ChiTietTourDto Get(int id);
        bool Add(ChiTietTourDto chitiettour);
        bool Update(ChiTietTourDto chitiettour);
        bool Delete(int id);
    }
}
