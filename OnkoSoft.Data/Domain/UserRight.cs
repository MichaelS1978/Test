using System.Collections.Generic;

namespace OnkoSoft.Data.Domain
{
    public class UserRight : OnkoSoftBase
    {
        public virtual ApplicationFunction ApplicationFunction { get; set; }

        public virtual IList<UserRightUserRole> UserRightUserRoleList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserRight()
        {
            UserRightUserRoleList = new List<UserRightUserRole>();
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as UserRight).ApplicationFunction = ApplicationFunction;

            foreach (UserRightUserRole userRightUserRole in UserRightUserRoleList)
            {
                UserRightUserRole newUserRightUserRole = userRightUserRole.Copy(copyIdentity) as UserRightUserRole;
                userRightUserRole.UserRight = (copy as UserRight);
                (copy as UserRight).UserRightUserRoleList.Add(newUserRightUserRole);
            }
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            UserRight copy = new UserRight();
            CopyTo(copy, copyIdentity);

            return copy;
        }

    }
}