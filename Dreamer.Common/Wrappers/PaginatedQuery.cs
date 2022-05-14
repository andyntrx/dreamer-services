using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Common.Wrappers
{
    public class PaginatedQuery<TResponse> : IRequest<TResponse>
    {
        public int Limit { get; set; }
        public int Page { get; set; }
    }
}
