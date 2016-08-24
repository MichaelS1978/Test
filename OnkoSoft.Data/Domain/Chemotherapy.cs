using System;
using System.Collections.Generic;
using OnkoSoft.Data.Attributes;
using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class Chemotherapy : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual Patient Patient { get; set; }
        public virtual int? DoctorId { get; set; }
        public virtual int? ChemotherapyProtocolId { get; set; }
        public virtual int? TreatmentDays { get; set; }
        public virtual DateTime? TherapyCreationDate { get; set; }
        public virtual DateTime? TherapyStartDate { get; set; }
        public virtual DateTime? TherapyEndDate { get; set; }
        public virtual int? PatientHeight { get; set; }
        public virtual bool BodySurfaceMax2SquareMeter { get; set; }
        public virtual TherapyIntention Intention { get; set; }
        public virtual TherapyStatus Status { get; set; }

        //TODO:  IntMM - Ist das der richtige Datentyp?
        public virtual string TherapyLine { get; set; }
        public virtual string Description { get; set; }
        public virtual int? RepetitionDay { get; set; }
        public virtual string Gateway { get; set; }
        public virtual int? ExternalId { get; set; }

        public virtual IList<ChemotherapyCycle> Cycles { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chemotherapy()
        {
            Cycles = new List<ChemotherapyCycle>();
            MedicationList = new List<ChemotherapyMedication>();
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity) 
        { 
            base.CopyTo(copy, copyIdentity);

            (copy as Chemotherapy).Patient = Patient;
            (copy as Chemotherapy).DoctorId = DoctorId;
            (copy as Chemotherapy).ChemotherapyProtocolId = ChemotherapyProtocolId;
            (copy as Chemotherapy).TreatmentDays = TreatmentDays;
            (copy as Chemotherapy).TherapyCreationDate = TherapyCreationDate;
            (copy as Chemotherapy).TherapyStartDate = TherapyStartDate;
            (copy as Chemotherapy).TherapyEndDate = TherapyEndDate;
            (copy as Chemotherapy).PatientHeight = PatientHeight;
            (copy as Chemotherapy).BodySurfaceMax2SquareMeter = BodySurfaceMax2SquareMeter;
            (copy as Chemotherapy).Intention = Intention;
            (copy as Chemotherapy).Status = Status;
            (copy as Chemotherapy).TherapyLine = TherapyLine;
            (copy as Chemotherapy).Description = Description;
            (copy as Chemotherapy).RepetitionDay = RepetitionDay;
            (copy as Chemotherapy).Gateway = Gateway;
            (copy as Chemotherapy).ExternalId = ExternalId;

            (copy as Chemotherapy).Cycles.Clear();

            foreach (ChemotherapyCycle cycle in Cycles)
            {
                ChemotherapyCycle newCycle = cycle.Copy(copyIdentity) as ChemotherapyCycle;
                newCycle.Chemotherapy = (copy as Chemotherapy);
                (copy as Chemotherapy).Cycles.Add(newCycle);
            }
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Chemotherapy copy = new Chemotherapy();
            CopyTo(copy, copyIdentity);

            return copy;
        }

        #region Deprecated

        //TODO: IntMM - später entfernen
        public virtual IList<ChemotherapyMedication> MedicationList { get; set; }

        public virtual float? PatientWeight { get; set; }

        public virtual bool OverrideCalculatedPatientBodySurface { get; set; }

        public virtual float? ManualPatientBodySurface { get; set; }

        public virtual string Protocol { get; set; }

        public virtual string ProtocolDiagnosisGroup { get; set; }

        public virtual int? Cycle { get; set; }

        public virtual string Station { get; set; }

        public virtual string Doctor { get; set; }

        public virtual string TherapyTarget { get; set; }

        public virtual string Port { get; set; }

        public virtual string InfusionSystem { get; set; }

        public virtual float? TargetAUC { get; set; }

        public virtual float? SCreatinin { get; set; }

        public virtual string Annotation { get; set; }

        public virtual string Source { get; set; }

        public virtual DateTime? SubmitDate { get; set; }

        public virtual DateTime? UpdateDate { get; set; }

        public virtual string PdfExportFileName { get; set; }

        #endregion
    }
}