using InvoiceDbConnection.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceDbConnection.Backend
{
    public class BaseSC
    {
        public RV_ERPContext DataContext = new RV_ERPContext();
    }
}
