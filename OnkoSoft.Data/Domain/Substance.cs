namespace OnkoSoft.Data.Domain
{
    public class Substance : OnkoSoftBase
    {
        public virtual string Name { get; set; }
        public virtual string SubstanceGroup { get; set; }
        public virtual bool IsConcurrentMedication { get; set; }
        public virtual string OdsSubstanceCode { get; set; }



        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as Substance).Name = Name;
            (copy as Substance).SubstanceGroup = SubstanceGroup;
            (copy as Substance).IsConcurrentMedication = IsConcurrentMedication;
            (copy as Substance).OdsSubstanceCode = OdsSubstanceCode;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Substance copy = new Substance();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}