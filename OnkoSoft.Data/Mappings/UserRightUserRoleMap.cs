using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    public class UserRightUserRoleMap : ClassMap<UserRightUserRole>
    {
        public UserRightUserRoleMap()
        {
            Table("ApplicationUserRightUserRole");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            References(x => x.UserRight)
                .Column("UserRightId").Not.Nullable()
                .UniqueKey("UK_UserRight_UserRole");
            Map(x => x.Role).Not.Nullable().UniqueKey("UK_UserRight_UserRole");
        }
    }
}