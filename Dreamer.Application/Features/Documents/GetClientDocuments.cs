using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Documents
{
    public class GetClientDocuments : IRequest<IEnumerable<Document>>
    {
        public Guid ClientUcid { get; set; }
    }

    public class GetClientDocumentHandler : IRequestHandler<GetClientDocuments, IEnumerable<Document>>
    {
        readonly IDreamContext _context;
        public GetClientDocumentHandler(IDreamContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Document>> Handle(GetClientDocuments request, CancellationToken cancellationToken)
        {
            return _context.Documents.Where(d => d.RefUcid == request.ClientUcid).ToList();
        }
    }
}
