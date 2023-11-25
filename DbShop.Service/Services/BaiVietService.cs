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
    public class BaiVietService : IBaiVietService
    {
        private readonly IBaiVietRepo _baivietRepo;
        private readonly IMapper _mapper;

        public BaiVietService(IBaiVietRepo baivietRepo, IMapper mapper)
        {
            _baivietRepo = baivietRepo;
            _mapper = mapper;
        }
        public bool Add(BaiVietDto baiviet)
        {
            return _baivietRepo.Add(_mapper.Map<BaiViet>(baiviet));
        }

        public bool Delete(int id)
        {
            return _baivietRepo.Delete(id);
        }

        public BaiVietDto Get(int id)
        {
            return _mapper.Map<BaiVietDto>(_baivietRepo.Get(id));
        }

        public List<BaiVietDto> GetAll()
        {
            return _mapper.Map<List<BaiVietDto>>(_baivietRepo.GetAll());
        }

        public bool Update(BaiVietDto baiviet)
        {
            return _baivietRepo.Update(_mapper.Map<BaiViet>(baiviet));
        }
    }
}
