using System.Collections.Generic;
using System.Diagnostics;

namespace OnkoSoft.Data.Domain.ChangeLog
{
    [DebuggerDisplay("OldId = {OldId}, NewId = {NewId}, ChangeType = {ChangeType}, MemberType = {MemberType}, MemberName = {MemberName}")]
    public class ChangeLogEntity : ChangeLogMemberBase
    {
        public virtual int? OldId { get; set; }
        public virtual int? NewId { get; set; }
        public virtual IList<ChangeLogMemberBase> PropertiesChangeLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChangeLogEntity()
        {
            PropertiesChangeLog = new List<ChangeLogMemberBase>();
        }
    }
}
