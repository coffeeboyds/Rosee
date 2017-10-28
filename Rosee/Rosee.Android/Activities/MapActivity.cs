using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;
using MvvmCross.Plugins.Location;
using Rosee.Core.ViewModels;

namespace Rosee.Droid.Activities
{
    [Activity(Label = "MapActivity")]
    public class MapActivity : MvxActivity<MapViewModel>, IOnMapReadyCallback
    {
        private IMvxLocationWatcher _locationWatcher;
        private MvxGeoLocation _currentLocation;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.map_screen);

            _locationWatcher = Mvx.Resolve<IMvxLocationWatcher>();
            var options = new MvxLocationOptions();
            _locationWatcher.Start(options, OnLocationFound, OnLocationNotFound);
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            googleMap.MapType = GoogleMap.MapTypeNormal;
            
            LatLng location = new LatLng(_currentLocation.Coordinates.Latitude, _currentLocation.Coordinates.Longitude);
            CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
            builder.Target(location);
            builder.Zoom(18);
            CameraPosition cameraPosition = builder.Build();
            CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);

            googleMap.MoveCamera(cameraUpdate);
        }

        private void OnLocationFound(MvxGeoLocation location)
        {
            _locationWatcher.Stop();
            _currentLocation = location;
            MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map_screen);
            mapFrag.GetMapAsync(this);
        }

        private void OnLocationNotFound(MvxLocationError error)
        {
            
        }
    }
}