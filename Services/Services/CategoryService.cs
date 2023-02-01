using Core.Abstract.Services;
using Core.Abstract;
using Core.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork _unitOfWorks;

        public CategoryService(IUnitOfWork unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }
        public async Task<IEnumerable<CategoryDTO>> GetAll()
        {
            return from c in await _unitOfWorks._categoryRepository.ReadManyAsync()
                   select new CategoryDTO
                   {
                       Id = c.Id,
                       Title = c.Title,
                       Description = c.Description

                   };
        }
    }
}
