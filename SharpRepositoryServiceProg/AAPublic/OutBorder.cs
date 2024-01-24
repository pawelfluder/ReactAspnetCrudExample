using Microsoft.Extensions.Configuration;
using SharpRepositoryServiceProg.Service;

namespace SharpRepositoryServiceProg.AAPublic
{
    public static class OutBorder
    {
        public static IRepositoryService RepositoryService()
        {
            return new RepositoryService();
        }
    }
}
