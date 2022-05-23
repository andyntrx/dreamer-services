using Dreamer.Application.Documents;
using Dreamer.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.Documents
{
    public class Document : Entity
    {
        public string Name { get; set; }
        public Guid RefUcid { get; set; }
        public DocType DocType { get; set; }

        public int Year { get; set; }
        public string FileName { get; set; }
        public byte[] Blob { get; set; }
    }
}
