using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class SubstancePreparationMap : ClassMap<SubstancePreparation>
    {
        public SubstancePreparationMap()
        {
            Table("SubstancePreparation");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.SubstanceName).Not.Nullable();
            Map(x => x.PreparationName).Not.Nullable();
        }
    }
}