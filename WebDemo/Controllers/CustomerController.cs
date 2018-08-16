using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public static CustomerInfo customerDet = new CustomerInfo
                                                {
                                                    Id = 101,
                                                    Name = "Anr",
                                                    Email = "anrpro@gmail.com",
                                                    attachments = new List<string>()

            
                                    };


        public ActionResult UpdateCustomer()
        {
            return View(customerDet);

        }


        [HttpPost]
        public ActionResult UpdateCustomer(CustomerInfo customer, List<HttpPostedFileBase> files)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }

            customerDet.Name = customer.Name;
            customerDet.Email = customer.Email;

            foreach (HttpPostedFileBase file in files)
            {
                
                file.SaveAs(System.IO.Path.Combine(Server.MapPath("~/Documents/"), file.FileName));
                customerDet.attachments.Add(file.FileName);

            }

            return View(customerDet);

        }

    }
}