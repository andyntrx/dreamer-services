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
    public class GetDocumentFile : IRequest<Document>
    {
        public Guid DocumentId { get; set; }

        public class Handler : IRequestHandler<GetDocumentFile, Document>
        {
            readonly IDreamContext _context;

            public Handler(IDreamContext context)
            {
                _context = context;
            }

            public async Task<Document> Handle(GetDocumentFile request, CancellationToken cancellationToken)
            {
               return _context.Documents.Find(request.DocumentId);
            }
        }
    }
}
