using Dreamers.Domain.Entities;
using Dreamers.Domain.Entities.Clients;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Clients
{
    public class AddDependants : Dependant, IRequest
    {

    }

    public class AddDependantsHandler : IRequestHandler<AddDependants>
    {
        readonly DreamContext _context;
        public AddDependantsHandler(DreamContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AddDependants request, CancellationToken cancellationToken)
        {
            _context.Dependants.Add(request as Dependant);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }

}
