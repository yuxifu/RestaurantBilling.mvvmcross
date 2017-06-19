using System;

using UIKit;

using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using RestaurantBilling.Core.ViewModels;

namespace RestaurantBilling.UI.iOS.Views
{
    public partial class MainMenuView : MvxViewController<MainMenuViewModel>
    {
        public MainMenuView() : base("MainMenuView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            // This establishes the same sort of data binding in code as what we did in Android's axml.
            // It means: Bind the TipLabel's default binding property (Text in this case) to the ViewModel's Tip property.
            // 2-way binding by default.
            this.CreateBinding(VCCreateBill).To((MainMenuViewModel vm) => vm.NavigateCreateBill).Apply();
            this.CreateBinding(VCViewBills).To((MainMenuViewModel vm) => vm.NavigateAllBills).Apply();
            this.CreateBinding(VCPlatform).To((MainMenuViewModel vm) => vm.OSName).Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

