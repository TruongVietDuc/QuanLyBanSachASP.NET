using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAndCss2.Models;
namespace HtmlAndCss2.Controllers
{
    public class NguoiDungDangKyController : Controller
    {
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        // GET: NguoiDung
        public ActionResult NguoiDungDangKy()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult DangKy()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult DangKy(KhachHang kh)
        {
            //if (ModelState.IsValid)
            //{
                db.KhachHang.Add(kh);
                db.SaveChanges();
            //}
            return PartialView();
        }

    }
}