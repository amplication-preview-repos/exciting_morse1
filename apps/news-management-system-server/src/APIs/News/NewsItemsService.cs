using NewsManagementSystem.Infrastructure;

namespace NewsManagementSystem.APIs;

public class NewsItemsService : NewsItemsServiceBase
{
    public NewsItemsService(NewsManagementSystemDbContext context)
        : base(context) { }
}
