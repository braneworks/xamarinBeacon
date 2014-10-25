using MonoTouch.CoreLocation;
using System.Linq;

namespace iBeaconTestApp.Models
{
	public class BeaconContentManager
	{
		private static readonly BeaconContentManager _instance = new BeaconContentManager();
		private static readonly TestData _testData = new TestData();

		private BeaconContentManager ()	
		{
		}

		public static BeaconContentManager GetInstance()
		{
			return _instance;
		}

		//Calls to Services to get content
		public BeaconContent GetRegionContent(CLRegion region, CLRegionState state)
		{
			BeaconContent[] regions;
			regions = _testData.GetRegionContent ();

			var reg = (from h in regions
				where h.RegionEvent == state && h.Region == region.Identifier.ToString ()
				select h).FirstOrDefault();

			return reg as BeaconContent;
		}


		public BeaconContent GetBeaconContent(CLBeacon beacon, CLBeaconRegion region)
		{

			BeaconContent[] regions;
			regions = _testData.GetBeaconContent ();

			var r = (from h in regions
				where h.Proximity == beacon.Proximity &&  h.Major == beacon.Major.ToString() && h.Minor == beacon.Minor.ToString() && h.ProximityUuid.ToString() == beacon.ProximityUuid.AsString()
				select h).FirstOrDefault();

			if (r != null) {
				r.Proximity = beacon.Proximity;
				r.Rssi = beacon.Rssi;
				r.Accuracy = beacon.Accuracy;
			}

			return r as BeaconContent;
		}
	}
}

