using OnkoSoft.Data.Attributes;
namespace OnkoSoft.Data.Domain
{
    public class ChemotherapyMedication : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual Chemotherapy Chemotherapy { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual string Medicine { get; set; }

        public virtual DecimalRounding DecimalRounding { get; set; }

        public virtual float? NominalDose { get; set; }

        public virtual RelativeFactor RelativeFactor { get; set; }

        public virtual int? DosePercentage { get; set; }

        public virtual float? DoseAbsolute { get; set; }

        public virtual string Application { get; set; }

        public virtual int? DonationCount { get; set; }

        public virtual string TherapyDate1 { get; set; }

        public virtual string TherapyDate2 { get; set; }

        public virtual string TherapyDate3 { get; set; }

        public virtual string TherapyDate4 { get; set; }

        public virtual string TherapyDate5 { get; set; }

        public virtual string TherapyDate6 { get; set; }

        public virtual string TherapyDate7 { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as ChemotherapyMedication).Chemotherapy = Chemotherapy;
            (copy as ChemotherapyMedication).SortOrder = SortOrder;
            (copy as ChemotherapyMedication).Medicine = Medicine;
            (copy as ChemotherapyMedication).DecimalRounding = DecimalRounding;
            (copy as ChemotherapyMedication).NominalDose = NominalDose;
            (copy as ChemotherapyMedication).RelativeFactor = RelativeFactor;
            (copy as ChemotherapyMedication).DosePercentage = DosePercentage;
            (copy as ChemotherapyMedication).DoseAbsolute = DoseAbsolute;
            (copy as ChemotherapyMedication).Application = Application;
            (copy as ChemotherapyMedication).DonationCount = DonationCount;
            (copy as ChemotherapyMedication).TherapyDate1 = TherapyDate1;
            (copy as ChemotherapyMedication).TherapyDate2 = TherapyDate2;
            (copy as ChemotherapyMedication).TherapyDate3 = TherapyDate3;
            (copy as ChemotherapyMedication).TherapyDate4 = TherapyDate4;
            (copy as ChemotherapyMedication).TherapyDate5 = TherapyDate5;
            (copy as ChemotherapyMedication).TherapyDate6 = TherapyDate6;
            (copy as ChemotherapyMedication).TherapyDate7 = TherapyDate7;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            ChemotherapyMedication copy = new ChemotherapyMedication();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}