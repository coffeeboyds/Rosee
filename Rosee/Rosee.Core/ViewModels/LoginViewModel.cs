using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace Rosee.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public LoginViewModel(IMvxNavigationService navigation)
        {
            _navigationService = navigation;
        }

        MvxCommand _facebookLoginButtonClickedCommand;
        public IMvxCommand FacebookLoginButtonClickedCommand
        {
            get { return _facebookLoginButtonClickedCommand ?? (_facebookLoginButtonClickedCommand = new MvxCommand(OnFacebookLoginButtonClicked)); }
        }

        private void OnFacebookLoginButtonClicked()
        {
            _navigationService.Navigate<MapViewModel>();
        }
    }
}
