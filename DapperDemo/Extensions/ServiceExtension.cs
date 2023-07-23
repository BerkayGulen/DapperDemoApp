namespace DapperDemo.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>

                builder.AllowAnyOrigin().

                AllowAnyHeader().

                AllowAnyMethod()
                );
            });
        }
        //public static void ConfigureSqlContext(this IServiceCollection services,
        //    IConfiguration configuration)
        //{
        //    services.AddDbContext<ApplicationDbContext>(options =>
        //        options.UseSqlServer(configuration.GetConnectionString("DefaultSQLConnection"))
        //        );
        //}

        //public static void ConfigureLoggerService(this IServiceCollection services)
        //{
        //    services.AddSingleton<ILoggerService, LoggerService>();
        //}
    }
}
