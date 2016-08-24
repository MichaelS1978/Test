using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class PatientHistoryEntryMap : ClassMap<PatientHistoryEntry>
    {
        public PatientHistoryEntryMap()
        {
            Table("PatientHistory");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.UserId).Not.Nullable();
            Map(x => x.PatientId).Not.Nullable();
            Map(x => x.SortOrder).Not.Nullable();
        }
    }
}
