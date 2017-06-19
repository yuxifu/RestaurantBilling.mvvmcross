// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RestaurantBilling.UI.iOS.Views
{
    [Register ("BillCell")]
    partial class BillCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCCustomerEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCSubTotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCTip { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCTotal { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCCustomerEmail != null) {
                VCCustomerEmail.Dispose ();
                VCCustomerEmail = null;
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