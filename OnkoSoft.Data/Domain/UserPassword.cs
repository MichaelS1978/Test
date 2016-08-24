using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain
{
    public class UserPassword : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual User User { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual string PasswordHash { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as UserPassword).User = User;
            (copy as UserPassword).SortOrder = SortOrder;
            (copy as UserPassword).PasswordHash = PasswordHash;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            UserPassword copy = new UserPassword();
            CopyTo(copy, copyIdentity);

            return copy;
        }

    }
}