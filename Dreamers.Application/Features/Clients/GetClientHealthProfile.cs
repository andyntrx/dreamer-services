using Dreamers.Domain.Entities.Healths;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Clients
{
    public class GetClientHealthProfile : IRequest<ClientHealthProfile>
    {
        public Guid Ucid { get; set; }
    }

    public class GetClientHealthProfileHandler : IRequestHandler<GetClientHealthProfile, ClientHealthProfile>
    {
        readonly DreamContext _context;
        public GetClientHealthProfileHandler(DreamContext context)
        {
            _context = context;
        }

        public async Task<ClientHealthProfile> Handle(GetClientHealthProfile request, CancellationToken cancellationToken)
        {
            var client = await _context.Clients.FindAsync(request.Ucid);

            return new ClientHealthProfile
            {

            };
        }
    }
}
