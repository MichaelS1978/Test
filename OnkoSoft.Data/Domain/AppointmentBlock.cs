using System;

namespace OnkoSoft.Data.Domain
{
    public class AppointmentBlock : OnkoSoftBase
    {
        public virtual string Name { get; set; }
        public virtual DateTime BlockBegin { get; set; }
        public virtual DateTime BlockEnd { get; set; }
        public virtual int? ResourceId { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as AppointmentBlock).Name = Name;
            (copy as AppointmentBlock).BlockBegin = BlockBegin;
            (copy as AppointmentBlock).BlockEnd = BlockEnd;
            (copy as AppointmentBlock).ResourceId = ResourceId;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            AppointmentBlock copy = new AppointmentBlock();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}