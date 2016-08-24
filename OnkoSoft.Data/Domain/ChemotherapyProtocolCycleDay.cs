using System.Collections.Generic;
using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain
{
    public class ChemotherapyProtocolCycleDay : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual ChemotherapyProtocolCycle ChemotherapyProtocolCycle { get; set; }
        public virtual int TherapyDay { get; set; }

        public virtual IList<ChemotherapyProtocolCycleDayMedication> Medications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChemotherapyProtocolCycleDay()
        {
            Medications = new List<ChemotherapyProtocolCycleDayMedication>();
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as ChemotherapyProtocolCycleDay).ChemotherapyProtocolCycle = ChemotherapyProtocolCycle;
            (copy as ChemotherapyProtocolCycleDay).TherapyDay = TherapyDay;

            (copy as ChemotherapyProtocolCycleDay).Medications.Clear();

            foreach (ChemotherapyProtocolCycleDayMedication cpcdMed in Medications)
            {
                ChemotherapyProtocolCycleDayMedication newCpcdMed = cpcdMed.Copy(copyIdentity) as ChemotherapyProtocolCycleDayMedication;
                newCpcdMed.ChemotherapyProtocolCycleDay = (copy as ChemotherapyProtocolCycleDay);
                (copy as ChemotherapyProtocolCycleDay).Medications.Add(newCpcdMed);
            }
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            ChemotherapyProtocolCycleDay copy = new ChemotherapyProtocolCycleDay();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}