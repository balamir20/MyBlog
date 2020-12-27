using MyBlog.Core.BaseModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyBlog.Core.BaseModels.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        Task<TEntity> GetByIdAsync(int id);

        IQueryable<TEntity> GetList(); //Linq to sql sorgusu olacağı için IQueryable kullandım.

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity Insert(TEntity entity);

        TEntity Update(TEntity entity);

        bool Delete(TEntity entity);

        bool DeleteRange(IEnumerable<TEntity> entities);
    }
}
