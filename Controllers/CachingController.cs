using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MVC_WindowsAuthentication.Controllers
{
    /// <summary>
    /// Caching means to store something in memory that is being used frequently to provide better performance.
    /// In ASP.NET MVC, there is an OutputCache filter attribute that you can apply and this is the same concept as output caching in web forms. 
    /// The output cache enables you to cache the content returned by a controller action.
    /// Output caching basically allows you to store the output of a particular controller in the memory. 
    /// Hence, any future request coming for the same action in that controller 
    /// will be returned from the cached result. That way, the same content does 
    /// not need to be generated each and every time the same controller action is invoked.
    /// </summary>
    public class CachingController : Controller
    {
        // GET: Cache
        [OutputCache(Duration = 20)]
        public ActionResult GetDate()
        {
            return View();
        }

        //[OutputCache(Duration = 60)]
        [OutputCache(CacheProfile = "Cache10Min")] // Configure in web.config
        //Refer - Batch35 - EmployeeController - Index - OutputCache Demo
        public ActionResult Index(List<String> names)
        {
            List<string> list = new List<string>();
            return View(names);
        }
    }
}