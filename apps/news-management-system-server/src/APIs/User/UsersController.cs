using Microsoft.AspNetCore.Mvc;

namespace NewsManagementSystem.APIs;

[ApiController()]
public class UsersController : UsersControllerBase
{
    public UsersController(IUsersService service)
        : base(service) { }
}
