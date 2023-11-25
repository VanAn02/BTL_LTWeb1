using DbShop.Model.Dto;
using DbShop.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourDuLichController : ControllerBase
    {
        private readonly ITourDuLichService _tourDuLichService;
        public TourDuLichController(ITourDuLichService tourDuLichService)
        {
            _tourDuLichService = tourDuLichService;
        }
        [HttpGet("tourdulichs")]
        public ActionResult GetAll()
        {
            return Ok(_tourDuLichService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Gettourdulich(int id)
        {
            var tourdulich = _tourDuLichService.Get(id);
            if (tourdulich == null)
            {
                return NotFound();
            }
            return Ok(tourdulich);
        }
        [HttpPost("Addtourdulich")]
        public IActionResult Addtourdulich(TourDuLichDto tourdulich)
        {
            if (_tourDuLichService.Add(tourdulich))
            {
                return CreatedAtAction("Gettourdulich", new { id = tourdulich.Id }, tourdulich);
            }
            return Ok("tourdulich đã tồn tại");

        }
        [HttpPut("{id}")]
        public IActionResult UpdateTourDuLich(TourDuLichDto tourdulich)
        {
            if (_tourDuLichService.Update(tourdulich))
            {
                return NoContent();

            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTourDuLich(int id)
        {
            if (_tourDuLichService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Khong the xoa vi TourDuLich khoong ton tai");
        }

    }
}
