using Lost_And_Found.Core.Interfaces;
using Lost_And_Found.Core.Services;
using Lost_And_Found.Infrastructure.Data;
using Lost_And_Found.Infrastructure.Data.Queries;
using Lost_And_Found.UseCases.Contributors.List;
using Lost_And_Found.Web.LostItems.List;


namespace Lost_And_Found.Infrastructure;
public static class InfrastructureServiceExtensions
{
  public static IServiceCollection AddInfrastructureServices(
    this IServiceCollection services,
    ConfigurationManager config,
    ILogger logger)
  {
    string? connectionString = config.GetConnectionString("DefaultConnection");
    Guard.Against.Null(connectionString);
    services.AddDbContext<AppDbContext>(options =>
     options.UseSqlServer(connectionString));

    services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>))
           .AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>))
           .AddScoped<IListContributorsQueryService, ListContributorsQueryService>()
           .AddScoped<IDeleteContributorService, DeleteContributorService>()
           .AddScoped<IDeleteLostItemService, DeleteLostItemService>()
           .AddScoped<IListLostItemsQueryService, ListLostItemsQueryService>();


    logger.LogInformation("{Project} services registered", "Infrastructure");

    return services;
  }
}
