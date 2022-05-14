using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities.Taxes;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Clients
{
    public class GetClientTaxProfile : IRequest<ClientTaxProfile>
    {
        public Guid Ucid { get; set; }
    }

    public class GetClientTaxProfileHandler : IRequestHandler<GetClientTaxProfile, ClientTaxProfile>
    {
        readonly IDreamContext _context;
        public GetClientTaxProfileHandler(IDreamContext context)
        {
            _context = context;
        }

        public async Task<ClientTaxProfile> Handle(GetClientTaxProfile request, CancellationToken cancellationToken)
        {
           // var client = await _context.Clients.FindAsync(request.Ucid);

            return new ClientTaxProfile
            {

            };
        }
    }
}
