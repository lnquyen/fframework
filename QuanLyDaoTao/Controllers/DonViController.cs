using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDaoTao.Models;
namespace QuanLyDaoTao.Controllers
{
    public class DonViController : Controller
    {
        // GET: DonVi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadData(string sort="DV_MA", string order="asc")
        {
            var data = new DonViDao().ListAll(sort,order);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(DM_DON_VI DonVi)
        {

            var dao = new DonViDao();
            if (dao.isExist(DonVi.DV_MA)) {
                var model = new { errorMsg = "Mã đơn vị đã tồn tại" };
                return Json(model, JsonRequestBehavior.AllowGet);
            } else
            {
                dao.Insert(DonVi);
                var model = new { sussMsg = "Thêm thành công" };
                return Json(model, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Update(DM_DON_VI DonVi)
        {
            var dao = new DonViDao();
            if (dao.isExistWhenUpdate(DonVi.DV_MA, DonVi.DV_ID))
            {
                var model = new { errorMsg = "Mã đơn vị đã tồn tại" };
                return Json(model, JsonRequestBehavior.AllowGet);
            }
            else
            {
                dao.Update(DonVi);
                var model = new { sussMsg = "Thêm thành công" };
                return Json(model, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Delete(long id)
        {
            var data = new DonViDao().Delete(id);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}
