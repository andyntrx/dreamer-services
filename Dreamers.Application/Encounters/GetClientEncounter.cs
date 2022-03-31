using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Encounters
{
    public class GetClientEncounter : IRequest
    {
        public Guid ClientUcid { get; set; }
    }

    public class GetClientEncounterHandler : IRequestHandler<GetClientEncounter>
    {
        readonly DreamContext _context;
        public GetClientEncounterHandler(DreamContext context)
        {
            _context = context;
        }


        public Task<Unit> Handle(GetClientEncounter request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
