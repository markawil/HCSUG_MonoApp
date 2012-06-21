using System;
using MonoTouch.UIKit;

namespace HCSUG_FirstMonoApp
{
	public class TableSource : UITableViewSource
	{
		Trend[] _items;
		HCSUG_FirstMonoAppViewController _vc;

		public TableSource (Trend[] items, HCSUG_FirstMonoAppViewController vc)
		{
			_items = items;
			_vc = vc;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return _items.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			string cellId = "cell";
			UITableViewCell cell = tableView.DequeueReusableCell (cellId);

			if (cell == null) {

				cell = new UITableViewCell (UITableViewCellStyle.Default, cellId);
			}

			cell.TextLabel.Text = _items [indexPath.Row].Name;
			return cell;
		}

		public override void RowSelected (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			var urlOfTrend = _items [indexPath.Row].Url;
			var webVC = new WebViewController (urlOfTrend);
			_vc.PresentModalViewController (webVC, true);
		}
	}
}

