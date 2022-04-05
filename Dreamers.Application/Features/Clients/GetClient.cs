using Dreamers.Domain.Entities.Clients;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Clients
{
    public class GetClient : IRequest<Client>
    {
        public Guid Ucid { get; set; }
    }

    public class GetClientHandler : IRequestHandler<GetClient, Client>
    {
        readonly DreamContext _context;

        public GetClientHandler(DreamContext context)
        {
            _context = context;
        }

        public async Task<Client> Handle(GetClient request, CancellationToken cancellationToken)
        {
            var cp = await _context.Clients.FindAsync(request.Ucid);
            return cp;
        }
    }
}
