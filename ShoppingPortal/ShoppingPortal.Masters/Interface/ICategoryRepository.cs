using ShoppingPortal.Masters.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingPortal.Masters.Interface
{
    interface ICategoryRepository : IDisposable
    {
        List<Category> GetAllRecord();

        CategoryPage GetRecordPage(int iPageNo, int iPageSize);

        Category GetRecordById(Guid iId);

        Guid InsertUpdateRecord(Category objCategory);

        bool DeleteRecord(int iId);
    }
}
