using Dreamer.Application.Features.Encounters;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dreamer.Aura.Api.Controllers.v1
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class ClientServiceController :  BaseApiController
    {

        public ClientServiceController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet("{ucid}")]
        public async Task<IActionResult> Get(Guid ucid) => Ok(await Mediator.Send(new GetClientService { ClientUcid = ucid }));
    }
}
