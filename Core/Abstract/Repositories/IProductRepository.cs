using Core.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract.Repositories
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllProductByCategory(int categryId);
    }
}
