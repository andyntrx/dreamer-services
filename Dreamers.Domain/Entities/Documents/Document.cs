using Dreamers.Application.Documents;
using Dreamers.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamers.Domain.Entities.Documents
{
    public class Document : Entity
    {
        public Guid RefUcid { get; set; }
        public DocType DocType { get; set; }

        public byte[] Blob { get; set; }
    }
}
