using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WindowsAuthentication.Controllers
{
    public class HomeController : Controller
    {
        //Retrieve the local users from Computer Management
        // GET: Home
        [Authorize(Users = @"CGVAK-LT156\cgvak-lt156")]
        public ActionResult Index()
        {

            return View();

        }
        [Authorize(Users = @"CGVAK-LT156\admin")]
        public ActionResult About()
        {
            return View();
        }
        [Authorize(Users = @"CGVAK-LT156\Administrator")]
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult login()
        {
            // this is a custom object holding user data
            Session["userInfo"] = "I am a Session";
            return View();
        }

        public string mydashboard()
        {
            string _uobj = Session["userInfo"] as string;
            return _uobj;
        }
        public ActionResult Welcome()
        {
            Session["username"] = "John";
            return View();
        }
    }
}