using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAndCss2.Models;
namespace HtmlAndCss2.Controllers
{
    
    public class SachController : Controller
    {
        // GET: Sach
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        
        public PartialViewResult SachMoiPartial()
        {
            var sach = db.Sach.Take(3).ToList();
            return PartialView(sach);
        }
      
        public PartialViewResult TacGiaPartial()
        {
            var tg = db.TacGia.Take(3).ToList();
            return PartialView(tg);
        }
        public ViewResult XemChiTiet(int masach=0)
        {
            var sach = db.Sach.SingleOrDefault(n => n.MaSach == masach);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            else
                return View(sach);
        }
    }
}