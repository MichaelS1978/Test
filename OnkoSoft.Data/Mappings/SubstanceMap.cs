using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class SubstanceMap : ClassMap<Substance>
    {
        public SubstanceMap()
        {
            Table("Substance");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.Name).Not.Nullable();
            Map(x => x.SubstanceGroup);
            Map(x => x.IsConcurrentMedication).Not.Nullable();
            Map(x => x.OdsSubstanceCode);

        }
    }
}