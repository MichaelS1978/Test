namespace OnkoSoft.Data.Domain
{
    //TODO: IntMM - evtl. obsolet
    public class TherapyTarget : SimpleOnkoSoftBase
    {
        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            TherapyTarget copy = new TherapyTarget();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}