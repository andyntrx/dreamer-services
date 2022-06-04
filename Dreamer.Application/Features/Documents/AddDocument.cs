using Dreamer.Application.Abstractions;
using Dreamer.Application.Documents;
using Dreamer.Domain.Entities.Documents;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Documents
{
    public class AddDocumentCommand : IRequest
    {
        public DocType DocType { get; set; }
        public string Name { get; set; }
        public IFormFile File { set; get; }

        public class Handler : IRequestHandler<AddDocumentCommand>
        {
            readonly IDreamContext _context;
            readonly IHostingEnvironment _hosting;

            public Handler(IDreamContext context,
                           IHostingEnvironment hosting )
            {
                _context = context;
                _hosting = hosting;
            }

            public async Task<Unit> Handle(AddDocumentCommand request, CancellationToken cancellationToken)
            {
                //Getting file meta data
                var fileName = Path.GetFileName(request.File.FileName);

                _context.Documents.Add(new Document
                {
                    Created = DateTime.Now,
                    Name = request.Name,
                });

                await _context.SaveChangesAsync();

                return Unit.Value;
            }


        }
    }
}
