using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StarWarsUniverseClone.Data.Repositories.Api;
using StarWarsUniverseClone.Domain;

namespace StarWarsUniverseClone.Data
{
    public class StarWarsContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public StarWarsContext() { }
        public StarWarsContext(DbContextOptions<StarWarsContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            const string connectionString = "Server = (localdb)\\MSSQLLocalDB; " +
                                            "Database = StarWarsDB; " +
                                            "Trusted_Connection = True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(m => m.Uri);
            var remoteMovies = new MovieApiRepository().GetAllMovies();
            modelBuilder.Entity<Movie>().HasData(remoteMovies.ToArray());
        }
    }
}
