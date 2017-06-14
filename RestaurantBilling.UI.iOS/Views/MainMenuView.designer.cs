// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RestaurantBilling.UI.iOS.Views
{
    [Register ("MainMenuView")]
    partial class MainMenuView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCCreateBill { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCCreateBill != null) {
                VCCreateBill.Dispose ();
                VCCreateBill = null;
            }
        }
    }
}