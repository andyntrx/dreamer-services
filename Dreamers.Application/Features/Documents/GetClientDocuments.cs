using Dreamers.Domain.Entities.Documents;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Documents
{
    public class GetClientDocuments : IRequest<IEnumerable<Document>>
    {
        public Guid ClientUcid { get; set; }
    }

    public class GetClientDocumentHandler : IRequestHandler<GetClientDocuments, IEnumerable<Document>>
    {
        readonly DreamContext _context;
        public GetClientDocumentHandler(DreamContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Document>> Handle(GetClientDocuments request, CancellationToken cancellationToken)
        {
            return _context.Documents.Where(d => d.RefUcid == request.ClientUcid).ToList();
        }
    }
}
