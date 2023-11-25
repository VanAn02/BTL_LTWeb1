using AutoMapper;
using DbShop.Service.IServices;
using DbShop.Model.Dto;

using DbShop.Repository.IRepository;
using DbShop.Model.Models;

namespace DbShop.Service.Services
{
    public class ChiTietTourService: IChiTietTourService
    {
        private readonly IChiTietTourRepo _chitiettourRepo;
        private readonly IMapper _mapper;

        public ChiTietTourService(IChiTietTourRepo chitiettourRepo, IMapper mapper)
        {
            _chitiettourRepo = chitiettourRepo;
            _mapper = mapper;
        }
        public bool Add(ChiTietTourDto chitiettour)
        {
            return _chitiettourRepo.Add(_mapper.Map<ChiTietTour>(chitiettour));
        }

        public bool Delete(int id)
        {
            return _chitiettourRepo.Delete(id);
        }

        public ChiTietTourDto Get(int id)
        {
            return _mapper.Map<ChiTietTourDto>(_chitiettourRepo.Get(id));
        }

        public List<ChiTietTourDto> GetAll()
        {
            return _mapper.Map<List<ChiTietTourDto>>(_chitiettourRepo.GetAll());
        }

        public bool Update(ChiTietTourDto chitiettour)
        {
            return _chitiettourRepo.Update(_mapper.Map<ChiTietTour>(chitiettour));
        }
    }
}
