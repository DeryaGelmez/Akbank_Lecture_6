﻿using Microsoft.EntityFrameworkCore;
using ReDoMusic.Domain.Common;
using RedoMusic.Persistence;

using System.Diagnostics.Metrics;

namespace Week_6_4.Persistence.Contexts
{
    public class ReDoMusicDbContext : DbContext
    {
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configurations.GetString("ConnectionStrings:PostgreSQL"));
        }
    }
}