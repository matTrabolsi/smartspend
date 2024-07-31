using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace spendsmart.Models 
{
    public class SpendSmartDbContext : DbContext
    {
        public DbSet<Expense> Expenses{ get; set; }

        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options)
            :base(options)
        {
            
        }

    }
}