using Dreamer.Application.Abstractions;
using Dreamer.Common.Wrappers;
using Dreamer.Domain.Entities;
using Dreamer.Domain.Entities.Clients;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Clients
{
    public class GetAllClientPagingationQuery : PaginatedQuery<PaginatedResponse<IEnumerable<ClientProfile>>>
    { 
    }

    public class GetAllClientsHandler : IRequestHandler<GetAllClientPagingationQuery, PaginatedResponse<IEnumerable<ClientProfile>>>
    {
        readonly IDreamContext _context;
        public GetAllClientsHandler(IDreamContext context)
        {
            _context = context;
        }

        public async Task<PaginatedResponse<IEnumerable<ClientProfile>>> Handle(GetAllClientPagingationQuery request, 
                                                                                CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
            
            //var query =  _context.ClientProfiles.AsQueryable();
            //var results =  query.Skip(request.Page).Take(request.Limit).AsEnumerable();
            //return new PaginatedResponse<IEnumerable<ClientProfile>> { Total = _context.ClientProfiles.Count(), Data = results };
        }
    }
}
