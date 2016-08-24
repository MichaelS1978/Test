namespace OnkoSoft.Data.Domain
{
    public class SubstancePreparation : OnkoSoftBase
    {
        public virtual string SubstanceName  { get; set; }
        public virtual string PreparationName { get; set; }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as SubstancePreparation).SubstanceName = SubstanceName;
            (copy as SubstancePreparation).PreparationName = PreparationName;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            SubstancePreparation copy = new SubstancePreparation();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}