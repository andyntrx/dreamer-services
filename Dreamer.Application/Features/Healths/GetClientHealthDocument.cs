using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Healths
{
    public class GetClientHealthDocument : IRequest<IEnumerable<HealthDocument>>
    {
        public Guid ClientId { get; set; }
        public int? Start { get; set; }
        public int? End { get; set; }


        public class Handler : IRequestHandler<GetClientHealthDocument, IEnumerable<HealthDocument>>
        {
            readonly IDreamContext _context;

            public Handler(IDreamContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<HealthDocument>> Handle(GetClientHealthDocument request, CancellationToken cancellationToken)
            {
                var query = _context.Documents
                                     .Where(c => c.IsActive)
                                     .Where(c => c.Year >= request.Start.GetValueOrDefault());

                if (request.End.HasValue)
                    query.Where(c => c.Year <= request.End.GetValueOrDefault());

                return query.Select(c => HealthDocument.Create(c))
                            .ToList()
                            .AsEnumerable();
            }
        }
    }

}
