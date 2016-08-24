using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain
{
    public class AppliedMedicine : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual Patient Patient { get; set; }
        public virtual int? LocalMedicineId { get; set; }
        public virtual string PreparationName { get; set; }
        public virtual bool IsArchived { get; set; }
        public virtual string PackageSizeDetails { get; set; }
        public virtual float? PharmacyRetailPrice { get; set; }
        public virtual float? FixedAmount { get; set; }
        public virtual string PharmaceuticalCentralNumber { get; set; }
        public virtual int Count { get; set; }
        public virtual bool IsAlternativePossible { get; set; }
        public virtual int SortOrder { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as AppliedMedicine).Patient = Patient;
            (copy as AppliedMedicine).LocalMedicineId = LocalMedicineId;
            (copy as AppliedMedicine).PreparationName = PreparationName;
            (copy as AppliedMedicine).IsArchived = IsArchived;
            (copy as AppliedMedicine).PackageSizeDetails = PackageSizeDetails;
            (copy as AppliedMedicine).PharmacyRetailPrice = PharmacyRetailPrice;
            (copy as AppliedMedicine).FixedAmount = FixedAmount;
            (copy as AppliedMedicine).PharmaceuticalCentralNumber = PharmaceuticalCentralNumber;
            (copy as AppliedMedicine).Count = Count;
            (copy as AppliedMedicine).IsAlternativePossible = IsAlternativePossible;
            (copy as AppliedMedicine).SortOrder = SortOrder;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            AppliedMedicine copy = new AppliedMedicine();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}

