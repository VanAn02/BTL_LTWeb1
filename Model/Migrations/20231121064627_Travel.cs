using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbTravel.Model.Migrations
{
    public partial class Travel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaDiem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenDiaDiem = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    moTa = table.Column<string>(type: "text", nullable: true),
                    diaChi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    hinhAnh = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaDiem", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenDangNhap = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    avatar = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    matKhau = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    hoTen = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    soDienThoai = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    isAdmin = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TourDuLich",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTour = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    AnhTour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    moTa = table.Column<string>(type: "text", nullable: true),
                    gia = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    idDiaDiem = table.Column<int>(type: "int", nullable: true),
                    KhuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDuLich", x => x.id);
                    table.ForeignKey(
                        name: "FK__TourDuLic__idDia__267ABA7A",
                        column: x => x.idDiaDiem,
                        principalTable: "DiaDiem",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "BaiViet",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tieuDe = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    noiDung = table.Column<string>(type: "text", nullable: true),
                    ngayDang = table.Column<DateTime>(type: "date", nullable: true),
                    idNguoiDung = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiViet", x => x.id);
                    table.ForeignKey(
                        name: "FK__BaiViet__idNguoi__2B3F6F97",
                        column: x => x.idNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTour",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTourDuLich = table.Column<int>(type: "int", nullable: true),
                    AnhTour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lichTrinh = table.Column<string>(type: "text", nullable: true),
                    thoiGian = table.Column<string>(type: "text", nullable: true),
                    khoiHanh = table.Column<string>(type: "text", nullable: true),
                    phuongTien = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTour", x => x.id);
                    table.ForeignKey(
                        name: "FK__ChiTietTo__idTou__31EC6D26",
                        column: x => x.idTourDuLich,
                        principalTable: "TourDuLich",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DatTour",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idNguoiDung = table.Column<int>(type: "int", nullable: true),
                    idTourDuLich = table.Column<int>(type: "int", nullable: true),
                    ngayDat = table.Column<DateTime>(type: "date", nullable: true),
                    soNguoi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatTour", x => x.id);
                    table.ForeignKey(
                        name: "FK__DatTour__idNguoi__2E1BDC42",
                        column: x => x.idNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__DatTour__idTourD__2F10007B",
                        column: x => x.idTourDuLich,
                        principalTable: "TourDuLich",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaiViet_idNguoiDung",
                table: "BaiViet",
                column: "idNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTour_idTourDuLich",
                table: "ChiTietTour",
                column: "idTourDuLich");

            migrationBuilder.CreateIndex(
                name: "IX_DatTour_idNguoiDung",
                table: "DatTour",
                column: "idNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_DatTour_idTourDuLich",
                table: "DatTour",
                column: "idTourDuLich");

            migrationBuilder.CreateIndex(
                name: "IX_TourDuLich_idDiaDiem",
                table: "TourDuLich",
                column: "idDiaDiem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaiViet");

            migrationBuilder.DropTable(
                name: "ChiTietTour");

            migrationBuilder.DropTable(
                name: "DatTour");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "TourDuLich");

            migrationBuilder.DropTable(
                name: "DiaDiem");
        }
    }
}
