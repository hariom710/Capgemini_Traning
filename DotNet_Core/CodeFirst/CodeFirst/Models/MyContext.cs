using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    internal class MyContext : DbContext
    {
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Dept> Depts { get; set; }

        public MyContext()
        {
        }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=HARRY-DEVRIG\SQLEXPRESS;Initial Catalog=AprDB;trusted_connection=true;encrypt=false");
            }
        }
    }
}
