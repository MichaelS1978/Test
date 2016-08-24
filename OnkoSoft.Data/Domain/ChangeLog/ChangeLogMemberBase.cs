
namespace OnkoSoft.Data.Domain.ChangeLog
{
    public abstract class ChangeLogMemberBase : OnkoSoftBase
    {
        public virtual ChangeLog ChangeLog { get; set; }

        public virtual ChangeLogMemberBase ParentChangeLogMember { get; set; }
        public virtual ChangeLogListItem ParentChangeLogListItem { get; set; }

        public virtual string MemberType { get; set; }
        public virtual string MemberName { get; set; }
        public virtual ChangeType ChangeType { get; set; }
    }
}
