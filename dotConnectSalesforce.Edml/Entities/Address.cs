namespace dotConnectSalesforce.Edml.Entities
{

    /// <summary>
    /// There are no comments for dotConnectSalesforce.Edml.Entities.Address in the schema.
    /// </summary>
    public partial class Address    {

        public Address()
        {
            OnCreated();
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual string Id
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for OwnerId in the schema.
        /// </summary>
        public virtual string OwnerId
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for IsDeleted in the schema.
        /// </summary>
        public virtual bool IsDeleted
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Name in the schema.
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for LastViewedDate in the schema.
        /// </summary>
        public virtual global::System.Nullable<System.DateTime> LastViewedDate
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for LastReferencedDate in the schema.
        /// </summary>
        public virtual global::System.Nullable<System.DateTime> LastReferencedDate
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NameOfHotelMotelComplex in the schema.
        /// </summary>
        public virtual string NameOfHotelMotelComplex
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Street in the schema.
        /// </summary>
        public virtual string Street
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for StreetAddress2 in the schema.
        /// </summary>
        public virtual string StreetAddress2
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for City in the schema.
        /// </summary>
        public virtual string City
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for State in the schema.
        /// </summary>
        public virtual string State
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for PostalZipCode in the schema.
        /// </summary>
        public virtual string PostalZipCode
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Profile in the schema.
        /// </summary>
        public virtual string Profile
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Status in the schema.
        /// </summary>
        public virtual string Status
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Type in the schema.
        /// </summary>
        public virtual string Type
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for UpdateAccount in the schema.
        /// </summary>
        public virtual bool UpdateAccount
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for HousingConcern in the schema.
        /// </summary>
        public virtual bool HousingConcern
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Account in the schema.
        /// </summary>
        public virtual string Account
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for LegacyAddressID in the schema.
        /// </summary>
        public virtual string LegacyAddressID
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Phone in the schema.
        /// </summary>
        public virtual string Phone
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Fax in the schema.
        /// </summary>
        public virtual string Fax
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Email in the schema.
        /// </summary>
        public virtual string Email
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Website in the schema.
        /// </summary>
        public virtual string Website
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for MigratedRecord in the schema.
        /// </summary>
        public virtual bool MigratedRecord
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for AtlasHighSchoolID in the schema.
        /// </summary>
        public virtual bool AtlasHighSchoolID
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Contact in the schema.
        /// </summary>
        public virtual string Contact
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for HousingConcernNotes in the schema.
        /// </summary>
        public virtual string HousingConcernNotes
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for StateText in the schema.
        /// </summary>
        public virtual string StateText
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NumberOfBedrooms in the schema.
        /// </summary>
        public virtual global::System.Nullable<double> NumberOfBedrooms
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NumberOfBathrooms in the schema.
        /// </summary>
        public virtual global::System.Nullable<double> NumberOfBathrooms
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for IsThereASeparateKitchen in the schema.
        /// </summary>
        public virtual string IsThereASeparateKitchen
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NumberOfAssociations in the schema.
        /// </summary>
        public virtual global::System.Nullable<double> NumberOfAssociations
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for TypeImage in the schema.
        /// </summary>
        public virtual string TypeImage
        {
            get;
            set;
        }


        #endregion
    
        #region Extensibility Method Definitions
        partial void OnCreated();
        #endregion
    }

}
