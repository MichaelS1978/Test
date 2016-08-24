namespace OnkoSoft.Data.Domain
{
    //TODO: IntMM - evtl. obsolet
    public class Station : SimpleOnkoSoftBase
    {
        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Station copy = new Station();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}