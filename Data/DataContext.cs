using desafio01.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio01.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }

        public DbSet<Tool> Tools { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}