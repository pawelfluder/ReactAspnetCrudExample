using Microsoft.Extensions.Configuration;
using Threenine.Data;

namespace SharpRepositoryServiceProg.AAPublic
{
    public interface IRepositoryService
    {
        IUnitOfWork Uow { get; }

        void Initialize(IConfiguration configuration);
    }
}