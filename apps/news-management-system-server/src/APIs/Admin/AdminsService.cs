using NewsManagementSystem.Infrastructure;

namespace NewsManagementSystem.APIs;

public class AdminsService : AdminsServiceBase
{
    public AdminsService(NewsManagementSystemDbContext context)
        : base(context) { }
}
