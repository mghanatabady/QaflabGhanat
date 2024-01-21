using Abp.MultiTenancy;
using QaflabGhanat.Authorization.Users;

namespace QaflabGhanat.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
