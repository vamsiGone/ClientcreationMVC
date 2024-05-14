using ClientCreation.Data;
using ClientCreation.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClientCreation.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RegistrationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(RegistrationDbContext db)
        {
            _db = db;
            //_db.Product.Include(u=>u.Employees).Include(u=>u.CoverType);
            this.dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }
       
        public IEnumerable<T> GetAll(string? includeprop = null)
        {
            IQueryable<T> query = dbSet;
            if (includeprop != null)
            {
                foreach (var incl in includeprop.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(incl);
                }
            }
            return query.ToList();
        }

        public T GetFirstorDefault(Expression<Func<T, bool>> filter, string? includeprop = null)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            if (includeprop != null)
            {
                foreach (var incl in includeprop.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(incl);
                }
            }
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
