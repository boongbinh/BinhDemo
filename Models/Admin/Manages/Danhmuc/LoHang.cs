using System.ComponentModel.DataAnnotations;

namespace BinhDemo.Models.Admin.Manages.Danhmuc
{
    public class LoHang
    {
        [Key]
        public int Id { get; set; }
        public string? SoLo { get; set; }
        public string? TenTau { get; set; }
        public string? Cang { get; set; }
        //Sổ tờ khai
        public string? SoToKhai { get; set; }
        public string? LoaiTk { get; set; }
        public DateTime? NgayDangKiToKhai { get; set; }
        public DateTime? NgayVanDon { get; set; }
        public double? KhoiLuongGiamDinh { get; set; }
        public string? TrangThai { get; set; }
        public string? GiaiPhongHang { get; set; }
        public DateTime? ThongQuan { get; set; }
        //Sổ bảo lãnh
        public string? SoBaoLanh { get; set; }
        public DateTime? NgayBaoLanh { get; set; }
        //thời hạn nộp thuế được bảo lãnh
        public DateTime? ThoiHanNopThueDuocBl { get; set; }
        public DateTime? ThoiHanTaiXuat { get; set; }
        public DateTime? NgayGiaHanLan1 { get; set; }
        public string? GiaHanLan1 { get; set; }
        public DateTime? NgayGiaHanLan2 { get; set; }
        public string? GiaHanLan2 { get; set; }
        //phân chia tái xuất miền bắc
        public double? PhanChiaTxMienBac { get; set; }
        public double? PhanChiaTxMienNam { get; set; }
        public double? PhanChiaTxMienTrung { get; set; }
        public string? DuDieuKienThanhKhoan { get; set; }
        //ngày đề nghị thanh khoản
        public DateTime? NgayDeNghiTk { get; set; }
        public DateTime? NgayQuyetDinhTk { get; set; }
        public string? KhuVuc { get; set; }
        //chi phí thanh khoản
        public double? ChiPhiTk { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
