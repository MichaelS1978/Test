using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class ChemotherapyCycleDayMap : ClassMap<ChemotherapyCycleDay>
    {
        public ChemotherapyCycleDayMap()
        {
            Table("ChemotherapyCycleDay");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            References(x => x.ChemotherapyCycle)
                .Column("ChemotherapyCycleId").Not.Nullable();

            Map(x => x.AppointmentId);
            Map(x => x.TherapyDay).Not.Nullable();
            Map(x => x.TherapyDate).Not.Nullable();
            Map(x => x.PatientWeight);
            Map(x => x.PatientBodySurface);
            Map(x => x.Gateway);
            Map(x => x.Status);
            Map(x => x.AppointmentStatus);

            HasMany(x => x.Medications)
                .Inverse()
                .KeyColumn("ChemotherapyCycleDayId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("ChemotherapyCycleDay_ChemotherapyCyleDayMedication");

        }
    }
}