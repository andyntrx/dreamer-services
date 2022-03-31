using Dreamers.Application.Clients.Events;
using MassTransit;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dreamers.Background.Processors.Consumers
{
    public class CreateProfileConsumer : IConsumer<ClientProfileCreateEvent>
    {
        readonly ILogger<CreateProfileConsumer> _logger;

        public CreateProfileConsumer(ILogger<CreateProfileConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<ClientProfileCreateEvent> context)
        {
            _logger.LogInformation("Received Text: {Text}", context.Message);
            return Task.CompletedTask;
        }
    }
}
