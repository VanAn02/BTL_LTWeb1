using CloudinaryDotNet;
using DbShop.Model.Dto;
using DbShop.Service.IServices;
using DbTravel.Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaDiemController : ControllerBase
    {
        private readonly IDiaDiemService _diaDiemService;
        public readonly Cloudinary _cloudinary;
        public DiaDiemController(IDiaDiemService diaDiemService,Cloudinary cloudinary)
        {
            _diaDiemService = diaDiemService;
            _cloudinary = cloudinary;
        }
        [HttpGet("DiaDiems")]
        public ActionResult GetAll()
        {
            return Ok(_diaDiemService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetDiadiem(int id)
        {
            var diadiem = _diaDiemService.Get(id);
            if (diadiem == null)
            {
                return NotFound();
            }
            return Ok(diadiem);
        }
        [HttpPost("AddDiaDiem")]
        public IActionResult Adddiadiem([FromForm]DiaDiemVM diadiem)
        {
            Upload upload=new Upload(_cloudinary);
            var dto = new DiaDiemDto()
            {
                DiaChi=diadiem.DiaChi,
                HinhAnh=upload.ImageUpload(diadiem.HinhAnh),
                MoTa=diadiem.MoTa,
                TenDiaDiem=diadiem.TenDiaDiem
            };

            if (_diaDiemService.Add(dto))
            {
                return CreatedAtAction("GetDiadiem", new { id = dto.Id }, dto);
            }
            return Ok("diadiem đã tồn tại");

        }
        [HttpPut("{id}")]
        public IActionResult UpdateDiaDiem([FromForm] DiaDiemVM diadiem)
        {
            Upload upload =new Upload(_cloudinary); 
            var url = _diaDiemService.Get(diadiem.Id).HinhAnh;
            var dto = new DiaDiemDto();
            dto.MoTa = diadiem.MoTa;
            dto.Id = diadiem.Id;
            dto.TenDiaDiem= diadiem.TenDiaDiem;
            dto.DiaChi = diadiem.DiaChi;
            if(diadiem.HinhAnh!=null)
            {
                dto.HinhAnh = upload.ImageUpload(diadiem.HinhAnh);
            }
            else
            {
            dto.HinhAnh = url;
            }
            if(_diaDiemService.Update(dto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("id")]
        public IActionResult DeleteDiadiem(int id)
        {
            if(_diaDiemService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì địa điểm đã tồn tại");
        }


    }
}
