using InvoiceDbConnection.DataAccess;
using InvoiceDbConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceDbConnection.Backend
{
    public class InvoiceSC : BaseSC
    {

        public List<InvoiceDTO> GetAllInvoices()
        {

            var invoices = DataContext.Invoices.Select(s => new InvoiceDTO
            {

                Total = s.Total,
                Count = s.InvoiceProductItems.Count,
                ContactName = s.Client.ContactName,
                Id = s.Id

            }).ToList();

            return invoices;

        }

        public InvoiceDTO GetMaxAmountInvoice()
        {
            //return GetAllInvoices().OrderByDescending(o => o.Total).First();
            return GetMinOrMaxAmountInvoice(isMin: false);
        }

        public InvoiceDTO GetMinAmountInvoice()
        {
            //return GetAllInvoices().OrderBy(o => o.Total).First();
            return GetMinOrMaxAmountInvoice(isMin: true);
        }

        public InvoiceDTO GetMinOrMaxAmountInvoice(bool isMin)
        {
            return isMin ? GetAllInvoices().OrderBy(o => o.Total).First() : GetAllInvoices().OrderByDescending(o => o.Total).First();
        }

        public decimal InvoiceSum()
        {
            return GetAllInvoices().Sum(s => s.Total);
        }
    }
}
