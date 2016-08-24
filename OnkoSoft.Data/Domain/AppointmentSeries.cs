using System.Collections.Generic;
using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class AppointmentSeries : OnkoSoftBase
    {
        public virtual AppointmentSeriesType Type { get; set; }
        public virtual int? ExternalId { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as AppointmentSeries).Type = Type;
            (copy as AppointmentSeries).ExternalId = ExternalId;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Appointment copy = new Appointment();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}

