using System;
using MonoTouch.UIKit;

namespace HCSUG_FirstMonoApp
{
	public class TableSource : UITableViewSource
	{
		string[] _items;
		public TableSource (string[] items)
		{
			_items = items;
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

			cell.TextLabel.Text = _items [indexPath.Row];
			return cell;
		}
	}
}

