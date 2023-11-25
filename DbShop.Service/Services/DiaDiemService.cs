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
    public class DiaDiemService : IDiaDiemService
    {
        private readonly IDiaDiemRepo _diadiemRepo;
        private readonly IMapper _mapper;

        public DiaDiemService(IDiaDiemRepo diadiemRepo, IMapper mapper)
        {
            _diadiemRepo = diadiemRepo;
            _mapper = mapper;
        }
        public bool Add(DiaDiemDto diadiem)
        {
            return _diadiemRepo.Add(_mapper.Map<DiaDiem>(diadiem));
        }

        public bool Delete(int id)
        {
            return _diadiemRepo.Delete(id);
        }

        public DiaDiemDto Get(int id)
        {
            return _mapper.Map<DiaDiemDto>(_diadiemRepo.Get(id));
        }

        public List<DiaDiemDto> GetAll()
        {
            return _mapper.Map<List<DiaDiemDto>>(_diadiemRepo.GetAll());
        }

        public bool Update(DiaDiemDto diadiem)
        {
            // return _diadiemRepo.Update(_mapper.Map<DiaDiem>(diadiem));
            try
            {
                var existingEntity = _diadiemRepo.Get(diadiem.Id);

                if (existingEntity != null)
                {
                    _mapper.Map(diadiem, existingEntity);

                    _diadiemRepo.Update(existingEntity);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
