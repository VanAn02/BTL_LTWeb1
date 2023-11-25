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
    public class TourDuLichService:ITourDuLichService
    {
        private readonly ITourDuLichRepo _tourdulichRepo;
        private readonly IMapper _mapper;

        public TourDuLichService(ITourDuLichRepo tourdulichRepo, IMapper mapper)
        {
            _tourdulichRepo = tourdulichRepo;
            _mapper = mapper;
        }
        public bool Add(TourDuLichDto tourdulich)
        {
            return _tourdulichRepo.Add(_mapper.Map<TourDuLich>(tourdulich));
        }

        public bool Delete(int id)
        {
            return _tourdulichRepo.Delete(id);
        }

        public TourDuLichDto Get(int id)
        {
            return _mapper.Map<TourDuLichDto>(_tourdulichRepo.Get(id));
        }

        public List<TourDuLichDto> GetAll()
        {
            return _mapper.Map<List<TourDuLichDto>>(_tourdulichRepo.GetAll());
        }

        public bool Update(TourDuLichDto tourdulich)
        {
            return _tourdulichRepo.Update(_mapper.Map<TourDuLich>(tourdulich));
        }
    }
}
