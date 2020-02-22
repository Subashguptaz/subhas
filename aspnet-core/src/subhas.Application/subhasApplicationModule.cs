using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using subhas.Authorization;

namespace subhas
{
    [DependsOn(
        typeof(subhasCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class subhasApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<subhasAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(subhasApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
