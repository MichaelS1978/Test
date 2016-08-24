using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class ChemotherapyMap : ClassMap<Chemotherapy>
    {
        public ChemotherapyMap()
        {
            Table("Chemotherapy");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.TherapyCreationDate);
            Map(x => x.TherapyStartDate);
            Map(x => x.TherapyEndDate);
            Map(x => x.TherapyLine);
            Map(x => x.PatientHeight);
            Map(x => x.BodySurfaceMax2SquareMeter);
            Map(x => x.TreatmentDays);
            Map(x => x.Gateway);
            Map(x => x.Intention);
            Map(x => x.RepetitionDay);
            Map(x => x.Description).Length(4001);
            Map(x => x.Status).Not.Nullable();
            Map(x => x.DoctorId);
            Map(x => x.ChemotherapyProtocolId);
            Map(x => x.ExternalId);

            References(x => x.Patient)
                .Column("PatientId").Not.Nullable();

            HasMany(x => x.Cycles)
                .Inverse()
                .KeyColumn("ChemotherapyId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("Chemotherapy_ChemotherapyCycle");
        }
    }
}