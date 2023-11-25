using DbShop.Model.Dto;
using DbShop.Service.IServices;
using DbShop.Service.Services;
using DbTravel.Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DbShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NguoiDungController : ControllerBase
    {
        private readonly INguoiDungService _nguoiDungService;
        private readonly IConfiguration _configuration;
        public NguoiDungController(INguoiDungService nguoiDungService, IConfiguration configuration)
        {
            _nguoiDungService = nguoiDungService;
            _configuration = configuration;
        }

        [HttpGet("NguoiDungs")]
        public IActionResult GetAll()
        {
            return Ok(_nguoiDungService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetNguoiDung(int id)
        {
            var nguoidung = _nguoiDungService.Get(id);
            if (nguoidung == null)
            {
                return NotFound();
            }
            return Ok(nguoidung);
        }
        [HttpPost("AddNguoiDung")]
        public IActionResult AddNguoiDung(NguoiDungDto nguoidung)
        {
            if (_nguoiDungService.Add(nguoidung))
            {
                return CreatedAtAction("GetNguoiDung", new { id = nguoidung.Id }, nguoidung);
            }
            return Ok("nguoidung đã tồn tại");

        }
        [HttpPut("{id}")]
        public IActionResult UpdateTourDuLich(NguoiDungDto nguoidung)
        {
            if (_nguoiDungService.Update(nguoidung))
            {
                return NoContent();

            }
            return NotFound();
        }
        [HttpDelete("id")]
        public IActionResult UpdateNguoiDung(NguoiDungDto nguoiDung)
        {
            if(_nguoiDungService.Update(nguoiDung))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì người dùng đã tồn tại");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            var user = _nguoiDungService.GetAll().Find(p => p.TenDangNhap == model.TenDangNhap && p.MatKhau== p.MatKhau);
            if (user != null)
            {
                var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"]));
                var signingCredential = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>
       {
           new Claim(ClaimTypes.Role,string.Join(",",model.IsAdmin)),
           new Claim(ClaimTypes.UserData,user.Id.ToString()),
           //new Claim(ClaimTypes.Email,userDto.Email),
       };
                var token = new JwtSecurityToken(
                        issuer: _configuration["Jwt:Issuer"],
                        audience: _configuration["Jwt:Audience"],
                        expires: DateTime.Now.AddHours(1),
                        signingCredentials: signingCredential,
                        claims: claims
                    );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });

            }
            return Unauthorized();
        }
    }
}
