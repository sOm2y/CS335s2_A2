using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CS335s2_A2.Models
{
    public class ProductModel
    {
        public ProductModel(int ProductID, string ProductName, int CategoryID, int SupplierID)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.CategoryID = CategoryID;
            this.SupplierID = SupplierID;
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public global::System.Nullable<int> SupplierID { get; set; }
        public global::System.Nullable<int> CategoryID { get; set; }
    }
}