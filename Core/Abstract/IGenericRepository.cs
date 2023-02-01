using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public interface IGenericRepository<T> where T : class

    {
        IEnumerable<T?> ReadMany(Expression<Func<T, bool>>? predicate = null);
        Task<IEnumerable<T?>> ReadManyAsync(Expression<Func<T, bool>>? predicate = null);


    }
}
