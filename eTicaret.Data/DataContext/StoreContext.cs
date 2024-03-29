﻿using eTicaret.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace eTicaret.Data.DataContext
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
