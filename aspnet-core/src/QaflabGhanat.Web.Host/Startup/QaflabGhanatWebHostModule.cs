using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QaflabGhanat.Configuration;

namespace QaflabGhanat.Web.Host.Startup
{
    [DependsOn(
       typeof(QaflabGhanatWebCoreModule))]
    public class QaflabGhanatWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public QaflabGhanatWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QaflabGhanatWebHostModule).GetAssembly());
        }
    }
}
