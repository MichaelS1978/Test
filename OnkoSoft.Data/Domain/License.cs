
namespace OnkoSoft.Data.Domain
{
    public class License : OnkoSoftBase
    {
        public virtual string LicenseCode { get; set; }
        public virtual string LicenseData { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as License).LicenseCode = LicenseCode;
            (copy as License).LicenseData = LicenseData;
        }

    }
}
