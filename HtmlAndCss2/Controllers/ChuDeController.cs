using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAndCss2.Models;
namespace HtmlAndCss2.Controllers
{
    public class ChuDeController : Controller
    {
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        // GET: ChuDe
        public ActionResult ChuDe()
        {
            return View();
        }
        public PartialViewResult ChuDePartial()
        {
            var cd = db.ChuDe.Take(7).ToList();
            return PartialView(cd);
        }
        public PartialViewResult SachTheoChuDePartial(int machude=0)
        {
            var sach = db.Sach.Where(n => n.MaChuDe == machude).ToList();
            return PartialView(sach);
        }
    }
}