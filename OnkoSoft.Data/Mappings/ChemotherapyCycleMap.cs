using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class ChemotherapyCycleMap : ClassMap<ChemotherapyCycle>
    {
        public ChemotherapyCycleMap()
        {
            Table("ChemotherapyCycle");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            References(x => x.Chemotherapy)
                .Column("ChemotherapyId").Not.Nullable();

            Map(x => x.Cycle).Not.Nullable();
            Map(x => x.Annotation).Length(4001);

            HasMany(x => x.Days)
                .Inverse()
                .KeyColumn("ChemotherapyCycleId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("ChemotherapyCycle_ChemotherapyCyleDay");

        }
    }
}