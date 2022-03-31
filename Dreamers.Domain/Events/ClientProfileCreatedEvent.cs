using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Application.Clients.Events
{
    public class ClientProfileCreatedEvent : INotification
    {
        public Guid Id { get; }

        public ClientProfileCreatedEvent(Guid id)
        {
            Id  = id; 
        }
    }
}
