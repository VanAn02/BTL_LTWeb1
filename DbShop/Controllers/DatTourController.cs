using DbShop.Model.Dto;
using DbShop.Service.IServices;
using DbShop.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatTourController : ControllerBase
    {
        private readonly IDatTourService _datTourService;
        public DatTourController(IDatTourService datTourService)
        {
            _datTourService = datTourService;
        }
        [HttpGet("DatTours")]
        public ActionResult GetAll()
        {
        return Ok(_datTourService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetDatTour(int id)
        {
            var dattour = _datTourService.Get(id);
            if (dattour == null)
            {
                return NotFound();
            }
            return Ok(dattour);
        }
        [HttpPost("AddDatTour")]
        public IActionResult AddDatTour(DatTourDto dattour)
        {
            if (_datTourService.Add(dattour))
            {
                return CreatedAtAction("Getdattour", new { id = dattour.Id }, dattour);
            }
            return Ok("dattour đã tồn tại");

        }
        [HttpPut("id")]
        public IActionResult UpdateDatTour(DatTourDto dattour)
        {
            if(_datTourService.Update(dattour))
                {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("id")]
        public ActionResult DeleteDatTour(int id)
        {
            if(!_datTourService.Delete(id))
            { 
                return NoContent(); 
            }
            return NotFound("Không thể xóa vì đặt tour không tồn tại");
        }
       
    }
}
