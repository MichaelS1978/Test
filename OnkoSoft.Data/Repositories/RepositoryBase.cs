using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using OnkoSoft.Data.Domain;
using OnkoSoft.Data.Repositories.Interfaces;

namespace OnkoSoft.Data.Repositories
{
    public class RepositoryBase<T> : IRepository<T>, IDisposable where T : OnkoSoftBase
    {
        protected ISession m_Session = null;
        protected ITransaction m_Transaction = null;
        private int SaveCount = 0;

        public RepositoryBase()
        {
            m_Session = DatabaseManager.Instance.OpenSession();
        }

        public RepositoryBase(ISession session)
        {
            m_Session = session;
        }

        #region Transaction and Session Management Methods

        public void BeginTransaction()
        {
            m_Transaction = m_Session.BeginTransaction();
        }

        public void CommitTransaction()
        {
            // _transaction will be replaced with a new transaction by NHibernate, but we will close
            // to keep a consistent state.
            m_Transaction.Commit();

            CloseTransaction();
        }

        public void RollbackTransaction()
        {
            // _session must be closed and disposed after a transaction rollback to keep a
            // consistent state.
            m_Transaction.Rollback();

            CloseTransaction();
            CloseSession();
        }

        private void CloseTransaction()
        {
            m_Transaction.Dispose();
            m_Transaction = null;
        }

        private void CloseSession()
        {
            m_Session.Close();
            m_Session.Dispose();
            m_Session = null;
        }

        #endregion Transaction and Session Management Methods

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (m_Transaction != null)
                {
                    // Standardmäßig Transaktion zurückrollen. Ein Commit muss immer explizit
                    // aufgeführt werden.
                    RollbackTransaction();
                }

                if (m_Session != null)
                {
                    //m_Session.Flush(); // commit session transactions
                    CloseSession();
                }
            }
        }

        #endregion IDisposable Members

        public void Save(T obj)
        {
            m_Session.SaveOrUpdate(obj);

            if (DatabaseManager.Instance.BatchInsertMode)
            {
                SaveCount++;
                if (SaveCount % 20 == 0)
                {
                    m_Session.Flush();
                    m_Session.Clear();
                }
            }
        }

        public void Delete(T obj)
        {
            m_Session.Delete(obj);
        }

        public void DeleteAll()
        {
            IList<T> objects = ToList<T>().ToList<T>();

            foreach (T obj in objects)
                Delete(obj);
        }

        public T GetById(object objId)
        {
            return m_Session.Get<T>(objId);
        }

        public void Refresh(T obj)
        {
            m_Session.Evict(obj);
            obj = m_Session.Get<T>(obj.Id);
        }

        public IList<T> GetByBusinessKey(IDictionary<string, object> businessKeys)
        {
            ICriteria criteria = m_Session.CreateCriteria<T>();

            foreach (KeyValuePair<string, object> kvp in businessKeys)
            {
                criteria.Add(Restrictions.Eq(kvp.Key, kvp.Value));
            }

            return criteria.List<T>();
        }

        public IQueryable<TEntity> ToList<TEntity>()
        {
            return m_Session.Query<TEntity>();
        }

        public int Count()
        {
            return m_Session.Query<T>().Count<T>();
        }
    }
}