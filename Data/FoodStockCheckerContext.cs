using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodStockChecker.Models;

namespace FoodStockChecker.Data
{
    public class FoodStockCheckerContext : DbContext
    {
        public FoodStockCheckerContext (DbContextOptions<FoodStockCheckerContext> options)
            : base(options)
        {
        }

        public DbSet<FoodStockChecker.Models.food> food { get; set; }

        public DbSet<FoodStockChecker.Models.Recipe> Recipe { get; set; }
    }
}
