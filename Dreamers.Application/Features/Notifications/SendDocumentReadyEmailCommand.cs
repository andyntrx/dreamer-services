using Dreamers.Domain.Entities.Emails;
using Dreamers.Domain.Interfaces;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Notifications
{
    public class SendDocumentReadyEmailCommand : IRequest
    {
        public Guid ClientUcid { get; set; }
        public Guid DocumentUcid { get; set; }
    }

    public class SendDocumentReadyEmailCommandHandler : IRequestHandler<SendDocumentReadyEmailCommand>
    {
        readonly IEmailDispatcher _emailDispatcher;
        readonly DreamContext _context;
        readonly IEmailGeneratorService _emailGeneratorService;

        public SendDocumentReadyEmailCommandHandler(DreamContext context, 
                                                    IEmailDispatcher emailDispatcher,
                                                    IEmailGeneratorService emailGeneratorService)
        {
            _context = context;
            _emailDispatcher = emailDispatcher;
            _emailGeneratorService = emailGeneratorService;
        }

        public async Task<Unit> Handle(SendDocumentReadyEmailCommand request, CancellationToken cancellationToken)
        {
            var client =  await _context.Clients.FindAsync(request.ClientUcid);
            if (client != null)
            {
                var document =  client.Documents.FirstOrDefault(d => d.Ucid == request.DocumentUcid);
                var emailTemplate = _context.EmailTemplates.FirstOrDefault(d => d.DocRefUcid == request.DocumentUcid);
                var email = _emailGeneratorService.Generate(document, emailTemplate);
                _emailDispatcher.Dispatch(email);
            }

            return Unit.Value;
        }
    }
}
