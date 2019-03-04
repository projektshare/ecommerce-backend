using log4net;
using ShoppingPortal.Masters.DAL;
using ShoppingPortal.Masters.Interface;
using ShoppingPortal.Masters.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingPortal.Masters.BAL
{
    public class State_BAL : IStateRepository
    {
        ILog log = log4net.LogManager.GetLogger(typeof(State_BAL));

        public List<State> GetAllRecord()
        {
            List<State> objReturn = null;
            try
            {
                using (State_DAL objDAL = new State_DAL())
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

        public StatePage GetRecordPage(int iPageNo, int iPageSize)
        {
            StatePage objReturn = new StatePage();
            try
            {
                using (State_DAL objDAL = new State_DAL())
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

        public State GetRecordById(Guid iId)
        {
            State objReturn = null;
            try
            {
                using (State_DAL objDAL = new State_DAL())
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

        public State Validate(string email, string password)
        {
            State objReturn = null;
            try
            {
                using (State_DAL objDAL = new State_DAL())
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

        public Guid InsertUpdateRecord(State objState)
        {
            Guid objReturn = new Guid();
            try
            {
                using (State_DAL objDAL = new State_DAL())
                {
                    objReturn = objDAL.InsertUpdateRecord(objState);
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
                using (State_DAL objDAL = new State_DAL())
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
        // ~State_BAL() {
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
