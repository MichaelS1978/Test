using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    internal class OfflineSynchronizationMap : ClassMap<OfflineSynchronization>
    {
        public OfflineSynchronizationMap()
        {
            Table("OfflineSynchronization");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.SynchronizationDate).Not.Nullable();
        }
    }
}