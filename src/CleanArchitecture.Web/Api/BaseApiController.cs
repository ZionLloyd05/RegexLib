using Microsoft.AspNetCore.Mvc;

namespace RegexLib.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
