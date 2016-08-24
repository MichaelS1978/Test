using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("ApplicationUser");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.IsArchived).Not.Nullable();
            Map(x => x.Name).Not.Nullable().Unique();
            Map(x => x.LastPasswordChange).Not.Nullable();
            Map(x => x.Role);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.DateCreated).Not.Nullable();
            Map(x => x.LastLogin);
            Map(x => x.DefaultDoctorId);

            HasMany<UserPassword>(x => x.PasswordList)
                .Inverse()
                .KeyColumn("UserId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("User_Password");
        }
    }
}