using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class PatientMap : ClassMap<Patient>
    {
        public PatientMap()
        {
            Table("Patient");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.IsArchived).Not.Nullable();
            Map(x => x.LastName).Not.Nullable().UniqueKey("UK_Patient");
            Map(x => x.FirstName).Not.Nullable().UniqueKey("UK_Patient");
            Map(x => x.Birthday).Not.Nullable().UniqueKey("UK_Patient");
            Map(x => x.Title);
            Map(x => x.Gender).Not.Nullable();
            Map(x => x.RegistrationId);
            Map(x => x.Street);
            Map(x => x.ZipCode);
            Map(x => x.City);
            Map(x => x.Phone);
            Map(x => x.IsFileClosed).Not.Nullable();
            Map(x => x.IsFreeOfCharge).Not.Nullable();
            Map(x => x.FreeOfChargeDate);
            Map(x => x.HealthInsuranceInstitutionNumber);
            Map(x => x.HealthInsuranceName);
            Map(x => x.HealthInsuranceNumber);
            Map(x => x.InsuranceKind).Not.Nullable();
            Map(x => x.InsuranceNumber);
            Map(x => x.ExternalId);

            HasMany<Chemotherapy>(x => x.Chemotherapys)
                .Inverse()
                .KeyColumn("PatientId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("Patient_Chemotherapy");


            HasMany<AppliedMedicine>(x => x.AppliedMedicines)
                .Inverse()
                .KeyColumn("PatientId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("Patient_AppliedMedicine");

            HasMany<Prescription>(x => x.Prescriptions)
                .Inverse()
                .KeyColumn("PatientId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("Patient_Prescription");
        }
    }
}