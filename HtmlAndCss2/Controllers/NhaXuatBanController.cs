using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAndCss2.Models;

namespace HtmlAndCss2.Controllers
{
    public class NhaXuatBanController : Controller
    {
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        // GET: NhaXuatBan
        public ActionResult NhaXuatBan()
        {
            return View();
        }
        public PartialViewResult NhaXuatBanPartial()
        {
            var nxb = db.NhaXuatBan.Take(3).ToList();
            return PartialView(nxb);
        }
        public PartialViewResult SachTheoNhaXuatBanPartial(int manhaxuatban = 0)
        {
            var sach = db.Sach.Where(n => n.MaNXB == manhaxuatban).ToList();
            return PartialView(sach);
        }
    }
}