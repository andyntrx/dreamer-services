using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities;
using Dreamer.Domain.Entities.Clients;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Clients
{
    public class AddDependants : Dependant, IRequest
    {

    }

    public class AddDependantsHandler : IRequestHandler<AddDependants>
    {
        readonly IDreamContext _context;
        public AddDependantsHandler(IDreamContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AddDependants request, CancellationToken cancellationToken)
        {
          ///  _context.Dependants.Add(request as Dependant);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }

}
