using DbShop.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Service.IServices
{
    public interface IBaiVietService
    {
        List<BaiVietDto> GetAll();
        BaiVietDto Get(int id);
        bool Add(BaiVietDto baiviet);
        bool Update(BaiVietDto baiviet);
        bool Delete(int id);
    }
}
