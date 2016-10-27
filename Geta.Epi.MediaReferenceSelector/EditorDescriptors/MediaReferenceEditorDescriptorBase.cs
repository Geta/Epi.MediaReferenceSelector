using EPiServer.Cms.Shell.UI.UIDescriptors;
using EPiServer.Core;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace Geta.Epi.MediaReferenceSelector.EditorDescriptors
{
	public abstract class MediaReferenceEditorDescriptorBase<T> : ContentReferenceEditorDescriptor<T> where T: IContentData
	{
		protected MediaReferenceEditorDescriptorBase()
		{
			this.ClientEditingClass = "geta-epi-mediareferenceselector/MediaSelector";
		}

		public override string RepositoryKey { get { return MediaRepositoryDescriptor.RepositoryKey; } }
	}
}