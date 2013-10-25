using CS335s2_A2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Linq.Dynamic;

namespace CS335s2_A2.Controllers
{
    public class XmlController : Controller
    {
       
        public ActionResult WebGrid(int page = 1, int rowsPerPage = 10, string sort = "ProductID", string sortDir = "ASC")
        {


            string path = System.Web.HttpContext.Current.Server.MapPath(@"~\App_Data");

            var Suppliers =
                   XElement.Load(path + @"\XSuppliers.xml").
                   Elements("Supplier").
                   Select(x => new SupplierModel(
                       (int)x.Element("SupplierID"),
                       (string)x.Element("CompanyName"),
                       (string)x.Element("Country")
                   ));

            var Products =
                     XElement.Load(path + @"\XProducts.xml").
                        Elements("Product").
                        Select(x => new ProductModel(
                      (int)x.Element("ProductID"),
                      (string)x.Element("ProductName"),
                      (int)x.Element("CategoryID"),
                         (int)x.Element("SupplierID")
                    ));

            var Categories =
                   XElement.Load(path + @"\XCategories.xml").
                   Elements("Category").
                    Select(x => new CategoryModel(
                         (int)x.Element("CategoryID"),
                        (string)x.Element("CategoryName")
                     ));
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
