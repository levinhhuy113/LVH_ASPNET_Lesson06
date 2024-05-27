using LVH_ASPNET_Lab05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LVH_ASPNET_Lab05.Controllers
{
    public class LVHMemberController : Controller
    {
        // GET: LVHMember
        public ActionResult CreateOne()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOne(LVHMember m )
        {
            return View("Details", m);
        }
        public ActionResult CreateTwo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTwo(LVHMember m)
        {
            if(m.Id==null)
            {
                ViewBag.error = "Hãy nhập mã số";
                return View();
            }
            if(m.Username==null)
            {
                ViewBag.error = "Hãy nhập tên đăng nhập";
                return View();
            }
            if (m.Fullname == null)
            {
                ViewBag.error = "Hãy nhập họ tên";
                return View();
            }
            if (m.Age == null)
            {
                ViewBag.error = "Hãy nhập tuổi";
                return View();
            }
            if (m.Email == null)
            {
                ViewBag.error = "Hãy nhập địa chỉ email";
                return View();
            }
            // mẫu kiểm tra Email
            string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            if(!System.Text.RegularExpressions.Regex.IsMatch(m.Email,regexPattern))
            {
                ViewBag.error = "Hãy nhập đúng định dạng";
                return View();
            }    
            return View("Details",m);
        }
        public ActionResult CreateThree(LVHMember m)
        {
            //nếu trạng thái dữ liệu của Model hợp lệ thì chuyển dữ liệu tới ViewDetails
            if (ModelState.IsValid)
                return View("Details", m);
            else
                return View();//quay lại view three để báo lỗi
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}