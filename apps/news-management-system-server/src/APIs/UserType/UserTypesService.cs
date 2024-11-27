using NewsManagementSystem.Infrastructure;

namespace NewsManagementSystem.APIs;

public class UserTypesService : UserTypesServiceBase
{
    public UserTypesService(NewsManagementSystemDbContext context)
        : base(context) { }
}
