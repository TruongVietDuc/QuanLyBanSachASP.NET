using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAndCss2.Models;
namespace HtmlAndCss2.Controllers
{
    public class NguoiDungDangNhapController : Controller
    {
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        // GET: NguoiDungDangNhap
        public ActionResult NguoiDungDangNhap()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult DangNhap()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult DangNhap(FormCollection f)
        {
            string sTaikhoan = f["txtTaiKhoan"].ToString();
            string sMatKhau = f.Get("txtMatKhau").ToString();
            KhachHang kh = db.KhachHang.FirstOrDefault(n => n.TaiKhoan == sTaikhoan&&n.MatKhau==sMatKhau);
            if(kh!=null)
                {
                ViewBag.ThongBao = "Chúc mừng bạn đã đăng nhập thành công !";
                Session["TaiKhoan"] = kh;
                return PartialView();
                }
            ViewBag.ThongBao = "Tên tài khoản hay mật khẩu đã bị sai !";
            return PartialView();
        }
    }
}