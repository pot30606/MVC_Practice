using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Interface
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        TKey Create(TEntity entity);

        int Update(TEntity entity);

        bool Delete(TKey id);

        TEntity FindById(TKey id);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);

        IEnumerable<TEntity> FindAll();
    }

}
