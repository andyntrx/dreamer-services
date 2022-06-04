using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamer.Domain.Entities.Documents
{
    public class TaxDocument : Document
    {
        public static TaxDocument Create(Document doc)
        {
            return new TaxDocument
            {
                Name = doc.Name,
                Created = doc.Created,
                Year = doc.Year,
                Id = doc.Id,
                DocType = Application.Documents.DocType.Tax
            };
        }
    }
}
