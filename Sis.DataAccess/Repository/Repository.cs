using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sis.DataAccess.Repository.IRepository;
using SistemaRestaurante.Sis.DataAccess.Data;

namespace Sis.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RestauranteDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(RestauranteDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();  
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query.Where(filter);
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
