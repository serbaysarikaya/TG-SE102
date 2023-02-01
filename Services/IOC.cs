using Core.Abstract;
using Core.Abstract.Services;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class IOC 
    {
        public static void AddBaseServices(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(@"Server=.;Database=TG-SE201;Trusted_Connection=true;MultipleActiveResultSets=true;"));
            services.AddScoped<IUnitOfWork,  UnitOfWorks>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
