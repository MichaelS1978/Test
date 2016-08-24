using System.Diagnostics;

namespace OnkoSoft.Data.Domain.ChangeLog
{
    [DebuggerDisplay("Index = {Index}")]
    public class ChangeLogListItem : OnkoSoftBase
    {
        public virtual ChangeLogList ParentChangeLogList { get; set; }

        public virtual int ItemIndex { get; set; }
        public virtual ChangeLogMemberBase ItemChangeLog { get; set; }
        
    }
}
