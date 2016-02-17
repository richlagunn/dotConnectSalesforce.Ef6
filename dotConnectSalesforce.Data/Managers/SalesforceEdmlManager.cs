using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotConnectSalesforce.Data.Interfaces;
using dotConnectSalesforce.Edml.Entities;

namespace dotConnectSalesforce.Data.Managers
{
    public class SalesforceEdmlManager : ISalesforceEdmlManager
    {
        public SalesforceEdmlManager()
        {
        }

        Address ISalesforceEdmlManager.GetFirstAddress()
        {
            return GetFirstAddress();
        }

        public Address GetFirstAddress()
        {
            try
            {
                return (from addr in new SalesforceEdmlContext().Addresses
                    orderby addr.Id
                    select addr).FirstOrDefault();
            }
            catch (Exception ex)
            {
                return new Address { City = "Exception", PostalZipCode = "#N/A", HousingConcernNotes = ex.Message};
            }

        }
    }
}
