using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using dotConnectSalesforce.Data.Interfaces;
using dotConnectSalesforce.Data.Managers;
using dotConnectSalesforce.DbContext.Access;
using Devart.Data.Salesforce.Entity.Configuration;

namespace dotConnectSalesforce.App
{
    internal class Program
    {
        private static ISalesforceEdmlManager _salesforceEdmlManager = new SalesforceEdmlManager();
        private static ISalesforceDbContextManager _salesforceDbContextManager = new SalesforceDbContextManager();

        private static void Main(string[] args)
        {
            var dataModelAddress = _salesforceEdmlManager.GetFirstAddress();
            Console.WriteLine("{0} | {1} | {2}", dataModelAddress.City, dataModelAddress.PostalZipCode,
                dataModelAddress.HousingConcernNotes);


            var codeFirstAddress = _salesforceDbContextManager.GetFirstAddress();
            Console.WriteLine("{0} | {1} | {2}", codeFirstAddress.City, codeFirstAddress.PostalZipCode,
                codeFirstAddress.HousingConcernNotes);


            Console.Read();
        }
    }
}