using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class ChemotherapyCycleDayMedicationMap : ClassMap<ChemotherapyCycleDayMedication>
    {
        public ChemotherapyCycleDayMedicationMap()
        {
            Table("ChemotherapyCycleDayMedication");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            References(x => x.ChemotherapyCycleDay)
                .Column("ChemotherapyCycleDayId").Not.Nullable();

            Map(x => x.SubstanceName).Not.Nullable();
            Map(x => x.Annotation);
            Map(x => x.CalculationMethod).Not.Nullable();
            Map(x => x.BodySurfaceMax2SquareMeter).Not.Nullable();
            Map(x => x.IsConcurrentMedication).Not.Nullable();
            Map(x => x.IsLoadingDose).Not.Nullable();
            Map(x => x.MarginalWeight);
            Map(x => x.UseForSchedule).Not.Nullable();
            Map(x => x.TreatmentStatus).Not.Nullable();
            Map(x => x.AucFrom);
            Map(x => x.AucTo);
            Map(x => x.AucCreatinin);
            Map(x => x.AucTarget);
            Map(x => x.UseForPrescription).Not.Nullable();
            Map(x => x.PrescriptionDetails);
            Map(x => x.DoRounding).Not.Nullable();
            Map(x => x.RoundAccuracy).Not.Nullable();
            Map(x => x.Dose);
            Map(x => x.ActualDose);
            Map(x => x.ActualDoseAccumulated);
            Map(x => x.TargetDose);
            Map(x => x.TargetDoseAccumulated);
            Map(x => x.DoseReduction);
            Map(x => x.DailyDose);
            Map(x => x.ActualDailyDose);
            Map(x => x.TargetDailyDose);
            Map(x => x.DailyMaxDose);
            Map(x => x.DonationInTheMorning).Not.Nullable();
            Map(x => x.DonationAtNoon).Not.Nullable();
            Map(x => x.DonationInTheEvening).Not.Nullable();
            Map(x => x.DonationAtNight).Not.Nullable();
            Map(x => x.DonationUnit).Not.Nullable();
            Map(x => x.DonationCount);
            Map(x => x.DonationOrder);
            Map(x => x.DonationTime);
            Map(x => x.DonationKind).Not.Nullable();
            Map(x => x.PackageDonationTime);
            Map(x => x.InfusionDuration);
            Map(x => x.InfusionDurationUnit).Not.Nullable();
            Map(x => x.Solvent).Not.Nullable(); ;
            Map(x => x.SolventUnit).Not.Nullable();
            Map(x => x.SolventAmount);
            Map(x => x.Medicine);
        }
    }
}