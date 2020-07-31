using Microsoft.EntityFrameworkCore;
using OnlineStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnlineStore.DataAccess.Reposotories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //private OnlineStoreDbContext context;
        //private DbSet<T> table;
        ///// <summary>
        ///// Initialize a new instance of the class
        ///// </summary>
        //public Repository()
        //{
        //    this.context = new OnlineStoreDbContext();
        //    table = context.Set<T>(); 
        //}

        ///// <summary>
        ///// Adds the specified entity
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //public T Add(T entity)
        //{
        //    table.Add(entity);
        //    return entity;
        //}

        ///// <summary>
        ///// Get all the specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //public bool All(Expression<Func<T, bool>> predicate)
        //{
        //    return table.All(predicate);
        //}

        ///// <summary>
        ///// Get items which matched to the specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //public bool Any(Expression<Func<T, bool>> predicate)
        //{
        //    return table.Any(predicate);
        //}

        ///// <summary>
        ///// Count the specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //public int Count(Expression<Func<T, bool>> predicate)
        //{
        //    return table.Count(predicate);
        //}

        ///// <summary>
        ///// Find all
        ///// </summary>
        ///// <returns></returns>
        //public IEnumerable<T> FindAll()
        //{
        //    return table.ToList();
        //}

        ///// <summary>
        ///// Get first values for specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //public T First(Expression<Func<T, bool>> predicate)
        //{
        //    return table.First(predicate);
        //}

        ///// <summary>
        ///// Get first or default value for specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        //{
        //    return table.FirstOrDefault(predicate);
        //}

        ///// <summary>
        ///// Gets by id
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public T GetById(long id)
        //{
        //    return table.FirstOrDefault(m => m.Id == id);
        //}

        ///// <summary>
        ///// Get single value for specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //public T Single(Expression<Func<T, bool>> predicate)
        //{
        //    return table.Single(predicate);
        //}

        ///// <summary>
        ///// Get single or default value for specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        //{
        //    return table.SingleOrDefault(predicate);
        //}

        ///// <summary>
        ///// Update specified entity
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //public T Update(T entity)
        //{
        //    this.table.Attach(entity);
        //    return entity;
        //}

        ///// <summary>
        ///// Get the items which matched specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        //{
        //    return table.Where(predicate);
        //}

        protected readonly DbContext db;

        public Repository(DbContext _db)
        {
            db = _db;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return db.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(object Id)
        {
            return db.Set<TEntity>().Find(Id);
        }

        public void Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().RemoveRange(entities);
        }

        public void Remove(object Id)
        {
            TEntity entity = db.Set<TEntity>().Find(Id);
            this.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            db.Entry<TEntity>(entity).State = EntityState.Modified;
        }
    }
}
