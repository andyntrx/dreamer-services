using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Documents
{
    public class AddDocument : IRequest
    {
    }

    public class AddDocumentHandler : IRequestHandler<AddDocument>
    {
        readonly IDreamContext _context;
        public AddDocumentHandler(IDreamContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AddDocument request, CancellationToken cancellationToken)
        {
            /*
            _context.Documents.Add(new Document
            {

            });*/

            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
