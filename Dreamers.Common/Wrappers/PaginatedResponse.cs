using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Common.Wrappers
{
    public class PaginatedResponse<TResponse>
    {
        public TResponse Data { get; set; }
        public int Total { get; set; }

    }
}
