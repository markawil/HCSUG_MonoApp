
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HCSUG_FirstMonoApp
{
	public partial class WebViewController : UIViewController
	{
		string _urlAddress;

		public WebViewController (string urlAddress) : base ("WebViewController", null)
		{
			_urlAddress = urlAddress;
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			NSUrl url = new NSUrl (_urlAddress);
			NSUrlRequest request = new NSUrlRequest (url);
			this.webView.LoadRequest (request);
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		partial void doneClicked (MonoTouch.Foundation.NSObject sender)
		{
			this.DismissModalViewControllerAnimated (true);
		}
	}
}

