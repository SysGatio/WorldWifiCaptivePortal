namespace WorldWifiCaptivePortal.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static void ConfigurarDemaisServicos(this IServiceCollection services)
    {
        services.AddCors(opt =>
        {
            opt.AddDefaultPolicy(p =>
            {
                p.AllowAnyOrigin();
                p.AllowAnyHeader();
                p.AllowAnyMethod();
            });
        });

        services
            .AddApiVersioning(x =>
            {
                x.AssumeDefaultVersionWhenUnspecified = true;
                x.DefaultApiVersion = new ApiVersion(1.0);
            })
            .AddApiExplorer(x =>
            {
                x.GroupNameFormat = "'v'VVV";
                x.SubstituteApiVersionInUrl = true;
            });

        services.AddControllers();

        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen();
    }
}
