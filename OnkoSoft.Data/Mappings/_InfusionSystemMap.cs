using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class InfusionSystemMap : ClassMap<InfusionSystem>
    {
        public InfusionSystemMap()
        {
            Table("InfusionSystem");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.Name).Not.Nullable().Unique();
        }
    }
}