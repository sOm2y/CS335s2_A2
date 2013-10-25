using CS335s2_A2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS335s2_A2.Controllers
{
    public class ArithController : Controller
    {
        //
        // GET: /Arith/
        public ActionResult Arith(Arith model)
        {
            ViewBag.Message = "Your contact page.";
            if (model.m != 0 && model.n != 0)
            {
                model.Sum = model.m + model.n;
                model.Mines = model.m - model.n;
                model.Times = model.m * model.n;
                model.divde = model.m / model.n;
                model.mod = model.m % model.n;
            }
            return View(model);
        }
       
    }
}
