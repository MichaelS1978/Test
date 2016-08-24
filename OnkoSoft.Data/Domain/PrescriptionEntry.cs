using OnkoSoft.Data.Attributes;
using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class PrescriptionEntry : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual Prescription Prescription { get; set; }
        public virtual int? LocalMedicineId { get; set; }
        public virtual string PreparationName { get; set; }
        public virtual string PackageSizeDetails { get; set; }
        public virtual float? PharmacyRetailPrice { get; set; }
        public virtual float? FixedAmount { get; set; }
        public virtual float? Dose { get; set; }
        public virtual string Unit { get; set; }
        public virtual Solvent Solvent { get; set; }
        public virtual SolventUnit SolventUnit { get; set; }
        public virtual float? SolventAmount { get; set; }
        public virtual string PharmaceuticalCentralNumber { get; set; }
        public virtual string PrescriptionDetails { get; set; }
        public virtual int Count { get; set; }
        public virtual bool IsAlternativePossible { get; set; }
        public virtual int SortOrder { get; set; }


        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as PrescriptionEntry).Prescription = Prescription;
            (copy as PrescriptionEntry).LocalMedicineId = LocalMedicineId;
            (copy as PrescriptionEntry).PreparationName = PreparationName;
            (copy as PrescriptionEntry).PackageSizeDetails = PackageSizeDetails;
            (copy as PrescriptionEntry).PharmacyRetailPrice = PharmacyRetailPrice;
            (copy as PrescriptionEntry).FixedAmount = FixedAmount;
            (copy as PrescriptionEntry).Dose = Dose;
            (copy as PrescriptionEntry).Unit = Unit;
            (copy as PrescriptionEntry).Solvent = Solvent;
            (copy as PrescriptionEntry).SolventUnit = SolventUnit;
            (copy as PrescriptionEntry).SolventAmount = SolventAmount;
            (copy as PrescriptionEntry).PharmaceuticalCentralNumber = PharmaceuticalCentralNumber;
            (copy as PrescriptionEntry).PrescriptionDetails = PrescriptionDetails;
            (copy as PrescriptionEntry).Count = Count;
            (copy as PrescriptionEntry).IsAlternativePossible = IsAlternativePossible;
            (copy as PrescriptionEntry).SortOrder = SortOrder;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            PrescriptionEntry copy = new PrescriptionEntry();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}

