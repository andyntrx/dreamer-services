using Dreamers.Application.Clients;
using Dreamers.Application.Clients.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Events
{
    internal class ClientProfileCreatedEventHandler : INotificationHandler<ClientProfileCreatedEvent>
    {
        readonly IMediator _mediator;

        public ClientProfileCreatedEventHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Handle(ClientProfileCreatedEvent notification, CancellationToken cancellationToken)
        {
            await _mediator.Send(new SendCreateProfileEmailCommand { clientUcid = notification.Id });
        }
    }
}
