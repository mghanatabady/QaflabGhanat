using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace QaflabGhanat.Localization
{
    public static class QaflabGhanatLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(QaflabGhanatConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(QaflabGhanatLocalizationConfigurer).GetAssembly(),
                        "QaflabGhanat.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
