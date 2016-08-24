using System.Diagnostics;

namespace OnkoSoft.Data.Domain.ChangeLog
{
    [DebuggerDisplay("EntityType = {EntityType}, EntityId = {EntityId}, EntityChangeType = {EntityChangeType}")]
    public class ChangeLog : OnkoSoftBase
    {
        public virtual string EntityType { get; set; }
        public virtual int EntityId { get; set; }
        public virtual ChangeType EntityChangeType { get; set; }
        public virtual ChangeLogEntity EntityChangeLog { get; set; }
        public virtual bool ErrorOccurred { get; set; }
        public virtual string ErrorMessage { get; set; }
    }
}
