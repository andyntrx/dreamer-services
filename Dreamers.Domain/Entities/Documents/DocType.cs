using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Dreamers.Application.Documents
{
    public enum DocType
    {
        Unknown,
        [Description("Tax Returns")]
        Tax,
        [Description("Health Insurance")]
        Health,
        [Description("Auto Insurance")]
        Auto,
        [Description("Home Insurance")]
        Home
    }
}
