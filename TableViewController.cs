using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace XamarinIOSNavigationAndTables
{
	public partial class TableViewController : UITableViewController
	{
		public TableViewController(IntPtr handle) : base(handle)
		{
		}


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			Person p1 = new Person("Piero", "Silvestri", 24);
			Person p2 = new Person("Andrea", "Scocchi", 22);
			Person p3 = new Person("Alessio", "Raggioli", 22);

			Person[] tableItems = new Person[] { p1, p2, p3 };

			var datasource = new TableSource(tableItems, this);

			TableView.Source = datasource;

		}
		//ViewControllerSegue2




		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			if (segue.Identifier == "DetailViewControllerSegue")
			{
				var detailViewController = segue.DestinationViewController as DetailViewController;
				if (detailViewController != null)
				{
					var source = TableView.Source as TableSource;
					var rowPath = TableView.IndexPathForSelectedRow;
					var item = source.GetItem(rowPath.Row);
					detailViewController.SelectedElement = item;
				}


			}
		}
	}
}