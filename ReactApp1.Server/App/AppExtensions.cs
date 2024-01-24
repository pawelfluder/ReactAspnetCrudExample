using SharpIdentityProg.AAPublic;
using SharpRepositoryServiceProg.AAPublic;
using OutBorder1 = SharpRepositoryServiceProg.AAPublic.OutBorder;

namespace ReactApp1.Server.Extensions
{
    public static class AppExtensions
    {
        public static void AddAll(this IHostApplicationBuilder builder)
        {
            builder.AddIdentity();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins("https://localhost:5173")
                            .AllowAnyHeader()
                            .AllowAnyMethod();

                        builder.WithOrigins("https://localhost:7249")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            builder.Services.AddSingleton(OutBorder1.RepositoryService());

            builder.Services.AddCors();
        }

        public static void UseAll(this WebApplication app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            var configuration = app.Services.GetService<IConfiguration>();
            var repoService = app.Services.GetService<IRepositoryService>();
            repoService.Initialize(configuration);

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseIdentity();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.MapFallbackToFile("/index.html");
        }
    }
}
