using Dreamer.Application.Abstractions;
using Dreamer.Application.Documents;
using Dreamer.Domain.Entities.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Documents
{
    public class AddDocument : IRequest
    {
        public DocType DocType { get; set; }
        public string Name { get; set; }

        public class Handler : IRequestHandler<AddDocument>
        {
            readonly IDreamContext _context;
            public Handler(IDreamContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(AddDocument request, CancellationToken cancellationToken)
            {
                _context.Documents.Add(new Document
                {
                    Created = DateTime.Now,
                    Name = request.Name,

                });

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
