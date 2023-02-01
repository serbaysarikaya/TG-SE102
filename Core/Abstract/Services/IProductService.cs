using Core.Concrete.DTOs;
using System.Collections.Generic;

namespace Core.Abstract.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAll();
        Task<IEnumerable<ProductDTO>> GetAllByCategory(int categryId);


    }
}
