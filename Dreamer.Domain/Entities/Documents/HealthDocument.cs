using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.Documents
{
    public class HealthDocument : Document
    {
        public static HealthDocument Create(Document doc)
        {
            return new HealthDocument
            {
                Name = doc.Name,
                Created = doc.Created,
                Year = doc.Year,
                Id = doc.Id,
                DocType = Application.Documents.DocType.Health

            };
        }
    }
}
