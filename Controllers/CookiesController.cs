using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace MVC_WindowsAuthentication.Controllers
{
    /// <summary>
    /// Cookies is a small piece of information stored on the client machine. 
    /// This file is located on client machines "C:\Document and Settings\Currently_Login user\Cookie" path. 
    /// Its is used to store user preference information like Username, Password,City and PhoneNo etc on client machines. 
    /// We need to import namespace called  System.Web.HttpCookie before we use cookie.
    /// Type of Cookies
    /// Persist Cookie - A cookie which has no expiry time is called as Persistant Cookie
    /// Non-Persist Cookie - A cookie which has expiry time is called as Non-Persistant Cookie
    /// </summary>
    public class CookiesController : Controller
    {
        // GET: Cookies
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriteCookie()
        {
            //Create a Cookie with a suitable Key.
            HttpCookie nameCookie = new HttpCookie("Name"); //John

            //Set the Cookie value.
            nameCookie.Values["Name"] = Request.Form["name"]; //TextBox - name - info - John

            //Set the Expiry date.
            nameCookie.Expires = DateTime.Now.AddSeconds(20);

            //Add the Cookie to Browser.
            Response.Cookies.Add(nameCookie);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ReadCookie()
        {
            //Fetch the Cookie using its Key.
            HttpCookie nameCookie = Request.Cookies["Name"];

            //If Cookie exists fetch its value.
            string name = nameCookie != null ? nameCookie.Value : "undefined";

            TempData["Message"] = name; //John

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteCookie()
        {
            //Fetch the Cookie using its Key.
            HttpCookie nameCookie = Request.Cookies["Name"];

            //Set the Expiry date to past date.
            nameCookie.Expires = DateTime.Now.AddDays(-1);

            //Update the Cookie in Browser.
            Response.Cookies.Add(nameCookie);

            return RedirectToAction("Index");
        }
    }
}