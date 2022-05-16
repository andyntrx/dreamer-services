using Dreamer.Application.Documents;
using Dreamer.Application.Features.Documents;
using Dreamer.Application.Features.Healths;
using Dreamer.Application.Features.Taxes;
using Dreamer.Domain.Entities.Documents;
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
        public DocumentController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddDocument document)
        {
            return Ok(await Mediator.Send(document));
        }


        [HttpGet("{docType}/{year}/{id}")]
        public async Task<IActionResult> GetDocument(DocType docType, Guid id, int year) => Ok(await Mediator.Send(GetDocByType(docType, id, year)));


        private object GetDocByType(DocType docType, Guid id, int year)
        {
            return docType switch
            {
                DocType.Health => new GetClientHealthDocument { ClientId = id, Start = year },
                DocType.Tax => new GetClientTaxDocument { ClientId = id, Start = year },
                _ => throw new InvalidOperationException()
            };
        }
    }
}
