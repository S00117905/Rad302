using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Champions_League.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Champions_League.DAL
{
    public class LeagueContext : DbContext
    {
        public LeagueContext() : base("LeagueContext")
        {
        }
        
        public DbSet<Team> Teams { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<League> Leagues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}