using System;
using OnkoSoft.Data.Attributes;
using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class ChemotherapyCycleDayMedication : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual ChemotherapyCycleDay ChemotherapyCycleDay { get; set; }

        public virtual string SubstanceName { get; set; }
        public virtual string Annotation { get; set; }
        public virtual CalculationMethod CalculationMethod { get; set; }
        public virtual bool BodySurfaceMax2SquareMeter { get; set; }
        public virtual bool IsConcurrentMedication { get; set; }
        public virtual bool IsLoadingDose { get; set; }
        public virtual float? MarginalWeight { get; set; }
        public virtual bool UseForSchedule { get; set; }

        public virtual TreatmentStatus TreatmentStatus { get; set; }

        public virtual float? AucFrom { get; set; }
        public virtual float? AucTo { get; set; }
        public virtual float? AucCreatinin { get; set; }
        public virtual float? AucTarget { get; set; }

        public virtual bool UseForPrescription { get; set; }
        public virtual string PrescriptionDetails { get; set; }

        public virtual bool DoRounding { get; set; }
        public virtual RoundAccuracy RoundAccuracy { get; set; }

        public virtual float? Dose { get; set; }
        public virtual float? ActualDose { get; set; }
        public virtual float? ActualDoseAccumulated { get; set; }
        public virtual float? TargetDose { get; set; }
        public virtual float? TargetDoseAccumulated { get; set; }
        public virtual float? DoseReduction { get; set; }


        public virtual float? DailyDose { get; set; }
        public virtual float? ActualDailyDose { get; set; }
        public virtual float? TargetDailyDose { get; set; }
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
        public virtual DateTime? PackageDonationTime { get; set; } 

        public virtual string InfusionDuration { get; set; }
        public virtual InfusionDurationUnit InfusionDurationUnit { get; set; }

        public virtual Solvent Solvent { get; set; }
        public virtual SolventUnit SolventUnit { get; set; }
        public virtual float? SolventAmount { get; set; }

        public virtual string Medicine { get; set; }


        public ChemotherapyCycleDayMedication()
        { }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as ChemotherapyCycleDayMedication).ChemotherapyCycleDay = ChemotherapyCycleDay;
            (copy as ChemotherapyCycleDayMedication).SubstanceName = SubstanceName;
            (copy as ChemotherapyCycleDayMedication).Annotation = Annotation;
            (copy as ChemotherapyCycleDayMedication).CalculationMethod = CalculationMethod;
            (copy as ChemotherapyCycleDayMedication).BodySurfaceMax2SquareMeter = BodySurfaceMax2SquareMeter;
            (copy as ChemotherapyCycleDayMedication).IsConcurrentMedication = IsConcurrentMedication;
            (copy as ChemotherapyCycleDayMedication).IsLoadingDose = IsLoadingDose;
            (copy as ChemotherapyCycleDayMedication).MarginalWeight = MarginalWeight;
            (copy as ChemotherapyCycleDayMedication).UseForSchedule = UseForSchedule;
            (copy as ChemotherapyCycleDayMedication).TreatmentStatus = TreatmentStatus;
            (copy as ChemotherapyCycleDayMedication).AucFrom = AucFrom;
            (copy as ChemotherapyCycleDayMedication).AucTo = AucTo;
            (copy as ChemotherapyCycleDayMedication).AucCreatinin = AucCreatinin;
            (copy as ChemotherapyCycleDayMedication).AucTarget = AucTarget;
            (copy as ChemotherapyCycleDayMedication).UseForPrescription = UseForPrescription;
            (copy as ChemotherapyCycleDayMedication).PrescriptionDetails = PrescriptionDetails;
            (copy as ChemotherapyCycleDayMedication).DoRounding = DoRounding;
            (copy as ChemotherapyCycleDayMedication).RoundAccuracy = RoundAccuracy;
            (copy as ChemotherapyCycleDayMedication).Dose = Dose;
            (copy as ChemotherapyCycleDayMedication).ActualDose = ActualDose;
            (copy as ChemotherapyCycleDayMedication).ActualDoseAccumulated = ActualDoseAccumulated;
            (copy as ChemotherapyCycleDayMedication).TargetDose = TargetDose;
            (copy as ChemotherapyCycleDayMedication).TargetDoseAccumulated = TargetDoseAccumulated;
            (copy as ChemotherapyCycleDayMedication).DoseReduction = DoseReduction;
            (copy as ChemotherapyCycleDayMedication).DailyDose = DailyDose;
            (copy as ChemotherapyCycleDayMedication).ActualDailyDose = ActualDailyDose;
            (copy as ChemotherapyCycleDayMedication).TargetDailyDose = TargetDailyDose;
            (copy as ChemotherapyCycleDayMedication).DailyMaxDose = DailyMaxDose;
            (copy as ChemotherapyCycleDayMedication).DonationInTheMorning = DonationInTheMorning;
            (copy as ChemotherapyCycleDayMedication).DonationAtNoon = DonationAtNoon;
            (copy as ChemotherapyCycleDayMedication).DonationInTheEvening = DonationInTheEvening;
            (copy as ChemotherapyCycleDayMedication).DonationAtNight = DonationAtNight;
            (copy as ChemotherapyCycleDayMedication).DonationUnit = DonationUnit;
            (copy as ChemotherapyCycleDayMedication).DonationCount = DonationCount;
            (copy as ChemotherapyCycleDayMedication).DonationOrder = DonationOrder;
            (copy as ChemotherapyCycleDayMedication).DonationTime = DonationTime;
            (copy as ChemotherapyCycleDayMedication).DonationKind = DonationKind;
            (copy as ChemotherapyCycleDayMedication).PackageDonationTime = PackageDonationTime;
            (copy as ChemotherapyCycleDayMedication).InfusionDuration = InfusionDuration;
            (copy as ChemotherapyCycleDayMedication).InfusionDurationUnit = InfusionDurationUnit;
            (copy as ChemotherapyCycleDayMedication).Solvent = Solvent;
            (copy as ChemotherapyCycleDayMedication).SolventUnit = SolventUnit;
            (copy as ChemotherapyCycleDayMedication).SolventAmount = SolventAmount;
            (copy as ChemotherapyCycleDayMedication).Medicine = Medicine;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            ChemotherapyCycleDayMedication copy = new ChemotherapyCycleDayMedication();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}