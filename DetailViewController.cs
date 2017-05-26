using Foundation;
using System;
using UIKit;

namespace XamarinIOSNavigationAndTables
{
    public partial class DetailViewController : UIViewController
    {
        public DetailViewController (IntPtr handle) : base (handle)
        {
        }

		public Person SelectedElement { get; set; }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			NameLabel.Text = SelectedElement.name;
			SurnameLabel.Text = SelectedElement.surname;
			AgeLabel.Text = SelectedElement.age.ToString();
		}
	}
}