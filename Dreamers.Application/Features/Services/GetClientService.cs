using Dreamers.Domain.Entities.Clients;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Encounters
{
    public class GetClientService : IRequest<ClientService>
    {
        public Guid ClientUcid { get; set; }
    }

    public class GetClientServiceHandler : IRequestHandler<GetClientService, ClientService>
    {
        readonly DreamContext _context;
        public GetClientServiceHandler(DreamContext context)
        {
            _context = context;
        }

        public async Task<ClientService> Handle(GetClientService request, CancellationToken cancellationToken)
        {
            return _context.ClientServices.Where(c => c.ClientUcid == request.ClientUcid).SingleOrDefault();
        }
    }
}
