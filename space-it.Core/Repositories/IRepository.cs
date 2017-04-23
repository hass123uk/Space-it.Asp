using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Space_it.Core.Entities;

namespace Space_it.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        IQueryable<TEntity> Query();

        void SaveOrUpdate(TEntity entity);

        void SaveOrUpdate(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);

        void Delete(IEnumerable<TEntity> entities);
    }
}
