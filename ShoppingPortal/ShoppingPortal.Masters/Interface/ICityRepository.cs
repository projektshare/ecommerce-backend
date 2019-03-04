using ShoppingPortal.Masters.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingPortal.Masters.Interface
{
    interface ICityRepository : IDisposable
    {
        List<City> GetAllRecord();

        CityPage GetRecordPage(int iPageNo, int iPageSize);

        City GetRecordById(Guid iId);

        Guid InsertUpdateRecord(City objCity);

        bool DeleteRecord(int iId);
    }
}
