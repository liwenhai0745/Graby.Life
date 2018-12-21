using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Graby.Life.Configuration;

namespace Graby.Life.Web.Host.Startup
{
    [DependsOn(
       typeof(LifeWebCoreModule))]
    public class LifeWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LifeWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LifeWebHostModule).GetAssembly());
        }
    }
}
