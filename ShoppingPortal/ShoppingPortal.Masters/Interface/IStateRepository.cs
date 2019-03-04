using ShoppingPortal.Masters.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingPortal.Masters.Interface
{
    interface IStateRepository : IDisposable
    {
        List<State> GetAllRecord();

        StatePage GetRecordPage(int iPageNo, int iPageSize);

        State GetRecordById(Guid iId);

        Guid InsertUpdateRecord(State objState);

        bool DeleteRecord(int iId);
    }
}
