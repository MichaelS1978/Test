using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain.DynamicEnumerations;

namespace OnkoSoft.Data.Mappings
{
    public class GatewayMap : ClassMap<Gateway>
    {
        public GatewayMap()
        {
            Table("Gateway");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.Name).Not.Nullable().Unique();
        }
    }
}