using Dreamer.Application.Clients;
using Dreamer.Application.Features.Clients;
using Dreamer.Aura.Api.Filters;
using Dreamer.Aura.Api.Helpers;
using Dreamer.Aura.Api.Wrappers;
using Dreamer.Domain.Entities;
using Dreamer.Domain.Entities.Clients;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dreamer.Aura.Api.Controllers.v1
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class ClientProfileController : BaseApiController
    {
        public ClientProfileController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet]
        public async Task<PagedResponse<List<ClientProfile>>> Get([FromQuery] PaginationFilter filter)
        {
            var result = await Mediator.Send(new GetAllClientPagingationQuery { Limit = filter.Limit, Page = filter.Page });
            return PaginationHelpers.CreatePagedReponse(result.Data.ToList(), result.Total, filter);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) => Ok(await Mediator.Send(new GetClientProfile { Ucid = id }));

        [HttpPost]
        public async Task<IActionResult> Post(CreateClientProfile profile)
        {
            if (profile == null)
                return BadRequest("Client profile is invalid");

            var result = Mediator.Send(profile);

            return Ok();
        }

    }
}
