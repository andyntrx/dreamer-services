using Dreamers.Common.Wrappers;
using Dreamers.Domain.Entities;
using Dreamers.Domain.Entities.Clients;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Clients
{
    public class GetAllClientPagingationQuery : PaginatedQuery<PaginatedResponse<IEnumerable<ClientProfile>>>
    { 
    }

    public class GetAllClientsHandler : IRequestHandler<GetAllClientPagingationQuery, PaginatedResponse<IEnumerable<ClientProfile>>>
    {
        readonly DreamContext _context;
        public GetAllClientsHandler(DreamContext context)
        {
            _context = context;
        }

        public async Task<PaginatedResponse<IEnumerable<ClientProfile>>> Handle(GetAllClientPagingationQuery request, 
                                                                                CancellationToken cancellationToken)
        {
            var query =  _context.ClientProfiles.AsQueryable();
            var results =  query.Skip(request.Page).Take(request.Limit).AsEnumerable();
            return new PaginatedResponse<IEnumerable<ClientProfile>> { Total = _context.ClientProfiles.Count(), Data = results };
        }
    }
}
