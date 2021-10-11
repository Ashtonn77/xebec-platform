using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Configurations.Entities;
using XebecPortal.Shared.GamifiedAplication;

namespace Server.GamifiedAplication
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
            
        public DbSet<AppUser> AppUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}