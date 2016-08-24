using System;
using OnkoSoft.Data.Attributes;
using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class Appointment : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual int? AppointmentSeriesId { get; set; }
        public virtual int? UserId { get; set; }
        public virtual int? ResourceId { get; set; }
        public virtual int? PatientId { get; set; }
        public virtual string DescriptionShort { get; set; }
        public virtual string DescriptionLong { get; set; }
        public virtual bool DoRemind { get; set; }
        public virtual DateTime AppointmentBegin { get; set; }
        public virtual DateTime AppointmenEnd { get; set; }
        public virtual DateTime? AppointmentRemind { get; set; }
        public virtual AppointmentReminderPeriod ReminderPeriod { get; set; }
        public virtual AppointmentStatus Status { get; set; }
        public virtual int? ExternalId { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as Appointment).AppointmentSeriesId = AppointmentSeriesId;
            (copy as Appointment).UserId = UserId;
            (copy as Appointment).ResourceId = ResourceId;
            (copy as Appointment).PatientId = PatientId;
            (copy as Appointment).DescriptionShort = DescriptionShort;
            (copy as Appointment).DescriptionLong = DescriptionLong;
            (copy as Appointment).DoRemind = DoRemind;
            (copy as Appointment).AppointmentBegin = AppointmentBegin;
            (copy as Appointment).AppointmenEnd = AppointmenEnd;
            (copy as Appointment).AppointmentRemind = AppointmentRemind;
            (copy as Appointment).ReminderPeriod = ReminderPeriod;
            (copy as Appointment).Status = Status;
            (copy as Appointment).ExternalId = ExternalId;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Appointment copy = new Appointment();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}

