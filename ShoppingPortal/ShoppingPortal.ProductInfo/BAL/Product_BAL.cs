using log4net;
using ShoppingPortal.ProductInfo.DAL;
using ShoppingPortal.ProductInfo.Interface;
using ShoppingPortal.ProductInfo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingPortal.ProductInfo.BAL
{
    public class Product_BAL : IProductRepository
    {
        ILog log = log4net.LogManager.GetLogger(typeof(Product_BAL));

        public List<Product> GetAllRecord()
        {
            List<Product> objReturn = null;
            try
            {
                using (Product_DAL objDAL = new Product_DAL())
                {
                    objReturn = objDAL.GetAllRecord();
                }
            }
            catch (Exception ex)
            {
                log.Error("GetAllRecord Error: ", ex);
            }
            return objReturn;
        }

        public ProductPage GetRecordPage(int iPageNo, int iPageSize)
        {
            ProductPage objReturn = new ProductPage();
            try
            {
                using (Product_DAL objDAL = new Product_DAL())
                {
                    objReturn = objDAL.GetRecordPage(iPageNo, iPageSize);
                }
            }
            catch (Exception ex)
            {
                log.Error("GetRecordPage Error: ", ex);
            }
            return objReturn;
        }

        public Product GetRecordById(Guid iId)
        {
            Product objReturn = null;
            try
            {
                using (Product_DAL objDAL = new Product_DAL())
                {
                    objReturn = objDAL.GetRecordById(iId);
                }
            }
            catch (Exception ex)
            {
                log.Error("GetRecordById Error: ", ex);
            }
            return objReturn;
        }

        public Product Validate(string email, string password)
        {
            Product objReturn = null;
            try
            {
                using (Product_DAL objDAL = new Product_DAL())
                {
                    objReturn = objDAL.Validate(email, password);
                }
            }
            catch (Exception ex)
            {
                log.Error("Validate Error: ", ex);
            }
            return objReturn;
        }

        public Guid InsertUpdateRecord(Product objProduct)
        {
            Guid objReturn = new Guid();
            try
            {
                using (Product_DAL objDAL = new Product_DAL())
                {
                    objReturn = objDAL.InsertUpdateRecord(objProduct);
                }
            }
            catch (Exception ex)
            {
                log.Error("InsertUpdateRecord Error: ", ex);
            }
            return objReturn;
        }

        public bool DeleteRecord(int iId)
        {
            bool objReturn = false;
            try
            {
                using (Product_DAL objDAL = new Product_DAL())
                {
                    objReturn = objDAL.DeleteRecord(iId);
                }
            }
            catch (Exception ex)
            {
                log.Error("DeleteRecord Error: ", ex);
            }
            return objReturn;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Product_BAL() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
