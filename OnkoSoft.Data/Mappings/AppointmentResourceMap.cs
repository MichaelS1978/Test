using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class AppointmentResourceMap : ClassMap<AppointmentResource>
    {
        public AppointmentResourceMap()
        {
            Table("AppointmentResource");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.Name).Not.Nullable().UniqueKey("UK_AppointmentResource");
            Map(x => x.ExternalId);

        }
    }
}