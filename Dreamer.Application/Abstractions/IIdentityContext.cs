using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dreamer.Application.Abstractions
{
    public interface IIdentityContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
