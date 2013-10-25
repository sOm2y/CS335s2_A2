using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CS335s2_A2.Models
{
    public class JointProductModel 
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
    }
}