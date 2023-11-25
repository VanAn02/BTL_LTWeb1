using DbShop.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Service.IServices
{
    public interface INguoiDungService
    {
        List<NguoiDungDto> GetAll();
        NguoiDungDto Get(int id);
        bool Add(NguoiDungDto nguoidung);
        bool Update(NguoiDungDto nguoidung);
        bool Delete(int id);
    }
}
