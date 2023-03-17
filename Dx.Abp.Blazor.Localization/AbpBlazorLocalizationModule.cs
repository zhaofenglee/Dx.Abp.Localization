using DevExpress.Blazor.Localization;
using Dx.Abp.Blazor.Localization.Localization;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Localization;
using Volo.Abp.Localization.Resources.AbpLocalization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Dx.Abp.Blazor.Localization
{
    [DependsOn(
    typeof(AbpLocalizationModule)
    )]
    public class AbpBlazorLocalizationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpBlazorLocalizationModule>();
            });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                .Add<DxBlazorResource>("en")
                     .AddVirtualJson("/Localization/DxBlazor");
            });
            context.Services.AddSingleton(typeof(IDxLocalizationService), typeof(LocalizationService));
            context.Services.AddDevExpressBlazor();
        }
    }
}