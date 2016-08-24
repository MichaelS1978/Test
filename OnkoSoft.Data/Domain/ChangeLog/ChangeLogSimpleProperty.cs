using System.Diagnostics;

namespace OnkoSoft.Data.Domain.ChangeLog
{
    [DebuggerDisplay("OldValueStr = {OldValueStr}, NewValueStr = {NewValueStr}, ChangeType = {ChangeType}, MemberType = {MemberType}, MemberName = {MemberName}")]
    public class ChangeLogSimpleProperty : ChangeLogMemberBase
    {
        public virtual string OldValueStr { get; set; }
        public virtual string NewValueStr { get; set; }
    }
}
