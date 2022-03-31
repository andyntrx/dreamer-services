using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Clients
{
    public class AddClientProfileCommand : IRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
    }

    public class AddClientProfile : IRequestHandler<AddClientProfileCommand>
    {
        readonly DreamContext _context;
        public AddClientProfile(DreamContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AddClientProfileCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return Unit.Value;

            var cp = new Domain.Entities.ClientProfile
            {

            };

            _context.ClientProfiles.Add(cp);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
