//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS335s2_A2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.CategoryComments = new HashSet<CategoryComment>();
            this.Products = new HashSet<Product>();
        }
    
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    
        public virtual ICollection<CategoryComment> CategoryComments { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
