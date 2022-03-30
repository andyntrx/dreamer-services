using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Dreamers.Aura.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {

        protected readonly IMediator Mediator;
        public BaseApiController(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
