using Core.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _set;

        protected GenericRepository(DbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }

        public virtual IEnumerable<T?> ReadMany(Expression<Func<T, bool>>? predicate = null)
        {
            return predicate != null ? _set.Where(predicate) : _set;
        }

        public virtual async Task<IEnumerable<T>> ReadManyAsync(Expression<Func<T, bool>>? predicate = null)
        {
            return predicate != null ? _set.Where(predicate) : _set;
        }

    }
}
