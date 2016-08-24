using System.Collections.Generic;
using OnkoSoft.Data.Attributes;

namespace OnkoSoft.Data.Domain
{
    public class ChemotherapyCycle : OnkoSoftBase
    {
        [IgnoreForDiff()]
        public virtual Chemotherapy Chemotherapy { get; set; }
        public virtual int Cycle { get; set; }
        public virtual string Annotation { get; set; }

        public virtual IList<ChemotherapyCycleDay> Days { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChemotherapyCycle()
        {
            Days = new List<ChemotherapyCycleDay>();
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as ChemotherapyCycle).Chemotherapy = Chemotherapy;
            (copy as ChemotherapyCycle).Cycle = Cycle;
            (copy as ChemotherapyCycle).Annotation = Annotation;

            (copy as ChemotherapyCycle).Days.Clear();

            foreach (ChemotherapyCycleDay cycleDay in Days)
            {
                ChemotherapyCycleDay newCycleDay = cycleDay.Copy(copyIdentity) as ChemotherapyCycleDay;
                newCycleDay.ChemotherapyCycle = (copy as ChemotherapyCycle);
                (copy as ChemotherapyCycle).Days.Add(newCycleDay);
            }
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            ChemotherapyCycle copy = new ChemotherapyCycle();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}