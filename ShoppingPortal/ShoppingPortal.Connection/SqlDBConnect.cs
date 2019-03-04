using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ShoppingPortal.Connection
{
    public class SqlDBConnect : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=ShoppingPortal; Integrated Security=true;");
        }
    }
}
