using System;
using System.Collections.Generic;
using OnkoSoft.Data.Attributes;
using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class ChemotherapyCycleDay : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual ChemotherapyCycle ChemotherapyCycle { get; set; }

        public virtual int? AppointmentId { get; set; }

        public virtual int TherapyDay { get; set; }
        public virtual DateTime TherapyDate { get; set; }

        public virtual float? PatientWeight { get; set; }

        public virtual float? PatientBodySurface { get; set; }

        public virtual string Gateway { get; set; }

        //TODO: IntMM - Richtige Stati herausfinden
        public virtual TherapyCycleDayStatus Status { get; set; }
        //TODO: IntMM - Richtige Stati herausfinden
        public virtual TherapyCycleDayAppointmentStatus AppointmentStatus { get; set; }

        public virtual IList<ChemotherapyCycleDayMedication> Medications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChemotherapyCycleDay()
        {
            Medications = new List<ChemotherapyCycleDayMedication>();
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as ChemotherapyCycleDay).ChemotherapyCycle = ChemotherapyCycle;
            (copy as ChemotherapyCycleDay).AppointmentId = AppointmentId;
            (copy as ChemotherapyCycleDay).TherapyDay = TherapyDay;
            (copy as ChemotherapyCycleDay).TherapyDate = TherapyDate;
            (copy as ChemotherapyCycleDay).PatientWeight = PatientWeight;
            (copy as ChemotherapyCycleDay).PatientBodySurface = PatientBodySurface;
            (copy as ChemotherapyCycleDay).Gateway = Gateway;
            (copy as ChemotherapyCycleDay).Status = Status;
            (copy as ChemotherapyCycleDay).AppointmentStatus = AppointmentStatus;

            (copy as ChemotherapyCycleDay).Medications.Clear();

            foreach (ChemotherapyCycleDayMedication ccdMed in Medications)
            {
                ChemotherapyCycleDayMedication newCcdMed = ccdMed.Copy(copyIdentity) as ChemotherapyCycleDayMedication;
                newCcdMed.ChemotherapyCycleDay = (copy as ChemotherapyCycleDay);
                (copy as ChemotherapyCycleDay).Medications.Add(newCcdMed);
            }
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            ChemotherapyCycleDay copy = new ChemotherapyCycleDay();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}