using Core.Abstract.Repositories;
using Core.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetAllProductByCategory(int categryId)
        {
            return await ReadManyAsync(x=>x.CategoryId==categryId);

        }

        public override async Task<IEnumerable<Product>> ReadManyAsync(Expression<Func<Product, bool>>? predicate = null)
        {
            var data = _set.Include(c => c.Category);

            return predicate != null ? data.Where(predicate) : data; 
        }
    }
}
