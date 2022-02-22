using Microsoft.EntityFrameworkCore;
using moment3_2.Models;
using System;
namespace moment3_2.Data
{
    public class CdContext : DbContext
    {
        public CdContext(DbContextOptions<CdContext> options) : base(options)
        {
        }

        public DbSet<Cd> Cd { get; set; }
        public DbSet<Artist> Artist { get; set; }
    }
}
