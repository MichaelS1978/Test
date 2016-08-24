using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class AppointmentBlockMap : ClassMap<AppointmentBlock>
    {
        public AppointmentBlockMap()
        {
            Table("AppointmentBlock");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.Name).Not.Nullable();
            Map(x => x.BlockBegin).Not.Nullable();
            Map(x => x.BlockEnd).Not.Nullable();
            Map(x => x.ResourceId);

        }
    }
}