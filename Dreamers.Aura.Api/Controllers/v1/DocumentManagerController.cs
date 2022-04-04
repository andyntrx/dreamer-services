using Dreamers.Application.Features.Documents;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dreamers.Aura.Api.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentManagerController : BaseApiController
    {
        public DocumentManagerController(IMediator mediator) : base(mediator)
        {

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddDocument document)
        {
            return Ok(await Mediator.Send(document));
        }

    }
}
