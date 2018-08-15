using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> mvcList = new List<string> {
                                    "Controllers",
                                    "Models",
                                    "Views",
                                    "Scripts",
                                    "Content",
                                    "App_Start",
                                    "App_Code",
                                    "App_Data",
                                    "fonts"
                                };
            return View(mvcList);
        }
    }
}
