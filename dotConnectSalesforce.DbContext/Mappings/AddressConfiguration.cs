using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using dotConnectSalesforce.DbContext.Entities;

namespace dotConnectSalesforce.DbContext.Mappings
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            HasKey(p => p.Id)
                .ToTable("Address");
            // Properties:
            Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(18)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasColumnType("string");
            Property(p => p.OwnerId)
                .IsRequired()
                .HasMaxLength(18)
                .HasColumnType("string");
            Property(p => p.IsDeleted)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasColumnType("boolean");
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(80)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasColumnType("string");
            Property(p => p.LastViewedDate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasColumnType("datetime");
            Property(p => p.LastReferencedDate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasColumnType("datetime");
            Property(p => p.NameOfHotelMotelComplex)
                .HasColumnName(@"Name_of_Hotel_Motel_Complex")
                .HasMaxLength(255)
                .HasColumnType("string");
            Property(p => p.Street)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("string");
            Property(p => p.StreetAddress2)
                .HasColumnName(@"Street_Address_2")
                .HasMaxLength(100)
                .HasColumnType("string");
            Property(p => p.City)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnType("string");
            Property(p => p.State)
                .HasMaxLength(255)
                .HasColumnType("string");
            Property(p => p.PostalZipCode)
                .HasColumnName(@"Postal_Zip_Code")
                .HasMaxLength(10)
                .HasColumnType("string");
            Property(p => p.Profile)
                .HasMaxLength(18)
                .HasColumnType("string");
            Property(p => p.Status)
                .HasMaxLength(255)
                .HasColumnType("string");
            Property(p => p.Type)
                .HasMaxLength(255)
                .HasColumnType("string");
            Property(p => p.UpdateAccount)
                .HasColumnName(@"Update_Account")
                .IsRequired()
                .HasColumnType("boolean");
            Property(p => p.HousingConcern)
                .HasColumnName(@"Housing_Concern")
                .IsRequired()
                .HasColumnType("boolean");
            Property(p => p.Account)
                .HasMaxLength(18)
                .HasColumnType("string");
            Property(p => p.LegacyAddressID)
                .HasColumnName(@"Legacy_Address_ID")
                .HasMaxLength(15)
                .HasColumnType("string");
            Property(p => p.Phone)
                .HasMaxLength(40)
                .HasColumnType("string");
            Property(p => p.Fax)
                .HasMaxLength(40)
                .HasColumnType("string");
            Property(p => p.Email)
                .HasMaxLength(80)
                .HasColumnType("string");
            Property(p => p.Website)
                .HasMaxLength(255)
                .HasColumnType("string");
            Property(p => p.MigratedRecord)
                .HasColumnName(@"Migrated_Record")
                .IsRequired()
                .HasColumnType("boolean");
            Property(p => p.AtlasHighSchoolID)
                .HasColumnName(@"Atlas_High_School_ID")
                .IsRequired()
                .HasColumnType("boolean");
            Property(p => p.Contact)
                .HasMaxLength(18)
                .HasColumnType("string");
            Property(p => p.HousingConcernNotes)
                .HasColumnName(@"Housing_Concern_Notes")
                .HasMaxLength(32768)
                .HasColumnType("string");
            Property(p => p.StateText)
                .HasColumnName(@"State_Text")
                .HasMaxLength(40)
                .HasColumnType("string");
            Property(p => p.NumberOfBedrooms)
                .HasColumnName(@"Number_of_bedrooms")
                .HasColumnType("double");
            Property(p => p.NumberOfBathrooms)
                .HasColumnName(@"Number_of_bathrooms")
                .HasColumnType("double");
            Property(p => p.IsThereASeparateKitchen)
                .HasColumnName(@"Is_there_a_separate_kitchen")
                .HasMaxLength(255)
                .HasColumnType("string");
            Property(p => p.NumberOfAssociations)
                .HasColumnName(@"Number_of_Associations")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasColumnType("double");
            Property(p => p.TypeImage)
                .HasColumnName(@"Type_Image")
                .HasMaxLength(1300)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasColumnType("string");
            OnCreated();
        }

        private static void OnCreated()
        {
        }
    }
}