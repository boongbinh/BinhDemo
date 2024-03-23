using Azure.Core;
using BinhDemo.Data;
using BinhDemo.Models.Admin.Setting.GoogleForm;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BinhDemo.Controllers.Admin.Setting.GoogleForm
{
	public class GoogleFormController : Controller
	{
		private readonly ApplicationDbContext _db;

		public GoogleFormController(ApplicationDbContext db)
		{
			_db = db;
		}
        public ActionResult Index()
        {
            var Form = _db.Form.ToList();
            return View("Views/Admin/Setting/GoogleForm/Index.cshtml", Form);
        }

        // Hiển thị form tạo biểu mẫu mới
        [Route("GoogleForm/Create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View("Views/Admin/Setting/GoogleForm/Create.cshtml");
        }

            // Xử lý tạo biểu mẫu mới
            [HttpPost]
        public ActionResult Create(Form form)
        {
            _db.Form.Add(form);
            _db.SaveChanges();
            return RedirectToAction("Index", "GoogleForm");
        }

        // Hiển thị form chỉnh sửa biểu mẫu
        public ActionResult Edit(int id)
        {
            var form = _db.Form.SingleOrDefault(f => f.Id == id);
            if (form == null)
                return View("Views/Admin/Error/SessionOut.cshtml");
            return View("Views/Admin/Setting/GoogleForm/Edit.cshtml",form);
        }

        // Xử lý chỉnh sửa biểu mẫu
        [HttpPost]
        public ActionResult Edit(Form form)
        {
            var formInDb = _db.Form.SingleOrDefault(f => f.Id == form.Id);
            if (formInDb == null)
                return View("Views/Admin/Error/SessionOut.cshtml");

            formInDb.Name = form.Name;
            _db.SaveChanges();

            return RedirectToAction("Index", "GoogleForm");
        }

        // Xóa biểu mẫu
        public ActionResult Delete(int id)
        {
            var form = _db.Form.SingleOrDefault(f => f.Id == id);
            if (form == null)
                return View("Views/Admin/Error/SessionOut.cshtml");

            _db.Form.Remove(form);
            _db.SaveChanges();

            return RedirectToAction("Index", "GoogleForm");
        }
    }
}
