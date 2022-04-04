using Dreamers.Domain.Entities.Documents;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Documents
{
    public class AddDocument : IRequest
    {
    }

    public class AddDocumentHandler : IRequestHandler<AddDocument>
    {
        readonly DreamContext _context;
        public AddDocumentHandler(DreamContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AddDocument request, CancellationToken cancellationToken)
        {
            _context.Documents.Add(new Document
            {

            });

            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
