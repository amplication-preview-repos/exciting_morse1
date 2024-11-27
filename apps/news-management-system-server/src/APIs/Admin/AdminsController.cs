using Microsoft.AspNetCore.Mvc;

namespace NewsManagementSystem.APIs;

[ApiController()]
public class AdminsController : AdminsControllerBase
{
    public AdminsController(IAdminsService service)
        : base(service) { }
}
