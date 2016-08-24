using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class PrescriptionMap : ClassMap<Prescription>
    {
        public PrescriptionMap()
        {
            Table("Prescription");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.IsArchived).Not.Nullable();
            Map(x => x.DoctorId);
            Map(x => x.ChemotherapyId);
            Map(x => x.ChemotherapyCycle);
            Map(x => x.ChemotherapyCycleDay);
            Map(x => x.IsFreeOfCharge).Not.Nullable();
            Map(x => x.IssueDate).Not.Nullable();
            Map(x => x.PrintDate);
            Map(x => x.HealthInsuranceInstitutionNumber);
            Map(x => x.HealthInsuranceName);
            Map(x => x.HealthInsuranceNumber);
            Map(x => x.HealthInsuranceCostUnitGroup);
            Map(x => x.InsuranceNumber);

            References(x => x.Patient)
                .Column("PatientId").Not.Nullable();

            HasMany<PrescriptionEntry>(x => x.Entries)
                .Inverse()
                .KeyColumn("PrescriptionId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("Prescription_PrescriptionEntry");

        }
    }
}