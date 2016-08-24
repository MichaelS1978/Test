namespace OnkoSoft.Data.Domain
{
    public class SystemSetting : OnkoSoftBase
    {
        public virtual string Name { get; set; }

        public virtual string Value { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as SystemSetting).Name = Name;
            (copy as SystemSetting).Value = Value;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            SystemSetting copy = new SystemSetting();
            CopyTo(copy, copyIdentity);

            return copy;
        }

    }
}