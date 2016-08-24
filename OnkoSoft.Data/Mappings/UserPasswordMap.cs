using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class UserPasswordMap : ClassMap<UserPassword>
    {
        public UserPasswordMap()
        {
            Table("ApplicationUserPassword");

            Id(x => x.Id);
            References(x => x.User)
                .Column("UserId").Not.Nullable();
            Map(x => x.SortOrder).Not.Nullable();
            Map(x => x.PasswordHash).Not.Nullable().Length(1024);
        }
    }
}