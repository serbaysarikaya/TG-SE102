﻿using Core.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {


        }
        public virtual DbSet<Category> Categories{ get; set; }
        public virtual DbSet<Product> Products{ get; set; }

    }
}
