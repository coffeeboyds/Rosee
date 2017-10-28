using MvvmCross.Plugins.Messenger;

namespace Rosee.Core.Messages
{
    public class LocationMessage : MvxMessage
    {
        public LocationMessage(object sender, double latitude, double longitude) : base(sender)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
    }
}
