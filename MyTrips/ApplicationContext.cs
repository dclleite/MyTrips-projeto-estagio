using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using MyTrips.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrips
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext( DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Host>().HasKey( t => t.Id);
            modelBuilder.Entity<City>();
        }
    }
}
