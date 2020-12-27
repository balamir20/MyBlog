using Microsoft.EntityFrameworkCore;
using MyBlog.Core.BaseModels.Interfaces;
using MyBlog.Core.BaseModels.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyBlog.Data.Repository.Derived.EFSQL.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        public readonly DbContext _context;
        public readonly DbSet<TEntity> _dbSet;
        private IQueryable<TEntity> _queryEntity;

        public BaseRepository(DbContext dbContext)
        {
            _context = dbContext;
            _dbSet = dbContext.Set<TEntity>();
            _queryEntity = _dbSet.Where(m => m.IsDeleted == false).AsNoTracking();
        }
        public TEntity Insert(TEntity entity)
        {
            entity.CreateTime = DateTime.Now;
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
            return entity;
        }
        public TEntity Update(TEntity entity)
        {
            entity.UpdateTime = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public IQueryable<TEntity> GetList()
        {
            return _queryEntity.AsNoTracking();
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.SingleOrDefaultAsync(predicate);
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsNoTracking(); //AsNoTracking entity sorgusu sadece okumalık.
        }

        public bool Delete(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.DeletedTime = DateTime.Now;
            _dbSet.Attach(entity);                              //İçeriğin varlığını zaten veritabanında olduğunu belirtiyorum.
            _context.Entry(entity).State = EntityState.Modified; //Herhangi bir değişiklikte tüm kolonları değişmiş kabul edicem
            _context.SaveChanges();
            return true;                                //Silme işlemi gerçekleştiğinde geriye true dönücem
        }

        public bool DeleteRange(IEnumerable<TEntity> entities)
        {
            foreach (var item in entities)
            {
                Delete(item);
            }
            return true;
        }
    }
}
