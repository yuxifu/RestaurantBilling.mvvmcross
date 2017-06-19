using System;

using Foundation;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using RestaurantBilling.Core.Models;

namespace RestaurantBilling.UI.iOS.Views
{
	public partial class BillCell : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString(nameof(BillCell));
		public static readonly UINib Nib;

		static BillCell()
		{
			Nib = UINib.FromName("BillCell", NSBundle.MainBundle);
		}

		protected BillCell(IntPtr handle) : base(handle)
		{
			this.DelayBind(() =>
			{
				this.CreateBinding(VCCustomerEmail).To((Bill vm) => vm.CustomerEmail).Apply();
				this.CreateBinding(VCSubTotal).To((Bill vm) => vm.SubTotal).Apply();
				this.CreateBinding(VCTip).To((Bill vm) => vm.Tip).Apply();
				this.CreateBinding(VCTotal).To((Bill vm) => vm.AmountPaid).Apply();
			});
		}
	}
}