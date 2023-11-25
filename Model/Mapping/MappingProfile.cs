using AutoMapper;
using DbShop.Model.Dto;
using DbShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BaiViet, BaiVietDto>().ReverseMap();
            CreateMap<ChiTietTour, ChiTietTourDto>().ReverseMap();
            CreateMap<DatTour, DatTourDto>().ReverseMap();
            CreateMap<DiaDiem, DiaDiemDto>().ReverseMap();
            CreateMap<NguoiDung, NguoiDungDto>().ReverseMap();
            CreateMap<TourDuLich, TourDuLichDto>().ReverseMap();
        }

    }
}
