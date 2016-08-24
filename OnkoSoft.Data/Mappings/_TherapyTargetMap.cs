using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class TherapyTargetMap : ClassMap<TherapyTarget>
    {
        public TherapyTargetMap()
        {
            Table("TherapyTarget");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.Name).Not.Nullable().Unique();
        }
    }
}