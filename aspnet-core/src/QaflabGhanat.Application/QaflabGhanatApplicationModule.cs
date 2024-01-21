using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QaflabGhanat.Authorization;

namespace QaflabGhanat
{
    [DependsOn(
        typeof(QaflabGhanatCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class QaflabGhanatApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<QaflabGhanatAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(QaflabGhanatApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
