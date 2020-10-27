using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceDbConnection.Models
{
    public class ClientDTO
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string CompleteInfo
        {
            get
            {
                return this.CompanyName + " - " + this.Address;
            }
        }
    }
}
