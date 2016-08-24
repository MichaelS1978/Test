
namespace OnkoSoft.Data.Domain
{
    public class DatabaseVersion : SoftwareVersion
    {
        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            DatabaseVersion copy = new DatabaseVersion();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}
