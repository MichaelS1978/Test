using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class ApplicationVersionMap : ClassMap<ApplicationVersion>
    {
        public ApplicationVersionMap()
        {
            Table("ApplicationVersion");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.Major).Not.Nullable().UniqueKey("UK_ApplicationVersion_Major_Minor_Build_Revision");
            Map(x => x.Minor).Not.Nullable().UniqueKey("UK_ApplicationVersion_Major_Minor_Build_Revision");
            Map(x => x.Build).Not.Nullable().UniqueKey("UK_ApplicationVersion_Major_Minor_Build_Revision");
            Map(x => x.Revision).Not.Nullable().UniqueKey("UK_ApplicationVersion_Major_Minor_Build_Revision");

            
        }
    }
}
