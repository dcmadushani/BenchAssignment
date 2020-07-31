using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OnlineStore.DataAccess.Models;
using System.Linq.Expressions;

namespace OnlineStore.DataAccess.Reposotories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ///// <summary>
        ///// Find all
        ///// </summary>
        ///// <returns></returns>
        //IEnumerable<T> FindAll();

        ///// <summary>
        ///// Count the specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //int Count(Expression<Func<T, bool>> predicate);

        ///// <summary>
        ///// Get items which matched to the specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //bool Any(Expression<Func<T, bool>> predicate);

        ///// <summary>
        ///// Get all the specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //bool All(Expression<Func<T, bool>> predicate);

        ///// <summary>
        ///// Get first or default value for specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //T FirstOrDefault(Expression<Func<T, bool>> predicate);

        ///// <summary>
        ///// Get first values for specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //T First(Expression<Func<T, bool>> predicate);

        ///// <summary>
        ///// Get single or default value for specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //T SingleOrDefault(Expression<Func<T, bool>> predicate);

        ///// <summary>
        ///// Get single value for specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //T Single(Expression<Func<T, bool>> predicate);

        ///// <summary>
        ///// Get the items which matched specified predicate
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <returns></returns>
        //IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        ///// <summary>
        ///// Gets by id
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //T GetById(long id);

        ///// <summary>
        ///// Adds the specified entity
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //T Add(T entity);

        ///// <summary>
        ///// Update specified entity
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //T Update(T entity);

        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(object Id);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Remove(object Id);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
