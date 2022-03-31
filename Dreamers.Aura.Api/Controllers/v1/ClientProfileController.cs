using Dreamers.Application.Clients;
using Dreamers.Aura.Api.Filters;
using Dreamers.Aura.Api.Helpers;
using Dreamers.Aura.Api.Wrappers;
using Dreamers.Domain.Entities;
using Dreamers.Domain.Entities.Clients;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dreamers.Aura.Api.Controllers.v1
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
        public async Task<IActionResult> Get(Guid id)
        {
            var result = Mediator.Send(new GetClientProfile { Ucid = id });
            return Ok(result);
        }

    }
}
