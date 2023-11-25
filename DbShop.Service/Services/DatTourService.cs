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
    public class DatTourService:IDatTourService
    {
        private readonly IDatTourRepo _dattourRepo;
        private readonly IMapper _mapper;

        public DatTourService(IDatTourRepo dattourRepo, IMapper mapper)
        {
            _dattourRepo = dattourRepo;
            _mapper = mapper;
        }
        public bool Add(DatTourDto dattour)
        {
            return _dattourRepo.Add(_mapper.Map<DatTour>(dattour));
        }

        public bool Delete(int id)
        {
            return _dattourRepo.Delete(id);
        }

        public DatTourDto Get(int id)
        {
            return _mapper.Map<DatTourDto>(_dattourRepo.Get(id));
        }

        public List<DatTourDto> GetAll()
        {
            return _mapper.Map<List<DatTourDto>>(_dattourRepo.GetAll());
        }

        public bool Update(DatTourDto dattour)
        {
            return _dattourRepo.Update(_mapper.Map<DatTour>(dattour));
        }

    }
}
