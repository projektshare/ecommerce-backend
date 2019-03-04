using ShoppingPortal.ProductInfo.Model;
using System;
using System.Collections.Generic;

namespace ShoppingPortal.ProductInfo.Interface
{
    interface IProductRepository : IDisposable
    {
        List<Product> GetAllRecord();

        ProductPage GetRecordPage(int iPageNo, int iPageSize);

        Product GetRecordById(Guid iId);

        Guid InsertUpdateRecord(Product objProduct);

        bool DeleteRecord(int iId);
    }
}
