using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities;
using Dreamer.Domain.Entities.Clients;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Clients
{
    public class GetClientProfile : IRequest<ClientProfile>
    {
        public Guid Ucid { get; set; }
    }

    public class GetClientProfileHandler : IRequestHandler<GetClientProfile, ClientProfile>
    {
        readonly IDreamContext _context;

        public GetClientProfileHandler(IDreamContext context)
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
