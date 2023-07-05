using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace taskk.Models
{
    public class ProductWithCategroyVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public Product Product { get; set; }
    }
}