using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceDbConnection.Backend
{
    public class ReportSC : BaseSC
    {
        //Utilidad = Ingreso - Costo;

        public decimal GetUtility()
        {

            var invoiceIncome = DataContext.InvoiceProductItems.Sum(pr => pr.Quantity * pr.Price);
            var invoiceCost = DataContext.InvoiceProductItems.Sum(pr => pr.Quantity * (decimal) pr.Product.Cost);

            return invoiceIncome - invoiceCost;
        }

    }
}
