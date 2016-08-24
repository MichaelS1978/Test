namespace OnkoSoft.Data.Domain
{
    public class Preparation : OnkoSoftBase
    {
        public virtual string Name { get; set; }


        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as Preparation).Name = Name;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Preparation copy = new Preparation();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}