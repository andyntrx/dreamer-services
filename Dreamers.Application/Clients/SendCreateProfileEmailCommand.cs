using Dreamers.Domain.Interfaces;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Clients
{
    internal class SendCreateProfileEmailCommand : IRequest
    {
        public Guid clientUcid { get; set; }
    }

    internal class SendCreateProfileEmailCommandHandler : IRequestHandler<SendCreateProfileEmailCommand>
    {
        readonly IEmailDispatcher _emailDispatcher;
        readonly DreamContext _context;
        public SendCreateProfileEmailCommandHandler(DreamContext context,
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
