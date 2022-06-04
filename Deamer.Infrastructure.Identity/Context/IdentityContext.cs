using Dreamer.Application.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deamer.Infrastructure.Identity.Context
{
    public class IdentityContext : DbContext, IIdentityContext
    {
    }
}
