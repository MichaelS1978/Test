namespace OnkoSoft.Data.Domain
{
    public class LocalMedicine : OnkoSoftBase
    {
        public virtual string PreparationName { get; set; }
        public virtual bool IsArchived { get; set; }
        public virtual string PackageSizeDetails { get; set; }
        public virtual float? PharmacyRetailPrice { get; set; }
        public virtual float? FixedAmount { get; set; }
        public virtual string PharmaceuticalCentralNumber { get; set; }
        public virtual int? ExternalId { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as LocalMedicine).PreparationName = PreparationName;
            (copy as LocalMedicine).IsArchived = IsArchived;
            (copy as LocalMedicine).PackageSizeDetails = PackageSizeDetails;
            (copy as LocalMedicine).PharmacyRetailPrice = PharmacyRetailPrice;
            (copy as LocalMedicine).FixedAmount = FixedAmount;
            (copy as LocalMedicine).PharmaceuticalCentralNumber = PharmaceuticalCentralNumber;
            (copy as LocalMedicine).ExternalId = ExternalId;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            LocalMedicine copy = new LocalMedicine();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}

