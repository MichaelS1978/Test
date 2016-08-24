using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain
{
    public class UserRightUserRole : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual UserRight UserRight { get; set; }

        public virtual UserRole Role { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as UserRightUserRole).UserRight = UserRight;
            (copy as UserRightUserRole).Role = Role;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            UserRightUserRole copy = new UserRightUserRole();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}