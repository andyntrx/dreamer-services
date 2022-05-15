using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities.Healths;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Clients
{
    public class GetClientHealthProfile : IRequest<ClientHealthProfile>
    {
        public Guid Ucid { get; set; }
    }

    public class GetClientHealthProfileHandler : IRequestHandler<GetClientHealthProfile, ClientHealthProfile>
    {
        readonly IDreamContext _context;
        public GetClientHealthProfileHandler(IDreamContext context)
        {
            _context = context;
        }

        public async Task<ClientHealthProfile> Handle(GetClientHealthProfile request, CancellationToken cancellationToken)
        {
            var client = await _context.Clients.FindAsync(request.Ucid);
            return new ClientHealthProfile { };
        }
    }
}
