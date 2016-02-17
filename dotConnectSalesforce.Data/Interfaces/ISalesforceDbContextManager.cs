using dotConnectSalesforce.DbContext.Entities;

namespace dotConnectSalesforce.Data.Interfaces
{
    public interface ISalesforceDbContextManager
    {
        Address GetFirstAddress();
    }
}