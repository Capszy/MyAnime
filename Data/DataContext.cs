using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Register> Register { get; set; }
    }
}
