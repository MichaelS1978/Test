using System;
using System.Collections.Generic;

namespace OnkoSoft.Data.Domain
{
    public class User : OnkoSoftBase
    {
        public virtual bool IsArchived { get; set; }

        public virtual string Name { get; set; }

        public virtual DateTime LastPasswordChange { get; set; }

        public virtual UserRole Role { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual DateTime DateCreated { get; set; }

        public virtual DateTime? LastLogin { get; set; }

        public virtual int? DefaultDoctorId { get; set; }

        public virtual IList<UserPassword> PasswordList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            PasswordList = new List<UserPassword>();
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as User).IsArchived = IsArchived;
            (copy as User).Name = Name;
            (copy as User).LastPasswordChange = LastPasswordChange;
            (copy as User).Role = Role;
            (copy as User).FirstName = FirstName;
            (copy as User).LastName = LastName;
            (copy as User).DateCreated = DateCreated;
            (copy as User).LastLogin = LastLogin;
            (copy as User).DefaultDoctorId = DefaultDoctorId;

            foreach (UserPassword password in PasswordList)
            {
                UserPassword newPassword = password.Copy(copyIdentity) as UserPassword;
                newPassword.User = (copy as User);
                (copy as User).PasswordList.Add(newPassword);
            }
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            User copy = new User();
            CopyTo(copy, copyIdentity);

            return copy;
        }

    }
}