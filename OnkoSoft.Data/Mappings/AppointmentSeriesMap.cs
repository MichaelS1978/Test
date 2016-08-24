using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class AppointmentSeriesMap : ClassMap<AppointmentSeries>
    {
        public AppointmentSeriesMap()
        {
            Table("AppointmentSeries");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.Type);
            Map(x => x.ExternalId);
        }
    }
}