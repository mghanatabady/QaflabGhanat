using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QaflabGhanat.EntityFrameworkCore;
using QaflabGhanat.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace QaflabGhanat.Web.Tests
{
    [DependsOn(
        typeof(QaflabGhanatWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class QaflabGhanatWebTestModule : AbpModule
    {
        public QaflabGhanatWebTestModule(QaflabGhanatEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QaflabGhanatWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(QaflabGhanatWebMvcModule).Assembly);
        }
    }
}