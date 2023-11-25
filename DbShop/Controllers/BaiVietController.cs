using DbShop.Model.Dto;
using DbShop.Service.IServices;
using DbShop.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbShop.Api.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class BaiVietController : ControllerBase
    {
        private readonly IBaiVietService _baivietService;
        public BaiVietController(IBaiVietService baiVietService)
        {
            _baivietService = baiVietService;
        }
        [HttpGet("BaiViets")]
        public IActionResult GetAll()
        {
            return Ok(_baivietService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetBaiViet(int id)
        {
            var baiviet = _baivietService.Get(id);
            if (baiviet == null)
            {
                return NotFound();
            }
            return Ok(baiviet);
        }
        [HttpPost("AddBaiViet")]
        public IActionResult AddBaiViet(BaiVietDto baiviet)
        {
            if (_baivietService.Add(baiviet))
            {
                return CreatedAtAction("GetBaiViet", new { id = baiviet.Id }, baiviet);
            }
            return Ok("Bài Viết đã tồn tại");

        }
        [HttpPut("id")]
        public IActionResult UpdateBaiViet(BaiVietDto baiviet)
        {
            if(_baivietService.Update(baiviet))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("id")]
        public IActionResult DeleteBaiViet(int id)
        {
            if (!_baivietService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì bài viết không tồn tại");
        }


    }
}
