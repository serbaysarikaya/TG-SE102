using Core.Abstract;
using Core.Abstract.Services;
using Core.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWorks;

        public ProductService(IUnitOfWork unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            var data = from p in await _unitOfWorks._productRepository.ReadManyAsync()
                       select new ProductDTO
                       {
                           Id = p.Id,
                           Title = p.Title,
                           Description = p.Description,
                           CategoryId = p.CategoryId,
                           Price = p.Price,
                           CategoryName =p.Category.Title

                       };


           return data;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllByCategory(int categryId)
        {

            var data = from p in await _unitOfWorks._productRepository.ReadManyAsync(x=>x.CategoryId==categryId)
                       select new ProductDTO
                       {
                           Id = p.Id,
                           Title = p.Title,
                           Description = p.Description,
                           CategoryId = p.CategoryId,
                           Price = p.Price,
                           CategoryName = p.Category.Title

                       };


            return data;
        }
    }
}
