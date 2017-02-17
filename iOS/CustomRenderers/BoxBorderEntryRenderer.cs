using BoxEntry;
using BoxEntry.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BoxBorderEntry), typeof(BoxBorderEntryRenderer))]
namespace BoxEntry.iOS
{
	public class BoxBorderEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.TextColor = UIColor.Black;
				Control.Layer.BorderColor = UIColor.Black.CGColor;
				Control.Layer.BorderWidth = 3.0f;
			}
		}
	}
}
