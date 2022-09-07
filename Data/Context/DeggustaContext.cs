using DeggustaAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeggustaAPI.Data.Context
{
    public class DeggustaContext : DbContext
    {
        public DeggustaContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<User>? User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }


    }
}
