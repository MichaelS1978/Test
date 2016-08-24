using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class ChemotherapyMedicationMap : ClassMap<ChemotherapyMedication>
    {
        public ChemotherapyMedicationMap()
        {
            Table("ChemotherapyMedication");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            References(x => x.Chemotherapy)
                .Column("ChemotherapyId").Not.Nullable();
            Map(x => x.SortOrder).Not.Nullable();
            Map(x => x.Medicine);
            Map(x => x.DecimalRounding);
            Map(x => x.NominalDose);
            Map(x => x.DosePercentage);
            Map(x => x.DoseAbsolute);
            Map(x => x.RelativeFactor);
            Map(x => x.Application);
            Map(x => x.DonationCount);
            Map(x => x.TherapyDate1);
            Map(x => x.TherapyDate2);
            Map(x => x.TherapyDate3);
            Map(x => x.TherapyDate4);
            Map(x => x.TherapyDate5);
            Map(x => x.TherapyDate6);
            Map(x => x.TherapyDate7);
        }
    }
}