using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class ChemotherapyProtocolMedicationMap : ClassMap<ChemotherapyProtocolMedication>
    {
        public ChemotherapyProtocolMedicationMap()
        {
            Table("ChemotherapyProtocolMedication");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            References(x => x.ChemotherapyProtocol)
                .Column("ChemotherapyProtocolId").Not.Nullable();

            Map(x => x.SortOrder).Not.Nullable();
            Map(x => x.SubstanceName).Not.Nullable();
            Map(x => x.Annotation);
            Map(x => x.CalculationMethod).Not.Nullable();
            Map(x => x.BodySurfaceMax2SquareMeter).Not.Nullable();
            Map(x => x.IsConcurrentMedication).Not.Nullable();
            Map(x => x.IsLoadingDose).Not.Nullable();
            Map(x => x.MarginalWeight);
            Map(x => x.UseForSchedule).Not.Nullable();
            Map(x => x.AucFrom);
            Map(x => x.AucTo);
            Map(x => x.UseForPrescription).Not.Nullable();
            Map(x => x.PrescriptionDetails);
            Map(x => x.DoRounding).Not.Nullable();
            Map(x => x.RoundAccuracy).Not.Nullable();
            Map(x => x.Dose);
            Map(x => x.DailyDose);
            Map(x => x.TherapyMaxDose);
            Map(x => x.DailyMaxDose);
            Map(x => x.DonationInTheMorning).Not.Nullable();
            Map(x => x.DonationAtNoon).Not.Nullable();
            Map(x => x.DonationInTheEvening).Not.Nullable();
            Map(x => x.DonationAtNight).Not.Nullable();
            Map(x => x.DonationUnit).Not.Nullable();
            Map(x => x.DonationCount);
            Map(x => x.DonationTime);
            Map(x => x.DonationKind).Not.Nullable();
            Map(x => x.InfusionDuration);
            Map(x => x.InfusionDurationUnit).Not.Nullable();
            Map(x => x.Solvent).Not.Nullable(); ;
            Map(x => x.SolventUnit).Not.Nullable();
            Map(x => x.SolventAmount);
            Map(x => x.TherapyDays);

        }
    }
}