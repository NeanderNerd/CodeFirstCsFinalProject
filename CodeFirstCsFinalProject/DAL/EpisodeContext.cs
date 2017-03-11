using System;
using CodeFirstCsFinalProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirstCsFinalProject.DAL
{
    public class EpisodeContext : DbContext
    {
        public EpisodeContext() : base("EpisodeContext")
        {

        }

        public DbSet<Episode> Episodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}