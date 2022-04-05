using Dreamers.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Dreamers.Domain.Entities.Emails
{
    public class EmailTemplate : Entity
    {
        public string HtmlContent { get; set; }
        public Guid DocRefUcid { get; set; }
    }
}
