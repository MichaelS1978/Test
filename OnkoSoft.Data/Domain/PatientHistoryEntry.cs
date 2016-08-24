
namespace OnkoSoft.Data.Domain
{
    public class PatientHistoryEntry : OnkoSoftBase
    {
        public virtual int UserId { get; set; }

        public virtual int PatientId { get; set; }

        public virtual int SortOrder { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as PatientHistoryEntry).UserId = UserId;
            (copy as PatientHistoryEntry).PatientId = PatientId;
            (copy as PatientHistoryEntry).SortOrder = SortOrder;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            PatientHistoryEntry copy = new PatientHistoryEntry();
            CopyTo(copy, copyIdentity);

            return copy;
        }

    }
}
