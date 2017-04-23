using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using Space_it.Core.Entities;
using Space_it.Core.NHibernate_Data;

namespace Space_it.Core.Repositories.Impl
{
    public abstract class NhBaseRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected ISession Session => NHibernateSessionManager.GetCurrentSession();

        public IQueryable<TEntity> Query()
        {
            return Session.Query<TEntity>().Where(e => !e.Deleted);
        }

        public void SaveOrUpdate(TEntity entity)
        {
            using (var trans = Session.BeginTransaction())
            {
                try
                {
                    entity.Modified = DateTime.UtcNow;
                    Session.SaveOrUpdate(entity);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public void SaveOrUpdate(IEnumerable<TEntity> entities)
        {
            using (var trans = Session.BeginTransaction())
            {
                try
                {
                    foreach (var entity in entities)
                    {
                        entity.Modified = DateTime.UtcNow;
                        Session.SaveOrUpdate(entity);
                    }
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public void Delete(TEntity entity)
        {
            entity.Deleted = false;
            entity.Modified = DateTime.UtcNow;
            Session.SaveOrUpdate(entity);
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.Deleted = false;
                entity.Modified = DateTime.UtcNow;

            }
            Session.SaveOrUpdate(entities);
        }
    }
}