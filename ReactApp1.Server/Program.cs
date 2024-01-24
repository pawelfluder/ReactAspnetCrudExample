using ReactApp1.Server.Extensions;

namespace ReactApp1.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.AddAll();
            var app = builder.Build();
            app.UseAll();
            app.Run();
        }
    }
}
