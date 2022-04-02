using Dreamers.Domain.Entities.Tenants;
using Dreamers.Infra.Data.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Tenants
{
    public class GetAllCustomers : IRequest<IEnumerable<Business>>
    {
        public Guid TenantId { get; set; }
    }

    public class GetAllCustomerHandler : IRequestHandler<GetAllCustomers, IEnumerable<Business>>
    {
        readonly DreamContext _context;
        public GetAllCustomerHandler(DreamContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Business>> Handle(GetAllCustomers request, CancellationToken cancellationToken)
        {
            var customers = _context.Customers.Where(c => c.TenantId == request.TenantId).ToList();
            return customers;
        }
    }
}
