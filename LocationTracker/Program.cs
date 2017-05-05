using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            LocationTracker provider = new LocationTracker();
            LocationReporter reporter1 = new LocationReporter("Fixed GPS");
            reporter1.Subscribe(provider);
            LocationReporter reporter2 = new LocationReporter("Mobile GPS");
            reporter2.Subscribe(provider);

            provider.TrackLocation(new Location(47.6456, -122.1312));
            reporter1.Unsubscribe();
            provider.TrackLocation(new Location(47.6677, -122.1199));
            provider.TrackLocation(null);
            provider.EndTransmission();
            Console.ReadLine();
        }
    }
}
