using InvoiceDbConnection.DataAccess;
using InvoiceDbConnection.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Linq;

namespace InvoiceDbConnection
{
    class Program
    {
        static void Main(string[] args)
        {

            RV_ERPContext DataContext = new RV_ERPContext();

            var invoices = DataContext.Invoices.Select(s => new { 
            
                s.Total,
                s.InvoiceProductItems.Count,
                s.Client.ContactName,
                s.Id
                
            }).ToList();

            //¿Cual es la factura con mayor monto?
            //use only first if you know there is al least one element in table, otherwise use firstOrDefault
            var maxInvoice = invoices.OrderByDescending(o => o.Total).First();
                              // select *from invoices order by desc total

            var minInvoice = invoices.OrderBy(o => o.Total).First();

        }
          
    }
}
