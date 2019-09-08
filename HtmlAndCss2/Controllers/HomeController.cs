using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAndCss2.Models;
namespace HtmlAndCss2.Controllers
{
    public class HomeController : Controller
    {
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult DanhSachKhongTheoChuDePartial()
        {
            var sach = db.Sach.Where(n => n.Moi == 1).ToList();
            return PartialView(sach);
        }

      

    }
}