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
    [Register ("BillView")]
    partial class BillView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider VCGratuity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCSubTotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCTip { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCTotal { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCEmail != null) {
                VCEmail.Dispose ();
                VCEmail = null;
            }

            if (VCGratuity != null) {
                VCGratuity.Dispose ();
                VCGratuity = null;
            }

            if (VCSubTotal != null) {
                VCSubTotal.Dispose ();
                VCSubTotal = null;
            }

            if (VCTip != null) {
                VCTip.Dispose ();
                VCTip = null;
            }

            if (VCTotal != null) {
                VCTotal.Dispose ();
                VCTotal = null;
            }
        }
    }
}