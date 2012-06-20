// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace HCSUG_FirstMonoApp
{
	[Register ("HCSUG_FirstMonoAppViewController")]
	partial class HCSUG_FirstMonoAppViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnClickMe { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView tabelView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelOnForm { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnClickMe != null) {
				btnClickMe.Dispose ();
				btnClickMe = null;
			}

			if (tabelView != null) {
				tabelView.Dispose ();
				tabelView = null;
			}

			if (labelOnForm != null) {
				labelOnForm.Dispose ();
				labelOnForm = null;
			}
		}
	}
}
