using InvoiceDbConnection.DataAccess;
using System;
using System.Linq;

namespace InvoiceDbConnection
{
    class Program
    {
        static void Main(string[] args)
        {

            RV_ERPContext DataContext = new RV_ERPContext();

            var clients = DataContext.Clients.Select(s => new
            {
                s.Address,
                s.CompanyName,
                s.Id

            }).ToList();

            foreach (var c in clients)
            {
                Console.WriteLine("Nombre empresa: " + c.CompanyName);
                Console.WriteLine("Id Empresa: " + c.Id);
                Console.WriteLine("Dirección: " + c.Address);
                Console.WriteLine("******************************************");
            }
        }
    }
}
