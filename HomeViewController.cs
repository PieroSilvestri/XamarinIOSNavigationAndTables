using Foundation;
using System;
using UIKit;
using System.Diagnostics;

namespace XamarinIOSNavigationAndTables
{
    public partial class HomeViewController : UIViewController
    {
        public HomeViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Title = "Home";

			TableButton.TouchUpInside += GoToTablePage;
		}

		private void GoToTablePage(object sender, EventArgs e)
		{
			Debug.WriteLine("GoToTablePage");
		}
    }
}