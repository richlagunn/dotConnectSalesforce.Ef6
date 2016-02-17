using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using dotConnectSalesforce.DbContext.Entities;
using dotConnectSalesforce.DbContext.Mappings;

namespace dotConnectSalesforce.DbContext.Access
{
    public class SalesforceDbContext : System.Data.Entity.DbContext
    {
        /// <summary>
        ///     There are no comments for Address in the schema.
        /// </summary>
        public virtual DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressConfiguration());

            #region Disabled conventions

            #endregion
        }

        #region Constructors

        /// <summary>
        ///     Initialize a new SalesforceEdmlContext object.
        /// </summary>
        public SalesforceDbContext() :
            base(@"name=SalesforceDbContext")
        {
            Configure();
        }

        private void Configure()
        {
            Configuration.AutoDetectChangesEnabled = true;
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
            Configuration.ValidateOnSaveEnabled = true;
        }

        #endregion
    }
}