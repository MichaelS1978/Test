using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class DoctorMap : ClassMap<Doctor>
    {
        public DoctorMap()
        {
            Table("Doctor");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.LastName).Not.Nullable().UniqueKey("UK_Doctor");
            Map(x => x.FirstName).Not.Nullable().UniqueKey("UK_Doctor");
            Map(x => x.Title);
            Map(x => x.KbvNumber);
        }
    }
}