using ShoppingPortal.Masters.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingPortal.Masters.Interface
{
    interface ICountryRepository : IDisposable
    {
        List<Country> GetAllRecord();

        CountryPage GetRecordPage(int iPageNo, int iPageSize);

        Country GetRecordById(Guid iId);

        Guid InsertUpdateRecord(Country objCountry);

        bool DeleteRecord(int iId);
    }
}
