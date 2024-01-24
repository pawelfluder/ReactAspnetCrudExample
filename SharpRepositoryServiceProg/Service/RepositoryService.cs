using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharpRepositoryServiceProg.AAPublic;
using Threenine.Data;

namespace SharpRepositoryServiceProg.Service
{
    internal class RepositoryService : IRepositoryService
    {
        public IUnitOfWork Uow { get; private set; }

        public RepositoryService()
        {
            Uow = new UnitOfWork();
        }

        private IConfiguration GetConfiguration(IServiceCollection serviceCollection)
        {
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var configuration = serviceProvider.GetRequiredService<IConfigurationRoot>();
            return configuration;
        }

        public void Initialize(IConfiguration configuration)
        {
            ((Initialize)Uow).Initialize(configuration);
        }
    }
}
