using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            WindowsIdentity authuser = WindowsIdentity.GetCurrent();

            List<string> mvcList = new List<string> {
                authuser.ImpersonationLevel.ToString(),
                authuser.IsAnonymous.ToString(),
                authuser.IsAuthenticated.ToString(),
                authuser.IsGuest.ToString(),
                authuser.IsSystem.ToString(),
                authuser.Name.ToString()

                                };
            return View(mvcList);
        }
    }
}
