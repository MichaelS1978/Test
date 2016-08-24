namespace OnkoSoft.Data.Domain.DynamicEnumerations
{
    public class Gateway : DynamicEnumBase
    {
        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Gateway copy = new Gateway();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}
