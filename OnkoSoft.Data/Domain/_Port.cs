namespace OnkoSoft.Data.Domain
{
    //TODO: IntMM - evtl. obsolet
    public class Port : SimpleOnkoSoftBase
    {
        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Port copy = new Port();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}