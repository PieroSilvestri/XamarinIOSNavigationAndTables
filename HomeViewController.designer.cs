// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinIOSNavigationAndTables
{
    [Register ("HomeViewController")]
    partial class HomeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TableButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableButton != null) {
                TableButton.Dispose ();
                TableButton = null;
            }
        }
    }
}