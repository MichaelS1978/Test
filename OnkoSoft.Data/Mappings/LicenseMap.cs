using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class LicenseMap : ClassMap<License>
    {
        public LicenseMap()
        {
            Table("License");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.LicenseCode).Not.Nullable();
            Map(x => x.LicenseData).Nullable();

            
        }
    }
}
