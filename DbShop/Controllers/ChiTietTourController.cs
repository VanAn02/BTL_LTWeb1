using DbShop.Model.Dto;
using DbShop.Model.Models;
using DbShop.Repository.IRepository;
using DbShop.Service.IServices;
using DbShop.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiTietTourController : ControllerBase
    {
        private readonly IChiTietTourService _chiTietTourService;
        public ChiTietTourController(IChiTietTourService chiTietTourService)
        {
            _chiTietTourService = chiTietTourService;
        }
        [HttpGet("ChiTietTours")]
        public IActionResult GetAll()
        {
            return Ok(_chiTietTourService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetChiTietTour(int id)
        {
            var chitiettour = _chiTietTourService.Get(id);
            if (chitiettour == null)
            {
                return NotFound();
            }
            return Ok(chitiettour);
        }
        [HttpPost("AddChiTietTour")]
        public IActionResult AddChiTietTour(ChiTietTourDto chitiettour)
        {
            if (_chiTietTourService.Add(chitiettour))
            {
                return CreatedAtAction("GetChiTietTour", new { id = chitiettour.Id }, chitiettour);
            }
            return Ok("ChiTietTour đã tồn tại");

        }
    
        [HttpPut("id")]
        public IActionResult UpdateChiTietTour(ChiTietTourDto chitiettour) {
            if (_chiTietTourService.Update(chitiettour))
            {
                return NoContent();

            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteChiTietTour(int id)
        {
            if (_chiTietTourService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Khong the xoa vi ChiTietTour khoong ton tai");
        }

    }
}
