namespace OnkoSoft.Data.Domain
{
    public class AppointmentResource : OnkoSoftBase
    {
        public virtual string Name { get; set; }
        public virtual int? ExternalId { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as AppointmentResource).Name = Name;
            (copy as AppointmentResource).ExternalId = ExternalId;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            AppointmentResource copy = new AppointmentResource();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}