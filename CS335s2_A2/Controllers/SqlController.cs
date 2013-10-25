using CS335s2_A2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Dynamic;

namespace CS335s2_A2.Controllers
{
    public class SqlController : Controller
    {
        //
        // GET: /Sql/
        private northwndEntities sqlData = new northwndEntities();
        

        public ActionResult WebGrid(int page = 1, int rowsPerPage = 10, string sort = "ProductID", string sortDir = "ASC")
        {
            var Categories = this.sqlData.Categories;
            var Suppliers = this.sqlData.Suppliers;
            var Products = this.sqlData.Products;

            var r =
                   from p in Products
                   join c in Categories
                   on p.CategoryID equals c.CategoryID
                   join s in Suppliers
                   on p.SupplierID equals s.SupplierID
                   orderby p.ProductID ascending
                   select new JointProductModel
                   {
                       ProductID = p.ProductID,
                       ProductName = p.ProductName,
                       CategoryName = c.CategoryName,
                       CompanyName = s.CompanyName,
                       Country = s.Country
                   };

            ViewBag.page = page;
            ViewBag.rowsPerPage = rowsPerPage;
            ViewBag.sort = sort;
            ViewBag.sortDir = sortDir;
            ViewBag.count = r.Count();

            var r2 = r.AsQueryable().OrderBy(sort + " " + sortDir).Skip((page - 1) * rowsPerPage).Take(rowsPerPage);
            return View(r2);
        }

    }
}
