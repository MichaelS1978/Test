using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    internal class SystemSettingMap : ClassMap<SystemSetting>
    {
        public SystemSettingMap()
        {
            Table("SystemSettings");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Value);
        }
    }
}