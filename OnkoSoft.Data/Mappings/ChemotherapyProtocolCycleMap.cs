using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class ChemotherapyProtocolCycleMap : ClassMap<ChemotherapyProtocolCycle>
    {
        public ChemotherapyProtocolCycleMap()
        {
            Table("ChemotherapyProtocolCycle");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            References(x => x.ChemotherapyProtocol)
                .Column("ChemotherapyProtocolId").Not.Nullable();

            Map(x => x.Cycle).Not.Nullable();
            Map(x => x.Interval).Not.Nullable();
            Map(x => x.IntervalUnit).Not.Nullable();

            HasMany(x => x.Days)
                .Inverse()
                .KeyColumn("ChemotherapyProtocolCycleId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("ChemotherapyProtocolCycle_ChemotherapyProtocolCyleDay");

        }
    }
}