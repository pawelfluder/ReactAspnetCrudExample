using Microsoft.EntityFrameworkCore;

namespace SharpCountriesProg.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var seeder = new Seeder();
            var toSeed = seeder.GetDefault();
            modelBuilder.Entity<Country>()
                .HasData(toSeed);
        }
    }
}
