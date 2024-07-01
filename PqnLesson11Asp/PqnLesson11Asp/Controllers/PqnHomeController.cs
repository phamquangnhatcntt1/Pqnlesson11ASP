using PqnLesson11Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PqnLesson11Asp.Controllers
{
    public class PqnHomeController : Controller
    {
        public ActionResult Index()
        {

            if (Session["PqnMember"] != null)
            {
                ViewBag.pqnTaiKhoan = ((pqntaikhoan)Session["PqnMember"]).PqnFullName;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}