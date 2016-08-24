using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class AppointmentMap : ClassMap<Appointment>
    {
        public AppointmentMap()
        {
            Table("Appointment");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.AppointmentSeriesId);
            Map(x => x.UserId);
            Map(x => x.ResourceId);
            Map(x => x.PatientId);
            Map(x => x.DescriptionShort);
            Map(x => x.DescriptionLong).Length(4001);
            Map(x => x.DoRemind).Not.Nullable();
            Map(x => x.AppointmentBegin).Not.Nullable();
            Map(x => x.AppointmenEnd).Not.Nullable();
            Map(x => x.AppointmentRemind);
            Map(x => x.ReminderPeriod).Not.Nullable();
            Map(x => x.Status).Not.Nullable();
            Map(x => x.ExternalId);

        }
    }
}