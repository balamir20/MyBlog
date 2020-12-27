﻿using MyBlog.Core.BaseModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyBlog.Core.BaseModels.Services
{
    /// <summary>
    /// TEntity class olmak zorunda ve IEntityden türetilmiş olmak zorundadır.
    /// Sql serverdan farklı bir repository kullanabilirim o yüzden bunu oluşturdum.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IService<TEntity> where TEntity : class, IEntity
    {
        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        TEntity Update(TEntity entity);
    }
}