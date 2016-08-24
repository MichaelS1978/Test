using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class Medication : OnkoSoftBase
    {
        public virtual string SubstanceName { get; set; }
        public virtual CalculationMethod CalculationMethod { get; set; }
        public virtual bool IsConcurrentMedication { get; set; }

        public virtual float? AucFrom { get; set; }
        public virtual float? AucTo { get; set; }


        public virtual float? Dose { get; set; }
        public virtual float? DailyDose { get; set; }
        public virtual float? TherapyMaxDose { get; set; }
        public virtual float? DailyMaxDose { get; set; }

        public virtual bool DonationInTheMorning { get; set; }
        public virtual bool DonationAtNoon { get; set; }
        public virtual bool DonationInTheEvening { get; set; }
        public virtual bool DonationAtNight { get; set; }
        public virtual DonationUnit DonationUnit { get; set; }
        public virtual int? DonationCount { get; set; }
        public virtual DonationKind DonationKind { get; set; }

        public virtual string InfusionDuration { get; set; }
        public virtual InfusionDurationUnit InfusionDurationUnit { get; set; }

        public virtual Solvent Solvent { get; set; }
        public virtual SolventUnit SolventUnit { get; set; }
        public virtual float? SolventAmount { get; set; }



        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as Medication).SubstanceName = SubstanceName;
            (copy as Medication).CalculationMethod = CalculationMethod;
            (copy as Medication).IsConcurrentMedication = IsConcurrentMedication;
            (copy as Medication).AucFrom = AucFrom;
            (copy as Medication).AucTo = AucTo;
            (copy as Medication).Dose = Dose;
            (copy as Medication).DailyDose = DailyDose;
            (copy as Medication).TherapyMaxDose = TherapyMaxDose;
            (copy as Medication).DailyMaxDose = DailyMaxDose;
            (copy as Medication).DonationInTheMorning = DonationInTheMorning;
            (copy as Medication).DonationAtNoon = DonationAtNoon;
            (copy as Medication).DonationInTheEvening = DonationInTheEvening;
            (copy as Medication).DonationAtNight = DonationAtNight;
            (copy as Medication).DonationUnit = DonationUnit;
            (copy as Medication).DonationCount = DonationCount;
            (copy as Medication).DonationKind = DonationKind;
            (copy as Medication).InfusionDuration = InfusionDuration;
            (copy as Medication).InfusionDurationUnit = InfusionDurationUnit;
            (copy as Medication).Solvent = Solvent;
            (copy as Medication).SolventUnit = SolventUnit;
            (copy as Medication).SolventAmount = SolventAmount;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Medication copy = new Medication();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}