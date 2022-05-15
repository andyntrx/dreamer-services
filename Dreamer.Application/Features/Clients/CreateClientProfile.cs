using Dreamer.Application.Abstractions;
using Dreamer.Application.Clients.Events;
using Dreamer.Domain.Entities.Clients;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Clients
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
        readonly IDreamContext _context;
        readonly IMediator _mediator;
        public CreateClientProfile(IDreamContext context, 
                                   IMediator mediator)
        {
            _context = context;
            _mediator = mediator; 
        }

        public async Task<Unit> Handle(CreateClientProfileCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return Unit.Value;

            var clientProfile = new ClientProfile
            {
                FirstName = request.FirstName,
                LastName = request.LastName 
            };

            _context.ClientProfiles.Add(clientProfile);
            await _context.SaveChangesAsync();

            // publish events to finish client profile
            await _mediator.Publish(new ClientProfileCreatedEvent(clientProfile.Ucid));

            return Unit.Value;
        }
    }
}
