using System;
using System.Collections.Generic;
using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain
{
    public class Prescription : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual Patient Patient { get; set; }
        public virtual bool IsArchived { get; set; }
        public virtual int? DoctorId { get; set; }
        public virtual int? ChemotherapyId { get; set; }
        public virtual int? ChemotherapyCycle { get; set; }
        public virtual int? ChemotherapyCycleDay { get; set; }
        public virtual bool IsFreeOfCharge { get; set; }
        public virtual DateTime IssueDate { get; set; }
        public virtual DateTime? PrintDate { get; set; }
        public virtual int? HealthInsuranceInstitutionNumber { get; set; }
        public virtual string HealthInsuranceName { get; set; }
        public virtual int? HealthInsuranceNumber { get; set; }
        public virtual int? HealthInsuranceCostUnitGroup { get; set; }
        public virtual string InsuranceNumber { get; set; }

        public virtual IList<PrescriptionEntry> Entries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prescription()
        {
            Entries = new List<PrescriptionEntry>();
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as Prescription).Patient = Patient;
            (copy as Prescription).IsArchived = IsArchived;
            (copy as Prescription).DoctorId = DoctorId;
            (copy as Prescription).IsArchived = IsArchived;
            (copy as Prescription).ChemotherapyId = ChemotherapyId;
            (copy as Prescription).ChemotherapyCycle = ChemotherapyCycle;
            (copy as Prescription).ChemotherapyCycleDay = ChemotherapyCycleDay;
            (copy as Prescription).IsFreeOfCharge = IsFreeOfCharge;
            (copy as Prescription).IssueDate = IssueDate;
            (copy as Prescription).PrintDate = PrintDate;
            (copy as Prescription).HealthInsuranceInstitutionNumber = HealthInsuranceInstitutionNumber;
            (copy as Prescription).HealthInsuranceName = HealthInsuranceName;
            (copy as Prescription).HealthInsuranceNumber = HealthInsuranceNumber;
            (copy as Prescription).HealthInsuranceCostUnitGroup = HealthInsuranceCostUnitGroup;
            (copy as Prescription).InsuranceNumber = InsuranceNumber;

            (copy as Prescription).Entries.Clear();

            foreach (PrescriptionEntry entry in Entries)
            {
                PrescriptionEntry newEntry = entry.Copy(copyIdentity) as PrescriptionEntry;
                newEntry.Prescription = (copy as Prescription);
                (copy as Prescription).Entries.Add(newEntry);
            }

        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Prescription copy = new Prescription();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}

