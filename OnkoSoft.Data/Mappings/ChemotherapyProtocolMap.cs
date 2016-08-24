using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class ChemotherapyProtocolMap : ClassMap<ChemotherapyProtocol>
    {
        public ChemotherapyProtocolMap()
        {
            Table("ChemotherapyProtocol");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.IsArchived).Not.Nullable();
            Map(x => x.Schema).Not.Nullable().Column("SchemaName").UniqueKey("UK_ChemotherapyProtocol");
            Map(x => x.DiagnosisGroup).Not.Nullable().UniqueKey("UK_ChemotherapyProtocol");
            Map(x => x.Description).Length(4001);
            Map(x => x.DescriptionAuto).Length(4001);
            Map(x => x.Source).Length(4001);
            Map(x => x.BodySurfaceMax2SquareMeter).Not.Nullable(); ;
            Map(x => x.IntentionAdjuvant).Not.Nullable(); ;
            Map(x => x.IntentionDiagnostic).Not.Nullable(); ;
            Map(x => x.IntentionCurative).Not.Nullable(); ;
            Map(x => x.IntentionNeoadjuvant).Not.Nullable(); ;
            Map(x => x.IntentionSymptomatic).Not.Nullable(); ;
            Map(x => x.IntentionPalliative).Not.Nullable(); ;
            Map(x => x.IntentionPalliativeFirstLine).Not.Nullable(); ;
            Map(x => x.IntentionPalliativeSecondLine).Not.Nullable(); ;
            Map(x => x.IntentionPalliativeThirdLine).Not.Nullable(); ;
            Map(x => x.IntentionPalliativeFourthLine).Not.Nullable(); ;
            Map(x => x.PortNecessary).Not.Nullable(); ;
            Map(x => x.RepetitionDay);
            Map(x => x.ExternalId);

            HasMany(x => x.Cycles)
                .Inverse()
                .KeyColumn("ChemotherapyProtocolId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("ChemotherapyProtocol_ChemotherapyProtocolCyle");

            HasMany(x => x.Medications)
                .Inverse()
                .KeyColumn("ChemotherapyProtocolId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("ChemotherapyProtocol_ChemotherapyProtocolMedication");
        }
    }
}