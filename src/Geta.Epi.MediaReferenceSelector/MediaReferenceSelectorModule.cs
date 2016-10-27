using System.Web.Hosting;
using EPiServer.Framework.TypeScanner;
using EPiServer.Shell.Modules;

namespace Geta.Epi.MediaReferenceSelector
{
    public class MediaReferenceSelectorModule : ShellModule
    {
        public MediaReferenceSelectorModule(string name, string routeBasePath, string resourceBasePath) : base(name, routeBasePath, resourceBasePath)
        {
        }

        public MediaReferenceSelectorModule(string name, string routeBasePath, string resourceBasePath, ITypeScannerLookup typeScannerLookup, VirtualPathProvider virtualPathProvider) : base(name, routeBasePath, resourceBasePath, typeScannerLookup, virtualPathProvider)
        {
        }
    }
}