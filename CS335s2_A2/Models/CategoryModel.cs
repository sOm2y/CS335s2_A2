using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CS335s2_A2.Models
{
    public class CategoryModel
    {
        public CategoryModel(int CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}