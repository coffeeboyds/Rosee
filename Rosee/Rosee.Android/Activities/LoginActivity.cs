using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Rosee.Droid.Activities
{
    [Activity(
        Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop,
        ScreenOrientation = ScreenOrientation.Portrait
        )]
    public class LoginActivity : MvxActivity
    {
        public LoginActivity()
        {
            
        }
    }
}