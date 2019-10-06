using Domain;
using Microsoft.EntityFrameworkCore;
using System;


namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Activity> Values { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
