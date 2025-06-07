using Lost_And_Found.UseCases.LostItems;
using LostAndFound.Project.Core.LostItemAggregate;

namespace Lost_And_Found.Web.Configurations;

public class MapperConfig
{
  public static void ConfigureMapper(IServiceCollection services)
  {
    services.AddAutoMapper(cfg =>
    {
     cfg.CreateMap<LostItem,LostItemDTO>();
    });
  }
}
