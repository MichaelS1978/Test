namespace OnkoSoft.Data.Domain
{
    public abstract class SimpleOnkoSoftBase : OnkoSoftBase
    {
        public virtual string Name { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as SimpleOnkoSoftBase).Name = Name;
        }
    }
}