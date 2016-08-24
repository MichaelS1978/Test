using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class PrepartaionMap : ClassMap<Preparation>
    {
        public PrepartaionMap()
        {
            Table("Preparation");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.Name).Not.Nullable();
        }
    }
}