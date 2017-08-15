using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZenLeapApi.Repositories
{
    /// <summary>
    /// Generic Repository Interface modeled from: http://www.remondo.net/repository-pattern-example-csharp/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Update(T entity);
        void SaveChanges();
        void Rollback();

        Task<IEnumerable<T>> SearchForAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id);
        Task UpdateAsync(T entity);
        Task SaveChangesAsync();
    }
}
 