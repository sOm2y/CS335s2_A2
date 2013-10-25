using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CS335s2_A2.Models;

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
namespace CS335s2_A2.Controllers
{
    public class HomeController : Controller
    {



        List<SupplierModel> smList = new List<SupplierModel>();



        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
      


    }
}
