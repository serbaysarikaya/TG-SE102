using Core.Abstract;
using Core.Abstract.Repositories;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWorks : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        private IProductRepository product;
        private ICategoryRepository category;

        public UnitOfWorks(DataContext dataContext)
        {
            _dataContext = dataContext;

        }

        public IProductRepository _productRepository => product = product ?? new ProductRepository(_dataContext);
            

        public ICategoryRepository _categoryRepository => category = category?? new CategoryRepository(_dataContext);

        public void Commit()
        {
            _dataContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
