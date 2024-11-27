using Microsoft.AspNetCore.Mvc;

namespace NewsManagementSystem.APIs;

[ApiController()]
public class UserTypesController : UserTypesControllerBase
{
    public UserTypesController(IUserTypesService service)
        : base(service) { }
}
