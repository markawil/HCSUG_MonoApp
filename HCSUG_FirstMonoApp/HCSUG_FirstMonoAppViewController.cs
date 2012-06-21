using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HCSUG_FirstMonoApp
{
	public partial class HCSUG_FirstMonoAppViewController : UIViewController
	{
		public HCSUG_FirstMonoAppViewController () : base ("HCSUG_FirstMonoAppViewController", null)
		{
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
			btnClickMe.TouchUpInside += (sender, e) => {

				labelOnForm.Text = "Button was clicked!";
			};
			// Perform any additional setup after loading the view, typically from a nib.


			var twitterRepo = new TwitterTrendsRepository ();
			var trends = twitterRepo.GetTwitterTrends ();
			this.tabelView = new UITableView (View.Bounds);
			this.tabelView.Source = new TableSource (trends, this);
			Add (tabelView);
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
	}
}

