using Microsoft.EntityFrameworkCore;
using SharpCountriesProg.Repet;

namespace SharpCountriesProg.Models
{
    public class CountriesDbContext : DbContext
    {
        private string connectionString = "Data Source=TemporaryName.db";

        public DbSet<Country> Countries { get; set; }

        public string ConnectionString => connectionString;

        public CountriesDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public CountriesDbContext()
        {
            this.connectionString = new ConnectionStringHelper().Get();
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (connectionString.StartsWith("Server="))
            {
                optionsBuilder.UseSqlServer(connectionString);
                return;
            }

            if (connectionString.StartsWith("Data Source="))
            {
                optionsBuilder.UseSqlite(connectionString);
                return;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasKey(b => b.Id);

            // modelBuilder.Seed();
        }
    }
}