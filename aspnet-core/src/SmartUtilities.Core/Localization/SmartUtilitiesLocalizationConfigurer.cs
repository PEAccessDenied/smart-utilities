using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SmartUtilities.Localization
{
    public static class SmartUtilitiesLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SmartUtilitiesConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SmartUtilitiesLocalizationConfigurer).GetAssembly(),
                        "SmartUtilities.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
