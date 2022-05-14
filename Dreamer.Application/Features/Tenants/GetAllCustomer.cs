using Dreamer.Application.Abstractions;
using Dreamer.Domain.Entities.Tenants;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Features.Tenants
{
    public class GetAllCustomers : IRequest<IEnumerable<Business>>
    {
        public Guid TenantId { get; set; }
    }

    public class GetAllCustomerHandler : IRequestHandler<GetAllCustomers, IEnumerable<Business>>
    {
        readonly IDreamContext _context;
        public GetAllCustomerHandler(IDreamContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Business>> Handle(GetAllCustomers request, CancellationToken cancellationToken)
        {
            /*
            var customers = _context.Customers.Where(c => c.TenantId == request.TenantId).ToList();
            return customers;*/

            return new List<Business> { new Business { } };
        }
    }
}
