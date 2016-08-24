
namespace OnkoSoft.Data.Domain
{
    public class ApplicationVersion : SoftwareVersion
    {
        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            ApplicationVersion copy = new ApplicationVersion();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}
