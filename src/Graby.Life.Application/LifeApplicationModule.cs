using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Graby.Life.Authorization;

namespace Graby.Life
{
    [DependsOn(
        typeof(LifeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LifeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LifeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LifeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
