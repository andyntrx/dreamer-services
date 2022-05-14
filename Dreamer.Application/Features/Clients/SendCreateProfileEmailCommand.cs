using Dreamer.Application.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Clients
{
    internal class SendCreateProfileEmailCommand : IRequest
    {
        public Guid clientUcid { get; set; }
    }

    internal class SendCreateProfileEmailCommandHandler : IRequestHandler<SendCreateProfileEmailCommand>
    {
        readonly IEmailDispatcher _emailDispatcher;
        readonly IDreamContext _context;
        public SendCreateProfileEmailCommandHandler(IDreamContext context,
                                                    IEmailDispatcher emailDispatcher)
        {
            _context = context;
            _emailDispatcher = emailDispatcher;
        }

        public async Task<Unit> Handle(SendCreateProfileEmailCommand request, CancellationToken cancellationToken)
        {

            _emailDispatcher.Dispatch(new MailMessage { });

            return Unit.Value;
        }
    }

}
