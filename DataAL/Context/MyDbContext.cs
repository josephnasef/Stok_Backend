
using DataAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL.Context
{
    public class MyDbContext : IdentityDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
          : base(options)
        {
        }
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Stock> Stocks { get; set; }

   
        
    }
}
