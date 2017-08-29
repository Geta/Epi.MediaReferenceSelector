using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Framework.Localization;
using EPiServer.Framework.Localization.XmlResources;
using EPiServer.ServiceLocation;
using System.Reflection;

namespace Geta.Epi.MediaReferenceSelector
{
    [ModuleDependency(typeof(ServiceContainerInitialization))]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    [InitializableModule]
    public class MediaReferenceSelectorInitialization : IInitializableModule
    {
        private const string LocalizationProviderName = "Geta.Epi.MediaReferenceSelector.EmbeddedLangFiles";

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }


        private static void AddLocalizationProvider(LocalizationService localizationService, ILanguageBranchRepository languageBranchRepository, IContentLanguageSettingsHandler contentLanguageSettingsHandler, IContentLoader contentLoader)
        {
            var providerBasedLocalizationService = localizationService as ProviderBasedLocalizationService;

            if (providerBasedLocalizationService == null)
            {
                return;
            }

            var localizationProviderInitializer = new EmbeddedXmlLocalizationProviderInitializer();
            XmlLocalizationProvider localizationProvider = localizationProviderInitializer.GetInitializedProvider(LocalizationProviderName, Assembly.GetExecutingAssembly());

            //Inserts the provider first in the provider list so that it is prioritized over default providers.
            providerBasedLocalizationService.Providers.Insert(0, localizationProvider);
        }
    }
}