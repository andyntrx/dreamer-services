using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities.Clients;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Clients
{
    public class GetClient : IRequest<Client>
    {
        public Guid Ucid { get; set; }
    }

    public class GetClientHandler : IRequestHandler<GetClient, Client>
    {
        readonly IDreamContext _context;

        public GetClientHandler(IDreamContext context)
        {
            _context = context;
        }

        public async Task<Client> Handle(GetClient request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();

            //var cp = await _context.Clients.FindAsync(request.Ucid);
            //return cp;
        }
    }
}
