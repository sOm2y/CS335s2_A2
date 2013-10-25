using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CS335s2_A2.Models
{
    public class SupplierModel
    {
        public SupplierModel(int SupplierID, string CompanyName, string Country)
        {
            this.SupplierID = SupplierID;
            this.CompanyName = CompanyName;
            this.Country = Country;
        }
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
    }
}