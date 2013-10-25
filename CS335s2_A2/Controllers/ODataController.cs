
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Dynamic;
using System.Data.Services.Client;

using CS335s2_A2.Models;


namespace CS335s2_A2.Controllers
{
    public class ODataController : Controller
    {
        //
        // GET: /OData/

        public ActionResult WebGrid(int page = 1, int rowsPerPage = 10, string sort = "ProductID", string sortDir = "ASC")
        {
               DataServiceContext   nwd = new DataServiceContext(new Uri("http://services.odata.org/Northwind/Northwind.svc/"));

               var Products2 =
          (QueryOperationResponse<Product>)nwd.Execute<Product>(
          new Uri("http://services.odata.org/Northwind/Northwind.svc/Products()?$expand=Category,Supplier&$select=ProductID,ProductName,Category/CategoryName,Supplier/CompanyName,Supplier/Country"));

    
            var t = from p in Products2
                    select new JointProductModel
                    {
                        ProductID = p.ProductID,
                        ProductName = p.ProductName,
                        CategoryName = p.Category.CategoryName,
                        CompanyName = p.Supplier.CompanyName,
                        Country = p.Supplier.Country
                    };


          // ViewBag.count = t.Count();

            ViewBag.page = page;
            ViewBag.rowsPerPage = rowsPerPage;
            ViewBag.sort = sort;
            ViewBag.sortDir = sortDir;
            var r2 = t.AsQueryable().OrderBy(sort + " " + sortDir).Skip((page - 1) * rowsPerPage).Take(rowsPerPage);
            return View(r2.ToList());
        }
    }
     
}
