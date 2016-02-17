using System;

namespace dotConnectSalesforce.DbContext.Entities
{
    public class Address
    {
        public Address()
        {
            OnCreated();
        }

        #region Extensibility Method Definitions

        private static void OnCreated()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        ///     There are no comments for <see cref="Id" /> in the schema.
        /// </summary>
        public virtual string Id { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="OwnerId" /> in the schema.
        /// </summary>
        public virtual string OwnerId { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="IsDeleted" /> in the schema.
        /// </summary>
        public virtual bool IsDeleted { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="Name" /> in the schema.
        /// </summary>
        public virtual string Name { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="LastViewedDate" /> in the schema.
        /// </summary>
        public virtual DateTime? LastViewedDate { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="LastReferencedDate" /> in the
        ///     schema.
        /// </summary>
        public virtual DateTime? LastReferencedDate { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="NameOfHotelMotelComplex" /> in the
        ///     schema.
        /// </summary>
        public virtual string NameOfHotelMotelComplex { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="Street" /> in the schema.
        /// </summary>
        public virtual string Street { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="StreetAddress2" /> in the schema.
        /// </summary>
        public virtual string StreetAddress2 { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="City" /> in the schema.
        /// </summary>
        public virtual string City { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="State" /> in the schema.
        /// </summary>
        public virtual string State { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="PostalZipCode" /> in the schema.
        /// </summary>
        public virtual string PostalZipCode { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="Profile" /> in the schema.
        /// </summary>
        public virtual string Profile { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="Status" /> in the schema.
        /// </summary>
        public virtual string Status { get; set; }


        /// <summary>
        ///     There are no comments for Type in the schema.
        /// </summary>
        public virtual string Type { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="UpdateAccount" /> in the schema.
        /// </summary>
        public virtual bool UpdateAccount { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="HousingConcern" /> in the schema.
        /// </summary>
        public virtual bool HousingConcern { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="Account" /> in the schema.
        /// </summary>
        public virtual string Account { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="LegacyAddressID" /> in the schema.
        /// </summary>
        public virtual string LegacyAddressID { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="Phone" /> in the schema.
        /// </summary>
        public virtual string Phone { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="Fax" /> in the schema.
        /// </summary>
        public virtual string Fax { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="Email" /> in the schema.
        /// </summary>
        public virtual string Email { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="Website" /> in the schema.
        /// </summary>
        public virtual string Website { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="MigratedRecord" /> in the schema.
        /// </summary>
        public virtual bool MigratedRecord { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="AtlasHighSchoolID" /> in the schema.
        /// </summary>
        public virtual bool AtlasHighSchoolID { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="Contact" /> in the schema.
        /// </summary>
        public virtual string Contact { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="HousingConcernNotes" /> in the
        ///     schema.
        /// </summary>
        public virtual string HousingConcernNotes { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="StateText" /> in the schema.
        /// </summary>
        public virtual string StateText { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="NumberOfBedrooms" /> in the schema.
        /// </summary>
        public virtual double? NumberOfBedrooms { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="NumberOfBathrooms" /> in the schema.
        /// </summary>
        public virtual double? NumberOfBathrooms { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="IsThereASeparateKitchen" /> in the
        ///     schema.
        /// </summary>
        public virtual string IsThereASeparateKitchen { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="NumberOfAssociations" /> in the
        ///     schema.
        /// </summary>
        public virtual double? NumberOfAssociations { get; set; }


        /// <summary>
        ///     There are no comments for <see cref="TypeImage" /> in the schema.
        /// </summary>
        public virtual string TypeImage { get; set; }

        #endregion
    }
}