namespace OnkoSoft.Data.Domain.DynamicEnumerations
{
    public abstract class DynamicEnumBase : OnkoSoftBase
    {
        public virtual string Name { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as DynamicEnumBase).Name = Name;
        }
    }
}