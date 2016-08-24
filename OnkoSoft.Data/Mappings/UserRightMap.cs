using FluentNHibernate.Mapping;
using OnkoSoft.Data.Domain;

namespace OnkoSoft.Data.Mappings
{
    internal class UserRightMap : ClassMap<UserRight>
    {
        public UserRightMap()
        {
            Table("ApplicationUserRight");
            Map(x => x.DateLastChange).Not.Nullable();
            Map(x => x.UserLastChange).Not.Nullable();

            Id(x => x.Id);
            Map(x => x.ApplicationFunction).Not.Nullable();

            HasMany<UserRightUserRole>(x => x.UserRightUserRoleList)
                .Inverse()
                .KeyColumn("UserRightId")
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("UserRight_UserRole")
                .Not.LazyLoad();
        }
    }
}