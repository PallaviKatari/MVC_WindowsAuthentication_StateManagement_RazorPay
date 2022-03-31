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
        //Cookies
        public string Cookies()
        {
            // Create the cookie object.
            HttpCookie cookie = new HttpCookie("MVC");
            cookie["cookie"] = "MVCCookie";
            // This cookie will remain  for one month.
            cookie.Expires = DateTime.Now.AddMonths(1);

            // Add it to the current web response.
            Response.Cookies.Add(cookie);
            HttpCookie cookieObj = Request.Cookies["MVC"];
            string cookiename = cookieObj["cookie"];
            return cookiename;
        }

        
        public ActionResult login()
        {
            // this is a custome object holding user data
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