using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QaflabGhanat.Configuration;
using QaflabGhanat.EntityFrameworkCore;
using QaflabGhanat.Migrator.DependencyInjection;

namespace QaflabGhanat.Migrator
{
    [DependsOn(typeof(QaflabGhanatEntityFrameworkModule))]
    public class QaflabGhanatMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public QaflabGhanatMigratorModule(QaflabGhanatEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(QaflabGhanatMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                QaflabGhanatConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QaflabGhanatMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
