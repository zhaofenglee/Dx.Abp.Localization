using DevExpress.Blazor.Localization;
using Dx.Abp.Blazor.Localization.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dx.Abp.Blazor.Localization
{
    public class LocalizationService : DxLocalizationService, IDxLocalizationService
    {
        private readonly IStringLocalizer<DxBlazorResource> _localizer;

        public LocalizationService(IStringLocalizer<DxBlazorResource> localizer)
        {
            _localizer = localizer;
        }
        string? IDxLocalizationService.GetString(string key)
        {
            return CultureInfo.CurrentUICulture.Name == "zh-Hans" ?
                _localizer[key] :
                base.GetString(key);
        }
    }
}
