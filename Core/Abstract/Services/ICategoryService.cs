﻿using Core.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAll();

    }
}
