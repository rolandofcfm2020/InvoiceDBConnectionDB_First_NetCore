using InvoiceDbConnection.Backend;
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


            //¿Cual es la factura con mayor monto?
            //use only first if you know there is al least one element in table, otherwise use firstOrDefault



            //var sumInvoicesItems = DataContext.InvoiceProductItems.Sum(ip => ip.Quantity * ip.Price);

            var utilidad = new ReportSC().GetUtility();
        }
          
    }
}
