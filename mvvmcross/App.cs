using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using RestaurantBilling.Core.Services;

namespace RestaurantBilling.Core
{
    /// <summary>
    /// Main App class inherits from MvxApplication
    /// - Registers the interfaces and implementations the app uses.
    /// - Registers which ViewModel the App will show when it starts.
    /// - Controls how ViewModels are locate, most solutions will use default implementation supplied by MvxApplication.
    /// </summary>
    public class App : MvxApplication
    {

        /// <summary>
        /// Setup IoC registrations.
        /// </summary>
        public App()
        {
			// Registers the interfaces and implementations the app uses.
			Mvx.RegisterType<IBillCalculator, BillCalculator>();
			// Whenever Mvx.Resolve is used, a new instance of Calculation is provided. Not needed here.
			// var calcExample = Mvx.Resolve<IBillCalculator>();

			// Tells the MvvmCross framework that whenever any code requests an IMvxAppStart reference,
			// the framework should return that same appStart instance.
			var appStart = new CustomAppStart();
            Mvx.RegisterSingleton<IMvxAppStart>(appStart);

            // or, if no custom app start is required, we can 
            // utilize a default App Start object with 
            // var appStart = new MvxAppStart<TipViewModel>();
        }

        public override void Initialize()
        {
            base.Initialize();
        }

    }
}
