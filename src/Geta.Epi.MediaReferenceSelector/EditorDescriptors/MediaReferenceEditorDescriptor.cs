using EPiServer.Core;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using EPiServer.Web;

namespace Geta.Epi.MediaReferenceSelector.EditorDescriptors
{
	[EditorDescriptorRegistration(TargetType = typeof(ContentReference), EditorDescriptorBehavior = EditorDescriptorBehavior.OverrideDefault, UIHint = UIHint.MediaFile)]
	public  class MediaReferenceEditorDescriptor: MediaReferenceEditorDescriptorBase<IContentMedia>
	{
	}
}



