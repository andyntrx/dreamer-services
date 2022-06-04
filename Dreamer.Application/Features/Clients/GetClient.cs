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
    public class GetClientQuery : IRequest<Client>
    {
        public Guid Ucid { get; set; }

        public class Handler : IRequestHandler<GetClientQuery, Client>
        {
            readonly IDreamContext _context;

            public Handler(IDreamContext context)
            {
                _context = context;
            }

            public async Task<Client> Handle(GetClientQuery request, CancellationToken cancellationToken)
            {
                var cp = await _context.Clients.FindAsync(request.Ucid);
                return cp;
            }
        }
    }
}
