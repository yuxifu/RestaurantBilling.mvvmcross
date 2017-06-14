using Android.App;
using Android.OS;

namespace RestaurantBilling.UI.Droid
{
    [Activity(Label = "RestaurantBilling.UI.Droid", MainLauncher = false)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

