using ShoppingPortal.ProductInfo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingPortal.ProductInfo.Model
{
    public class ProductPage
    {
        public List<Product> Products { get; set; }

        public int TotalRecords { get; set; }
    }
}
