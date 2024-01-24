using SharpCountriesProg.Models;

namespace SharpCountriesProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new CountriesDbContext();
            var model = db.Countries.ToList();
        }
    }
}