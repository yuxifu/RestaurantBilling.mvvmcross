using System;
using mvvmcross.Services;

namespace RestaurantBilling.UI.iOS
{
	public class Platform : IPlatform
	{
		public string OSName { get => "iOS"; set => OSName = value; }
		public double ScreenWidth { get => 456; set => ScreenWidth = value; }
		public double ScreenHeight { get => 456; set => ScreenHeight = value; }
	}
}
