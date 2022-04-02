
using Dreamers.Application.Clients.Events;
using Dreamers.Application.Features.Clients;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.DomainEventHandlers
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
