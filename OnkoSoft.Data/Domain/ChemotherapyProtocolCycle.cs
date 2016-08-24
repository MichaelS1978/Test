using System.Collections.Generic;
using OnkoSoft.Data.Attributes;
using OnkoSoft.Data.Domain.Enumerations;

namespace OnkoSoft.Data.Domain
{
    public class ChemotherapyProtocolCycle : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual ChemotherapyProtocol ChemotherapyProtocol { get; set; }
        public virtual int Cycle { get; set; }
        public virtual int Interval { get; set; }
        public virtual IntervalUnit IntervalUnit { get; set; }

        public virtual IList<ChemotherapyProtocolCycleDay> Days { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChemotherapyProtocolCycle()
        {
            Days = new List<ChemotherapyProtocolCycleDay>();
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as ChemotherapyProtocolCycle).ChemotherapyProtocol = ChemotherapyProtocol;
            (copy as ChemotherapyProtocolCycle).Cycle = Cycle;
            (copy as ChemotherapyProtocolCycle).Interval = Interval;
            (copy as ChemotherapyProtocolCycle).IntervalUnit = IntervalUnit;

            (copy as ChemotherapyProtocolCycle).Days.Clear();

            foreach (ChemotherapyProtocolCycleDay cpCycleDay in Days)
            {
                ChemotherapyProtocolCycleDay newCpCycleDay = cpCycleDay.Copy(copyIdentity) as ChemotherapyProtocolCycleDay;
                newCpCycleDay.ChemotherapyProtocolCycle = (copy as ChemotherapyProtocolCycle);
                (copy as ChemotherapyProtocolCycle).Days.Add(newCpCycleDay);
            }
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            ChemotherapyProtocolCycle copy = new ChemotherapyProtocolCycle();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}