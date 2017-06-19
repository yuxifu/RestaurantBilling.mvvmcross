using UIKit;
using Foundation;
using MvvmCross.iOS.Views;
using RestaurantBilling.Core.ViewModels;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace RestaurantBilling.UI.iOS.Views
{
	[Register(nameof(AllBillsView))]
	public class AllBillsView : MvxViewController<AllBillsViewModel>
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var tableView = new UITableView(UIScreen.MainScreen.Bounds, UITableViewStyle.Plain);
			tableView.RowHeight = 150;
			Add(tableView);

			var source = new MvxSimpleTableViewSource(tableView, BillCell.Key, BillCell.Key);
			tableView.Source = source;

			this.CreateBinding(source).To((AllBillsViewModel vm) => vm.AllBills).Apply();
			tableView.ReloadData();
		}
	}
}