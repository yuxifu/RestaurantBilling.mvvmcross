using System;
using mvvmcross.Services;

namespace RestaurantBilling.UI.Droid
{
    public class Platform : IPlatform
    {
        public string OSName { get => "Android"; set => OSName = value; }
        public double ScreenWidth { get => 123; set => ScreenWidth = value; }
        public double ScreenHeight { get => 123; set => ScreenHeight = value; }
    }
}
