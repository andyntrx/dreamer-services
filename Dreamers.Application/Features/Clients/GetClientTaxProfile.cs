using Dreamers.Domain.Entities.Taxes;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Clients
{
    public class GetClientTaxProfile : IRequest<ClientTaxProfile>
    {
        public Guid Ucid { get; set; }
    }

    public class GetClientTaxProfileHandler : IRequestHandler<GetClientTaxProfile, ClientTaxProfile>
    {
        readonly DreamContext _context;
        public GetClientTaxProfileHandler(DreamContext context)
        {
            _context = context;
        }

        public async Task<ClientTaxProfile> Handle(GetClientTaxProfile request, CancellationToken cancellationToken)
        {
            var client = await _context.Clients.FindAsync(request.Ucid);

            return new ClientTaxProfile
            {

            };
        }
    }
}
