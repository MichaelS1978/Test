using System.Collections.Generic;
using System.Diagnostics;

namespace OnkoSoft.Data.Domain.ChangeLog
{
    [DebuggerDisplay("MemberType = {MemberType}, MemberName = {MemberName}")]
    public class ChangeLogList : ChangeLogMemberBase
    {
        public virtual IList<ChangeLogListItem> ItemsChangeLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChangeLogList()
        {
            ItemsChangeLog = new List<ChangeLogListItem>();
        }
    }
}
