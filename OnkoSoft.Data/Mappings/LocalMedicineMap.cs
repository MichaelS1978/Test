using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class LocalMedicineMap : ClassMap<LocalMedicine>
    {
        public LocalMedicineMap()
        {
            Table("LocalMedicine");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.PreparationName).Not.Nullable();
            Map(x => x.IsArchived).Not.Nullable();
            Map(x => x.PackageSizeDetails);
            Map(x => x.PharmacyRetailPrice);
            Map(x => x.FixedAmount);
            Map(x => x.PharmaceuticalCentralNumber);
            Map(x => x.ExternalId);
        }
    }
}