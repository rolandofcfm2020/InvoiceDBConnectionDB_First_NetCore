using System;
using System.Collections.Generic;

namespace InvoiceDbConnection.DataAccess
{
    public partial class Invoices
    {
        public Invoices()
        {
            InvoiceProductItems = new HashSet<InvoiceProductItems>();
        }

        public Guid Id { get; set; }
        public string Emisor { get; set; }
        public Guid ClientId { get; set; }
        public long Number { get; set; }
        public string Series { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Total { get; set; }

        public virtual Clients Client { get; set; }
        public virtual ICollection<InvoiceProductItems> InvoiceProductItems { get; set; }
    }
}
