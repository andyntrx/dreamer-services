using Dreamer.Application.Features.Documents;
using Dreamer.Application.Features.Healths;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dreamer.Aura.Api.Controllers.v1
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class DocumentController : BaseApiController
    {
        public DocumentController(IMediator mediator) : base(mediator)
        {

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddDocument document)
        {
            return Ok(await Mediator.Send(document));
        }

        [HttpGet("health/{year}/{id}")]
        public async Task<IActionResult> Get(Guid id, int year) => Ok(await Mediator.Send(new GetClientHealthDocument { ClientId = id, Start = year }));
       
    }
}
