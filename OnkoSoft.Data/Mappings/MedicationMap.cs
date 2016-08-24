using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class MedicationMap : ClassMap<Medication>
    {
        public MedicationMap()
        {
            Table("Medication");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);

            Map(x => x.SubstanceName).Not.Nullable();
            Map(x => x.CalculationMethod).Not.Nullable();
            Map(x => x.IsConcurrentMedication).Not.Nullable();
            Map(x => x.AucFrom);
            Map(x => x.AucTo);
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
            Map(x => x.DonationKind).Not.Nullable();
            Map(x => x.InfusionDuration);
            Map(x => x.InfusionDurationUnit).Not.Nullable();
            Map(x => x.Solvent).Not.Nullable(); ;
            Map(x => x.SolventUnit).Not.Nullable();
            Map(x => x.SolventAmount);

        }
    }
}