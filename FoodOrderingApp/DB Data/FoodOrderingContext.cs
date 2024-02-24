using FoodOrderingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp.DB_Data
{
    public class FoodOrderingContext : DbContext
    {
        public FoodOrderingContext(DbContextOptions<FoodOrderingContext> option) : base(option)
        {

        }

        public DbSet<AddCustomer> AddCustomers { get; set; }

        public DbSet<OrderMenu> orderMenus { get; set; }
    }
}
