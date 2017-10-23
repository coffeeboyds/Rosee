using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using Rosee.Core.ViewModels;

namespace Rosee.Droid.Activities
{
    [Activity(Label = "MapActivity")]
    public class MapActivity : MvxActivity<MapViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.map_screen);
        }
    }
}