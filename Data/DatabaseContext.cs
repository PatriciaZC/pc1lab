  
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace pc1lab.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
        : base(options)
        {
        }

         public DbSet<pc1lab.Models.Registro> Registro { get; set; }
    }
}