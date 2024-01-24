using Microsoft.AspNetCore.Mvc;
using SharpCountriesProg.Models;
using SharpRepositoryServiceProg.AAPublic;

namespace ReactApp1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly ILogger<Country> _logger;
        private readonly IRepositoryService repositoryService;

        public CountriesController(
            ILogger<Country> logger,
            IServiceProvider provider)
        {
            _logger = logger;
            repositoryService = provider.GetService<IRepositoryService>();
        }

        [HttpGet(Name = "GetCountries")]
        [Produces("application/json")]
        public IEnumerable<Country> Get()
        {
            var repo = repositoryService.Uow.GetRepository<Country>();
            var paginate = repo.GetList();
            var countriesList = paginate.Items.ToArray();

            return countriesList;
        }
    }
}
