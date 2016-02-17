using System;
using System.Linq;
using dotConnectSalesforce.Data.Interfaces;
using dotConnectSalesforce.DbContext.Access;
using dotConnectSalesforce.DbContext.Entities;

namespace dotConnectSalesforce.Data.Managers
{
    public class SalesforceDbContextManager : ISalesforceDbContextManager
    {
        public SalesforceDbContextManager()
        {
        }

        Address ISalesforceDbContextManager.GetFirstAddress()
        {
            return GetFirstAddress();
        }

        private Address GetFirstAddress()
        {
            try
            {
                return (from addr in new SalesforceDbContext().Addresses
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
