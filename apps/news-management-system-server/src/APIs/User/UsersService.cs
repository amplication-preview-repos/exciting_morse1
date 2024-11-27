using NewsManagementSystem.Infrastructure;

namespace NewsManagementSystem.APIs;

public class UsersService : UsersServiceBase
{
    public UsersService(NewsManagementSystemDbContext context)
        : base(context) { }
}
