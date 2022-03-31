using Dreamers.Application.Clients.Events;
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
        public CreateClientProfile(DreamContext context)
                                 //  IClientProfileCreateEventPublisher createdEventPublisher)
        {
           // _createdEventPublisher = createdEventPublisher;
            _context = context;
        }

        public async Task<Unit> Handle(CreateClientProfileCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return Unit.Value;

            var cp = new Domain.Entities.Clients.ClientProfile
            {

            };

            _context.ClientProfiles.Add(cp);
            await _context.SaveChangesAsync();


            //await _createdEventPublisher.Publish(new ClientProfileCreateEvent { });

            return Unit.Value;
        }
    }
}
