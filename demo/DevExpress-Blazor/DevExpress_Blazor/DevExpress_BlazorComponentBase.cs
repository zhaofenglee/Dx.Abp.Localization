using DevExpress_Blazor.Localization;
using Volo.Abp.AspNetCore.Components;

namespace DevExpress_Blazor;

public abstract class DevExpress_BlazorComponentBase : AbpComponentBase
{
    protected DevExpress_BlazorComponentBase()
    {
        LocalizationResource = typeof(DevExpress_BlazorResource);
    }
}
