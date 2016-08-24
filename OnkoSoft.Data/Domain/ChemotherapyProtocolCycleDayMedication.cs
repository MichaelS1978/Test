using OnkoSoft.Data.Attributes;
using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class ChemotherapyProtocolCycleDayMedication : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual ChemotherapyProtocolCycleDay ChemotherapyProtocolCycleDay { get; set; }

        public virtual string SubstanceName { get; set; }
        public virtual string Annotation { get; set; }
        public virtual CalculationMethod CalculationMethod { get; set; }
        public virtual bool BodySurfaceMax2SquareMeter { get; set; }
        public virtual bool IsConcurrentMedication { get; set; }
        public virtual bool IsLoadingDose { get; set; }
        public virtual float? MarginalWeight { get; set; }
        public virtual bool UseForSchedule { get; set; }

        public virtual float? AucFrom { get; set; }
        public virtual float? AucTo { get; set; }

        public virtual bool UseForPrescription { get; set; }
        public virtual string PrescriptionDetails { get; set; }

        public virtual bool DoRounding { get; set; }
        public virtual RoundAccuracy RoundAccuracy { get; set; }

        public virtual float? Dose { get; set; }
        public virtual float? DailyDose { get; set; }
        public virtual float? DailyMaxDose { get; set; }

        public virtual bool DonationInTheMorning { get; set; }
        public virtual bool DonationAtNoon { get; set; }
        public virtual bool DonationInTheEvening { get; set; }
        public virtual bool DonationAtNight { get; set; }
        public virtual DonationUnit DonationUnit { get; set; }
        public virtual int? DonationCount { get; set; }
        public virtual int? DonationOrder { get; set; }
        public virtual string DonationTime { get; set; }
        public virtual DonationKind DonationKind { get; set; }

        public virtual string InfusionDuration { get; set; }
        public virtual InfusionDurationUnit InfusionDurationUnit { get; set; }

        public virtual Solvent Solvent { get; set; }
        public virtual SolventUnit SolventUnit { get; set; }
        public virtual float? SolventAmount { get; set; }


        public ChemotherapyProtocolCycleDayMedication()
        {}

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as ChemotherapyProtocolCycleDayMedication).ChemotherapyProtocolCycleDay = ChemotherapyProtocolCycleDay;
            (copy as ChemotherapyProtocolCycleDayMedication).SubstanceName = SubstanceName;
            (copy as ChemotherapyProtocolCycleDayMedication).Annotation = Annotation;
            (copy as ChemotherapyProtocolCycleDayMedication).CalculationMethod = CalculationMethod;
            (copy as ChemotherapyProtocolCycleDayMedication).BodySurfaceMax2SquareMeter = BodySurfaceMax2SquareMeter;
            (copy as ChemotherapyProtocolCycleDayMedication).IsConcurrentMedication = IsConcurrentMedication;
            (copy as ChemotherapyProtocolCycleDayMedication).IsLoadingDose = IsLoadingDose;
            (copy as ChemotherapyProtocolCycleDayMedication).MarginalWeight = MarginalWeight;
            (copy as ChemotherapyProtocolCycleDayMedication).UseForSchedule = UseForSchedule;
            (copy as ChemotherapyProtocolCycleDayMedication).AucFrom = AucFrom;
            (copy as ChemotherapyProtocolCycleDayMedication).AucTo = AucTo;
            (copy as ChemotherapyProtocolCycleDayMedication).UseForPrescription = UseForPrescription;
            (copy as ChemotherapyProtocolCycleDayMedication).PrescriptionDetails = PrescriptionDetails;
            (copy as ChemotherapyProtocolCycleDayMedication).DoRounding = DoRounding;
            (copy as ChemotherapyProtocolCycleDayMedication).RoundAccuracy = RoundAccuracy;
            (copy as ChemotherapyProtocolCycleDayMedication).Dose = Dose;
            (copy as ChemotherapyProtocolCycleDayMedication).DailyDose = DailyDose;
            (copy as ChemotherapyProtocolCycleDayMedication).DailyMaxDose = DailyMaxDose;
            (copy as ChemotherapyProtocolCycleDayMedication).DonationInTheMorning = DonationInTheMorning;
            (copy as ChemotherapyProtocolCycleDayMedication).DonationAtNoon = DonationAtNoon;
            (copy as ChemotherapyProtocolCycleDayMedication).DonationInTheEvening = DonationInTheEvening;
            (copy as ChemotherapyProtocolCycleDayMedication).DonationAtNight = DonationAtNight;
            (copy as ChemotherapyProtocolCycleDayMedication).DonationUnit = DonationUnit;
            (copy as ChemotherapyProtocolCycleDayMedication).DonationCount = DonationCount;
            (copy as ChemotherapyProtocolCycleDayMedication).DonationOrder = DonationOrder;
            (copy as ChemotherapyProtocolCycleDayMedication).DonationTime = DonationTime;
            (copy as ChemotherapyProtocolCycleDayMedication).DonationKind = DonationKind;
            (copy as ChemotherapyProtocolCycleDayMedication).InfusionDuration = InfusionDuration;
            (copy as ChemotherapyProtocolCycleDayMedication).InfusionDurationUnit = InfusionDurationUnit;
            (copy as ChemotherapyProtocolCycleDayMedication).Solvent = Solvent;
            (copy as ChemotherapyProtocolCycleDayMedication).SolventUnit = SolventUnit;
            (copy as ChemotherapyProtocolCycleDayMedication).SolventAmount = SolventAmount;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            ChemotherapyProtocolCycleDayMedication copy = new ChemotherapyProtocolCycleDayMedication();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}