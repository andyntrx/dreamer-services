using Dreamers.Application.Features.Documents;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dreamers.Aura.Api.Controllers.v1
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class ClientDocumentController : BaseApiController
    {
        public ClientDocumentController(IMediator mediator) : base(mediator)
        {

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await Mediator.Send(new GetClientDocuments { ClientUcid = id });
            return Ok(result);
        }
    }
}
