using FluentNHibernate.Mapping;
using Microsoft.AspNet.Identity;

namespace NHibernateAspNetIdentityExample.Models.Identity
{
    public class User : IUser<int>
    {
        public virtual int Id { get; protected set; }
        public virtual string UserName { get; set; }
        public virtual string PasswordHash { get; set; }

        public class Map : ClassMap<User>
        {
            public Map()
            {
                Id(x => x.Id).GeneratedBy.Identity();
                Map(x => x.UserName).Not.Nullable();
                Map(x => x.PasswordHash).Not.Nullable();
            }
        }
    }
}