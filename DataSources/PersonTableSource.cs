using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace XamarinIOSNavigationAndTables
{
	public class TableSource : UITableViewSource
	{

		protected Person[] tableItems;
		protected string cellIdentifier = "TableCell";
		TableViewController tableViewController;

		public TableSource(Person[] items, TableViewController owner)
		{
			tableItems = items;
			this.tableViewController = owner;

		}

		/// <summary>
		/// Called by the TableView to determine how many sections(groups) there are.
		/// </summary>
		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		/// <summary>
		/// Called by the TableView to determine how many cells to create for that particular section.
		/// </summary>
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		/// <summary>
		/// Called when a row is touched
		/// </summary>
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			//var selectedElement = tableItems[indexPath.Row];
			//tableViewController.ElementSelected();
			tableView.DeselectRow(indexPath, true);
		}

		/// <summary>
		/// Called by the TableView to get the actual UITableViewCell to render for the particular row
		/// </summary>
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			Person item = tableItems[indexPath.Row];

			//---- if there are no cells to reuse, create a new one
			if (cell == null)
			{ 
				cell = new UITableViewCell(UITableViewCellStyle.Value1, cellIdentifier); 
			}

			cell.TextLabel.Text = item.name;
			//cell.DetailTextLabel.Text = item.surname;

			return cell;
		}

		public Person GetItem(int id)
		{
			return tableItems[id];
		}
	}
}
