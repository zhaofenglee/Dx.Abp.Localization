using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DevExpress_Blazor;

[Dependency(ReplaceServices = true)]
public class DevExpress_BlazorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DevExpress_Blazor";
}
