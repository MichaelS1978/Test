using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class ChemotherapyProtocolCycleDayMap : ClassMap<ChemotherapyProtocolCycleDay>
    {
        public ChemotherapyProtocolCycleDayMap()
        {
            Table("ChemotherapyProtocolCycleDay");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            References(x => x.ChemotherapyProtocolCycle)
                .Column("ChemotherapyProtocolCycleId").Not.Nullable();

            Map(x => x.TherapyDay).Not.Nullable();

            HasMany(x => x.Medications)
                .Inverse()
                .KeyColumn("ChemotherapyProtocolCycleDayId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("ChemotherapyProtocolCycleDay_ChemotherapyProtocolCyleDayMedication");

        }
    }
}