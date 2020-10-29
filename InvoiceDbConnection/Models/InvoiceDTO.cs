using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceDbConnection.Models
{
    public class InvoiceDTO
    {
        public decimal Total { get; internal set; }
        public int Count { get; internal set; }
        public string ContactName { get; internal set; }
        public Guid Id { get; internal set; }
    }
}
