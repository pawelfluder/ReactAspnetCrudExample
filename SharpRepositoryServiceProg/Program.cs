using SharpCountriesProg.Models;
using SharpRepositoryServiceProg.Service;

namespace SharpRepositoryServiceProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // example 01
            var unitOfWork = new UnitOfWork();
            var product01 = unitOfWork
                .GetRepository<Country>()
                .SingleOrDefault(x => x.Name == "Afghanistan");

            // example 02
            var repoService = new RepositoryService();
            var repo = repoService.Uow
                .GetRepository<Country>();
        }
    }
}
