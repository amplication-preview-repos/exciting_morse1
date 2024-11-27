using Microsoft.AspNetCore.Mvc;

namespace NewsManagementSystem.APIs;

[ApiController()]
public class NewsItemsController : NewsItemsControllerBase
{
    public NewsItemsController(INewsItemsService service)
        : base(service) { }
}
