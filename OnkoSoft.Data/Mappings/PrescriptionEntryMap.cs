using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class PrescriptionEntryMap : ClassMap<PrescriptionEntry>
    {
        public PrescriptionEntryMap()
        {
            Table("PrescriptionEntry");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.LocalMedicineId);
            Map(x => x.PreparationName);
            Map(x => x.PackageSizeDetails);
            Map(x => x.PharmacyRetailPrice);
            Map(x => x.FixedAmount);
            Map(x => x.Dose);
            Map(x => x.Unit);
            Map(x => x.Solvent).Not.Nullable();
            Map(x => x.SolventUnit).Not.Nullable();
            Map(x => x.SolventAmount);
            Map(x => x.PharmaceuticalCentralNumber);
            Map(x => x.PrescriptionDetails);
            Map(x => x.Count).Not.Nullable();
            Map(x => x.IsAlternativePossible).Not.Nullable();
            Map(x => x.SortOrder).Not.Nullable();

            References(x => x.Prescription)
                .Column("PrescriptionId").Not.Nullable();

        }
    }
}