using System;
using System.Collections.Generic;
using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class Patient : OnkoSoftBase
    {
        public virtual bool IsArchived { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime Birthday { get; set; }
        public virtual string Title { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual string RegistrationId { get; set; }
        public virtual string Street { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual string City { get; set; }
        public virtual string Phone { get; set; }
        public virtual bool IsFileClosed { get; set; }
        public virtual bool IsFreeOfCharge { get; set; }
        public virtual DateTime? FreeOfChargeDate { get; set; }
        public virtual int? HealthInsuranceInstitutionNumber { get; set; }
        public virtual string HealthInsuranceName { get; set; }
        public virtual int? HealthInsuranceNumber { get; set; }
        public virtual HealthInsuranceKind InsuranceKind { get; set; }
        public virtual string InsuranceNumber { get; set; }
        public virtual int? ExternalId { get; set; }


        public virtual IList<Chemotherapy> Chemotherapys { get; set; }

        public virtual IList<AppliedMedicine> AppliedMedicines { get; set; }
        public virtual IList<Prescription> Prescriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Chemotherapys = new List<Chemotherapy>();
            AppliedMedicines = new List<AppliedMedicine>();
            Prescriptions = new List<Prescription>();
        }

        public virtual string FullName
        {
            get
            {
                return string.Format("{0}, {1}", LastName, FirstName);
            }
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as Patient).IsArchived = IsArchived;
            (copy as Patient).FirstName = FirstName;
            (copy as Patient).LastName = LastName;
            (copy as Patient).Birthday = Birthday;
            (copy as Patient).Title = Title;
            (copy as Patient).Gender = Gender;
            (copy as Patient).RegistrationId = RegistrationId;
            (copy as Patient).Street = Street;
            (copy as Patient).ZipCode = ZipCode;
            (copy as Patient).City = City;
            (copy as Patient).Phone = Phone;
            (copy as Patient).IsFileClosed = IsFileClosed;
            (copy as Patient).IsFreeOfCharge = IsFreeOfCharge;
            (copy as Patient).FreeOfChargeDate = FreeOfChargeDate;
            (copy as Patient).HealthInsuranceInstitutionNumber = HealthInsuranceInstitutionNumber;
            (copy as Patient).HealthInsuranceName = HealthInsuranceName;
            (copy as Patient).HealthInsuranceNumber = HealthInsuranceNumber;
            (copy as Patient).InsuranceKind = InsuranceKind;
            (copy as Patient).InsuranceNumber = InsuranceNumber;
            (copy as Patient).ExternalId = ExternalId;

            (copy as Patient).Chemotherapys.Clear();

            foreach (Chemotherapy chemo in Chemotherapys)
            {
                Chemotherapy newChemo = chemo.Copy(copyIdentity) as Chemotherapy;
                newChemo.Patient = (copy as Patient);
                (copy as Patient).Chemotherapys.Add(newChemo);
            }

            (copy as Patient).AppliedMedicines.Clear();

            foreach (AppliedMedicine appMed in AppliedMedicines)
            {
                AppliedMedicine newAppMed = appMed.Copy(copyIdentity) as AppliedMedicine;
                newAppMed.Patient = (copy as Patient);
                (copy as Patient).AppliedMedicines.Add(newAppMed);
            }

            (copy as Patient).Prescriptions.Clear();

            foreach (Prescription prescr in Prescriptions)
            {
                Prescription newPrescr = prescr.Copy(copyIdentity) as Prescription;
                newPrescr.Patient = (copy as Patient);
                (copy as Patient).Prescriptions.Add(newPrescr);
            }
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Patient copy = new Patient();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}