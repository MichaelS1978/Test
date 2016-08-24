using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class AppliedMedicineMap : ClassMap<AppliedMedicine>
    {
        public AppliedMedicineMap()
        {
            Table("AppliedMedicine");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.LocalMedicineId);
            Map(x => x.PreparationName);
            Map(x => x.IsArchived).Not.Nullable();
            Map(x => x.PackageSizeDetails);
            Map(x => x.PharmacyRetailPrice);
            Map(x => x.FixedAmount);
            Map(x => x.PharmaceuticalCentralNumber);
            Map(x => x.Count).Not.Nullable();
            Map(x => x.IsAlternativePossible).Not.Nullable();
            Map(x => x.SortOrder).Not.Nullable();

            References(x => x.Patient)
                .Column("PatientId").Not.Nullable();

        }
    }
}