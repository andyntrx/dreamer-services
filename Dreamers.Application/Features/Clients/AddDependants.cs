using Dreamers.Domain.Entities;
using Dreamers.Domain.Entities.Clients;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamers.Application.Features.Clients
{
    public class AddDependants : IRequest
    {
        public IList<Client> Clients { get; set; }    
    }

    public class AddDependantsHandler : IRequestHandler<AddDependants>
    {

        public AddDependantsHandler()
        {

        }

        public Task<Unit> Handle(AddDependants request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
