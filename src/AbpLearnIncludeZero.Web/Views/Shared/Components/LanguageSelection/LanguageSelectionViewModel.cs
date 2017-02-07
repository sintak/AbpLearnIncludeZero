﻿using System.Collections.Generic;
using Abp.Localization;

namespace AbpLearnIncludeZero.Web.Views.Shared.Components.LanguageSelection
{
    public class LanguageSelectionViewModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public IReadOnlyList<LanguageInfo> Languages { get; set; }
    }
}