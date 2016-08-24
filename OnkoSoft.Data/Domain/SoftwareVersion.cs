
namespace OnkoSoft.Data.Domain
{
    public abstract class SoftwareVersion : OnkoSoftBase
    {
        public virtual int Major { get; set; }
        public virtual int Minor { get; set; }
        public virtual int Build { get; set; }
        public virtual int Revision { get; set; }
        public virtual string Version
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}", Major, Minor, Build, Revision);
            }
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as SoftwareVersion).Major = Major;
            (copy as SoftwareVersion).Minor = Minor;
            (copy as SoftwareVersion).Build = Build;
            (copy as SoftwareVersion).Revision = Revision;
        }

    }
}
