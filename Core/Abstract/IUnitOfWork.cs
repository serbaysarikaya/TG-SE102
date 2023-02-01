using Core.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository _productRepository { get; }
        ICategoryRepository _categoryRepository { get; }
        void Commit();
        Task CommitAsync();
    }
}
