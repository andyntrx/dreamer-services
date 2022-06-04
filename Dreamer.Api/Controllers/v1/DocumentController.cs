using Dreamer.Application.Documents;
using Dreamer.Application.Features.Documents;
using Dreamer.Application.Features.Healths;
using Dreamer.Application.Features.Taxes;
using Dreamer.Domain.Entities.Documents;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Dreamer.Aura.Api.Controllers.v1
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class DocumentController : BaseApiController
    {
        readonly IHostingEnvironment _hostingEnvironment;
        public DocumentController(IMediator mediator,
                                  IHostingEnvironment hostingEnvironment)
            : base(mediator) {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddDocumentCommand document) => await ProcessUploadDocument(document);


        [HttpGet("{docType}/{year}/{id}")]
        public async Task<IActionResult> GetDocument(DocType docType, Guid id, int year) => Ok(await Mediator.Send(GetDocByType(docType, id, year)));


        [HttpGet("id")]
        public async Task<IActionResult> GetFile([FromQuery] Guid id)
        {

            var document = await Mediator.Send(new GetDocumentFile { DocumentId = id });
            if (document != null)
            {
                var content = new System.IO.MemoryStream(document.Blob);
                var contentType = "application/octet-stream";
                return File(content, contentType, document.FileName);
            }

            return NotFound();
        }

        private object GetDocByType(DocType docType, Guid id, int year)
        {
            return docType switch
            {
                DocType.Health => new GetClientHealthDocument { ClientId = id, Start = year },
                DocType.Tax => new GetClientTaxDocument { ClientId = id, Start = year },
                _ => throw new InvalidOperationException()
            };
        }

        private async Task<IActionResult> ProcessUploadDocument(AddDocumentCommand document)
        {
            var uniqueFileName = GetUniqueFileName(document.File.FileName);
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            var filePath = Path.Combine(uploads, uniqueFileName);

            document.File.CopyTo(new FileStream(filePath, FileMode.Create));

            return  Ok(await Mediator.Send(document));
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}
