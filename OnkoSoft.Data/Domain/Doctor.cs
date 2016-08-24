namespace OnkoSoft.Data.Domain
{
    public class Doctor : OnkoSoftBase
    {
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Title { get; set; }
        public virtual string KbvNumber { get; set; }



        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as Doctor).LastName = LastName;
            (copy as Doctor).FirstName = FirstName;
            (copy as Doctor).Title = Title;
            (copy as Doctor).KbvNumber = KbvNumber;
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            Doctor copy = new Doctor();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}