namespace DbTravel.Api.Model
{
    public class DiaDiemVM
    {
        public int Id { get; set; }
        public string? TenDiaDiem { get; set; }
        public string? MoTa { get; set; }
        public string? DiaChi { get; set; }
        public IFormFile? HinhAnh { get; set; }
    }
}
