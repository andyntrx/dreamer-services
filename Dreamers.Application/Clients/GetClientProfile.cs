using Dreamers.Domain.Entities;
using Dreamers.Domain.Entities.Clients;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Clients
{
    public class GetClientProfile : IRequest<ClientProfile>
    {
        public Guid Ucid { get; set; }
    }

    public class GetClientProfileHandler : IRequestHandler<GetClientProfile, ClientProfile>
    {
        readonly DreamContext _context;

        public GetClientProfileHandler(DreamContext context)
        {
            _context = context;
        }

        public async Task<ClientProfile> Handle(GetClientProfile request, CancellationToken cancellationToken)
        {
            var cp = _context.ClientProfiles.FirstOrDefault(c => c.Ucid == request.Ucid);
            return cp;

        }
    }
}
