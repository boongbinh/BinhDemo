using BinhDemo.Data;
using BinhDemo.Models.Admin.Manages.Danhmuc;
using Microsoft.AspNetCore.Mvc;

namespace BinhDemo.Controllers.Admin.Manages.Danhmuc.QlLoHang
{
    public class QlLoHangController : Controller
    {
        private readonly ApplicationDbContext _db;

        public QlLoHangController(ApplicationDbContext db)
        {
            _db = db;
        }
        [Route("LoHang")]
        [HttpGet]
        public IActionResult Index()
        {
            var model = _db.LoHang;
            return View("Views/Admin/Manages/Danhmuc/LoHang/Index.cshtml", model);
        }
        [Route("LoHang/Detail")]
        [HttpPost]
        public JsonResult Detail(int Id)
        {
            var model = _db.LoHang.FirstOrDefault(p => p.Id == Id);


            string result = "<div class='modal-body' id='chitiet_lohang'>";

            result += "<table class='table table-striped table-bordered table-hover'>";
            result += "<thead>";
            result += "<tr>";
            result += "<th>Giải phóng hàng</th>";
            result += "<th>Thông quan</th>";
            result += "<th>Số bảo lãnh</th>";
            result += "<th>Ngày bảo lãnh</th>";
            result += "<th>Phân chia TX miền Bắc</th>";
            result += "<th>Phân chia TX miền Trung</th>";
            result += "<th>Phân chia TX miền Nam</th>";
            result += "<th>Đủ điều kiện thanh khoản</th>";
            result += "</tr>";
            result += "</thead>";
            result += "<tbody>";
            result += "<tr>";
            result += "<td>" + model.GiaiPhongHang + "</td>";
            result += "<td>" + model.ThongQuan + "</td>";
            result += "<td>" + model.SoBaoLanh + "</td>";
            result += "<td>" + model.NgayBaoLanh + "</td>";
            result += "<td>" + model.PhanChiaTxMienBac + "</td>";
            result += "<td>" + model.PhanChiaTxMienTrung + "</td>";
            result += "<td>" + model.PhanChiaTxMienNam + "</td>";
            result += "<td>" + model.DuDieuKienThanhKhoan + "</td>";
            result += "</tr>";
            result += "</tbody>";
            result += "</table>";

            result += "</div>";

            var data = new { status = "success", message = result };
            return Json(data);

        }

        [Route("LoHang/Edit")]
        [HttpPost]
        public IActionResult Edit(int Id)
        {
            var model = _db.LoHang.FirstOrDefault(p => p.Id == Id);

            if (model != null)
            {
                string result = "<div class='modal-body' id='edit_thongtin'>";

                result += "<div class='row text-left'>";
                result += "<div class='col-xl-6'>";
                result += "<div class='form-group fv-plugins-icon-container'>";
                result += "<label><b>Số thứ tự</b></label>";
                result += "<input type='number' id='stt_edit' name='stt_edit' value='" + model + "' class='form-control'/>";
                result += "</div>";
                result += "</div>";
                result += "<div class='col-xl-6'>";
                result += "<div class='form-group fv-plugins-icon-container'>";
                result += "<label><b>Tên chức vụ</b></label>";
                result += "<input type='text' id='tencv_edit' name='tencv_edit' value='" + model + "' class='form-control'/>";
                result += "</div>";
                result += "</div>";
                result += "<div class='col-xl-12'>";
                result += "<div class='form-group fv-plugins-icon-container'>";
                result += "<label><b>Mô tả</b></label>";
                result += "<textarea type='text' id='mota_edit' name='mota_edit' cols='12' rows='3' class='form-control'>" + model + "</textarea>";
                result += "</div>";
                result += "</div>";
                result += "</div>";

                result += "<input hidden type='text' id='id_edit' name='id_edit' value='" + model + "'/>";
                result += "</div>";

                var data = new { status = "success", message = result };
                return Json(data);
            }
            else
            {
                var data = new { status = "error", message = "Không tìm thấy thông tin cần chỉnh sửa!!!" };
                return Json(data);
            }
        }
    }
}
