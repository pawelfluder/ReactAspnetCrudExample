using Microsoft.Extensions.Configuration;
using SharpRepositoryServiceProg.Configurations;
using Threenine.Data;

namespace SharpRepositoryServiceProg
{
    public class UnitOfWork : IUnitOfWork, Initialize
    {
        private IConfiguration configuration;
        private IdentityRepo identityRepo;
        private CountryRepo countryRepo;

        public UnitOfWork()
        {
        }

        public void Initialize(IConfiguration configuration)
        {
            this.configuration = configuration;
            var connectionString = new ConnectionStringHelper().Get(configuration);
            countryRepo = new CountryRepo(this, connectionString);
            identityRepo = new IdentityRepo(connectionString);
        }

        public int Commit()
        {
            var result = countryRepo.Commit();
            return result;
        }

        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }

        public IDeleteRepository<TEntity> DeleteRepository<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IRepositoryReadOnly<TEntity> GetReadOnlyRepository<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IRepositoryReadOnlyAsync<TEntity> GetReadOnlyRepositoryAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            var result = (IRepository<TEntity>)countryRepo;
            return result;
        }

        public IRepositoryAsync<TEntity> GetRepositoryAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
