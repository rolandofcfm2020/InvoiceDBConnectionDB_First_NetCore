using InvoiceDbConnection.DataAccess;
using InvoiceDbConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceDbConnection.Backend
{
    public class ClientSC : BaseSC
    {
        public void PrintAllClients()
        {
            //Lmabda notation
            var clients = GetClientListByLambda();
            //LINQ Notation
            var myClients = GetClientListByLINQ();

            foreach (var c in DataContext.Clients)
            {
                Console.WriteLine("Nombre empresa: " + c.CompanyName);
                Console.WriteLine("Id Empresa: " + c.Id);
                Console.WriteLine("Dirección: " + c.Address);
                Console.WriteLine("******************************************");
            }
        }

        public List<ClientDTO> GetClientListByLambda()
        {
            return DataContext.Clients.Select(s => new ClientDTO
            {
                Address = s.Address,
                CompanyName = s.CompanyName,
                Id = s.Id,
            }).ToList();  // Select Address, CompanyName, Id, concat(companyName, Address) as CompleteInfo from Clients

        }

        public object GetClientListByLINQ()
        {
           return (from c in DataContext.Clients
                   select new { c.Address, c.CompanyName, CompleteInfo = c.CompanyName + " - " + c.Address }).ToList();

        }
    }
}

