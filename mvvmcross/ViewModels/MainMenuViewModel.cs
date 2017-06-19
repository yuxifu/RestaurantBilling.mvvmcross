using mvvmcross.Services;
using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace RestaurantBilling.Core.ViewModels
{
    public class MainMenuViewModel : MvxViewModel
    {
        public ICommand NavigateCreateBill
        {
            get
            {
                // Navigation Note:
                // Must add following value to Assembly.cs for any Windows projects to see the lambda.
                // [assembly: InternalsVisibleTo("Cirrious.MvvmCross")]
                return new MvxCommand(() => ShowViewModel<BillViewModel>());
            }
        }

        public ICommand NavigateAllBills
        {
            get
            {
                // Navigation Note:
                // Must add following value to Assembly.cs for any Windows projects to see the lambda.
                // [assembly: InternalsVisibleTo("Cirrious.MvvmCross")]
                return new MvxCommand(() => ShowViewModel<AllBillsViewModel>());
            }
        }

        private IPlatform _platform;
        public MainMenuViewModel(IPlatform platform)
        {
            _platform = platform;
        }

		public string OSName
        {
            get { return _platform.OSName; }
            set
            {
                _platform.OSName = value;
                RaisePropertyChanged(() => OSName);
            }
        }

		public double ScreenWidth
		{
			get { return _platform.ScreenWidth; }
			set
			{
				_platform.ScreenWidth = value;
                RaisePropertyChanged(() => ScreenWidth);
			}
		}

		public double ScreenHeight
		{
			get { return _platform.ScreenHeight; }
			set
			{
				_platform.ScreenHeight = value;
                RaisePropertyChanged(() => ScreenHeight);
			}
		}


	}
}

