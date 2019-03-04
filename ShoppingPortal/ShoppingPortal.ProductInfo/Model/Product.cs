using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingPortal.ProductInfo.Model
{
    public class Product
    {
        public int Id { get; set; }


        public Guid ProductId { get; set; }


        public Guid? CategoryId { get; set; }


        public string  SKU { get; set; }


        public string Name { get; set; }


        public string Description { get; set; }


        public string BasePrice { get; set; }


        public int StockQuantity { get; set; }


        public int MinimumQuantity { get; set; }


        public string HostIp { get; set; }


        public Guid? CreatedBy { get; set; }


        public DateTime? CreationDate { get; set; }


        public Guid? UpdatedBy { get; set; }


        public DateTime? UpdatedDate { get; set; }


        public bool? IsActive { get; set; }


        public bool? IsDeleted { get; set; }
    }
}
