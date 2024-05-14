using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClientCreation.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T in Employee

        T GetFirstorDefault(Expression<Func<T, bool>> filter, string? includeprop = null);
        IEnumerable<T> GetAll(string? includeprop = null);

        void Add(T entity);
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}
