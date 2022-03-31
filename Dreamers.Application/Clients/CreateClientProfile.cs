using Dreamers.Application.Clients.Events;
using Dreamers.Domain.Entities.Clients;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Clients
{
    public class CreateClientProfileCommand : IRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
    }

    public class CreateClientProfile : IRequestHandler<CreateClientProfileCommand>
    {
       // readonly IClientProfileCreateEventPublisher _createdEventPublisher;
        readonly DreamContext _context;
        readonly IMediator _mediator;
        public CreateClientProfile(DreamContext context, 
                                   IMediator mediator)
        {
            _context = context;
            _mediator = mediator; 
        }

        public async Task<Unit> Handle(CreateClientProfileCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return Unit.Value;

            var cp = new ClientProfile
            {

            };

            _context.ClientProfiles.Add(cp);
            await _context.SaveChangesAsync();

            // publish events to finish client profile
            await _mediator.Publish(new ClientProfileCreatedEvent(cp.Ucid));

            return Unit.Value;
        }
    }
}
