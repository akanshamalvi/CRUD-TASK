using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace taskk.Models
{
    public class ProductWithCategory
    {
        public ProductWithCategory()
        {

        }
        public ProductWithCategory(Product p , Category c)
        {
            this.Product = p;
            this.Category = c;
        }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}