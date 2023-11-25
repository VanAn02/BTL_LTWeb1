using AutoMapper;
using DbShop.Model.Dto;
using DbShop.Model.Models;
using DbShop.Repository.IRepository;
using DbShop.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Service.Services
{
    public class NguoiDungService:INguoiDungService
    {
        private readonly INguoiDungRepo _nguoidungRepo;
        private readonly IMapper _mapper;

        public NguoiDungService(INguoiDungRepo nguoidungRepo, IMapper mapper)
        {
            _nguoidungRepo = nguoidungRepo;
            _mapper = mapper;
        }
        public bool Add(NguoiDungDto nguoidung)
        {
            return _nguoidungRepo.Add(_mapper.Map<NguoiDung>(nguoidung));
        }

        public bool Delete(int id)
        {
            return _nguoidungRepo.Delete(id);
        }

        public NguoiDungDto Get(int id)
        {
            return _mapper.Map<NguoiDungDto>(_nguoidungRepo.Get(id));
        }

        public List<NguoiDungDto> GetAll()
        {
            return _mapper.Map<List<NguoiDungDto>>(_nguoidungRepo.GetAll());
        }

        public bool Update(NguoiDungDto nguoidung)
        {
            return _nguoidungRepo.Update(_mapper.Map<NguoiDung>(nguoidung));
        }
    }
}
