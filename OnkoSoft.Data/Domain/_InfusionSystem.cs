namespace OnkoSoft.Data.Domain
{
    //TODO: IntMM - evtl. obsolet
    public class InfusionSystem : SimpleOnkoSoftBase
    {
        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            InfusionSystem copy = new InfusionSystem();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}