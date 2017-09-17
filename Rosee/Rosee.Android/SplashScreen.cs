using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Rosee.Droid
{
    [Activity(
        Label = "Rosee"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/AppTheme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.splash_screen)
        {
        }
    }
}