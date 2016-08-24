using FluentNHibernate.Mapping;

namespace OnkoSoft.Data.Mappings.ChangeLog
{
    public class ChangeLogMap : ClassMap<OnkoSoft.Data.Domain.ChangeLog.ChangeLog>
    {
        public ChangeLogMap()
        {
            Table("ChangeLog");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.EntityType).Not.Nullable();
            Map(x => x.EntityId).Not.Nullable();
            Map(x => x.EntityChangeType).Not.Nullable();
        }
    }
}
