using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BinhDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddFirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoLo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoToKhai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiTk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDangKiToKhai = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayVanDon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KhoiLuongGiamDinh = table.Column<double>(type: "float", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaiPhongHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThongQuan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoBaoLanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBaoLanh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiHanNopThueDuocBl = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiHanTaiXuat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayGiaHanLan1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiaHanLan1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayGiaHanLan2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiaHanLan2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhanChiaTxMienBac = table.Column<double>(type: "float", nullable: true),
                    PhanChiaTxMienNam = table.Column<double>(type: "float", nullable: true),
                    PhanChiaTxMienTrung = table.Column<double>(type: "float", nullable: true),
                    DuDieuKienThanhKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDeNghiTk = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayQuyetDinhTk = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KhuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChiPhiTk = table.Column<double>(type: "float", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: true),
                    Remember_Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Public = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    MaDonVi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaXa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhanLoaiTk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sadmin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNhomChucNang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhapLieu = table.Column<bool>(type: "bit", nullable: false),
                    TongHop = table.Column<bool>(type: "bit", nullable: false),
                    HeThong = table.Column<bool>(type: "bit", nullable: false),
                    ChucNangKhac = table.Column<bool>(type: "bit", nullable: false),
                    CapDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaDvBc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Menu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountLogin = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDonViChuQuanBc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDonViBc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDanhBc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChucDanhNguoiKyBc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoTenNguoiKyBc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoHang");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
