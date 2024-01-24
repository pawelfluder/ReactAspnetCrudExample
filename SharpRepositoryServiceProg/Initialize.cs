using Microsoft.Extensions.Configuration;

namespace SharpRepositoryServiceProg
{
    internal interface Initialize
    {
        void Initialize(IConfiguration configuration);
    }
}