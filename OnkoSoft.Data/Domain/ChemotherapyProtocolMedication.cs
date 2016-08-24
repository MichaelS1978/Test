using OnkoSoft.Data.Attributes;
using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class ChemotherapyProtocolMedication : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual ChemotherapyProtocol ChemotherapyProtocol { get; set; }

        public virtual int? SortOrder { get; set; }
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
        public virtual float? TherapyMaxDose { get; set; }
        public virtual float? DailyMaxDose { get; set; }

        public virtual bool DonationInTheMorning { get; set; }
        public virtual bool DonationAtNoon { get; set; }
        public virtual bool DonationInTheEvening { get; set; }
        public virtual bool DonationAtNight { get; set; }
        public virtual DonationUnit DonationUnit { get; set; }
        public virtual int? DonationCount { get; set; }
        public virtual string DonationTime { get; set; }
        public virtual DonationKind DonationKind { get; set; }

        public virtual string InfusionDuration { get; set; }
        public virtual InfusionDurationUnit InfusionDurationUnit { get; set; }

        public virtual Solvent Solvent { get; set; }
        public virtual SolventUnit SolventUnit { get; set; }
        public virtual float? SolventAmount { get; set; }

        public virtual string TherapyDays { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as ChemotherapyProtocolMedication).ChemotherapyProtocol = ChemotherapyProtocol;
            (copy as ChemotherapyProtocolMedication).SortOrder = SortOrder;
            (copy as ChemotherapyProtocolMedication).SubstanceName = SubstanceName;
            (copy as ChemotherapyProtocolMedication).Annotation = Annotation;
            (copy as ChemotherapyProtocolMedication).CalculationMethod = CalculationMethod;
            (copy as ChemotherapyProtocolMedication).BodySurfaceMax2SquareMeter = BodySurfaceMax2SquareMeter;
            (copy as ChemotherapyProtocolMedication).IsConcurrentMedication = IsConcurrentMedication;
            (copy as ChemotherapyProtocolMedication).IsLoadingDose = IsLoadingDose;
            (copy as ChemotherapyProtocolMedication).MarginalWeight = MarginalWeight;
            (copy as ChemotherapyProtocolMedication).UseForSchedule = UseForSchedule;
            (copy as ChemotherapyProtocolMedication).AucFrom = AucFrom;
            (copy as ChemotherapyProtocolMedication).AucTo = AucTo;
            (copy as ChemotherapyProtocolMedication).UseForPrescription = UseForPrescription;
            (copy as ChemotherapyProtocolMedication).PrescriptionDetails = PrescriptionDetails;
            (copy as ChemotherapyProtocolMedication).DoRounding = DoRounding;
            (copy as ChemotherapyProtocolMedication).RoundAccuracy = RoundAccuracy;
            (copy as ChemotherapyProtocolMedication).Dose = Dose;
            (copy as ChemotherapyProtocolMedication).DailyDose = DailyDose;
            (copy as ChemotherapyProtocolMedication).TherapyMaxDose = TherapyMaxDose;
            (copy as ChemotherapyProtocolMedication).DailyMaxDose = DailyMaxDose;
            (copy as ChemotherapyProtocolMedication).DonationInTheMorning = DonationInTheMorning;
            (copy as ChemotherapyProtocolMedication).DonationAtNoon = DonationAtNoon;
            (copy as ChemotherapyProtocolMedication).DonationInTheEvening = DonationInTheEvening;
            (copy as ChemotherapyProtocolMedication).DonationAtNight = DonationAtNight;
            (copy as ChemotherapyProtocolMedication).DonationUnit = DonationUnit;
            (copy as ChemotherapyProtocolMedication).DonationCount = DonationCount;
            (copy as ChemotherapyProtocolMedication).DonationTime = DonationTime;
            (copy as ChemotherapyProtocolMedication).DonationKind = DonationKind;
            (copy as ChemotherapyProtocolMedication).InfusionDuration = InfusionDuration;
            (copy as ChemotherapyProtocolMedication).InfusionDurationUnit = InfusionDurationUnit;
            (copy as ChemotherapyProtocolMedication).Solvent = Solvent;
            (copy as ChemotherapyProtocolMedication).SolventUnit = SolventUnit;
            (copy as ChemotherapyProtocolMedication).SolventAmount = SolventAmount;
            (copy as ChemotherapyProtocolMedication).TherapyDays = TherapyDays;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            ChemotherapyProtocolMedication copy = new ChemotherapyProtocolMedication();
            CopyTo(copy, copyIdentity);

            return copy;
        }

        #region Depcrecated
        //TODO: IntMM - später entfernen
        public virtual string Medicine { get; set; }

        public virtual DecimalRounding DecimalRounding { get; set; }

        public virtual float? NominalDose { get; set; }

        public virtual RelativeFactor RelativeFactor { get; set; }

        public virtual string Application { get; set; }

        public virtual int? TherapyDay1 { get; set; }

        public virtual int? TherapyDay2 { get; set; }

        public virtual int? TherapyDay3 { get; set; }

        public virtual int? TherapyDay4 { get; set; }

        public virtual int? TherapyDay5 { get; set; }

        public virtual int? TherapyDay6 { get; set; }

        public virtual int? TherapyDay7 { get; set; }

        #endregion
    }
}