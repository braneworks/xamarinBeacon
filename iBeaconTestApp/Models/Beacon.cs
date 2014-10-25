using MonoTouch.CoreLocation;
using MonoTouch.Foundation;


namespace iBeaconTestApp.Models
{
	public static class Region
	{
		static CLBeaconRegion beaconRegion;

		static Region()
		{
			beaconRegion = new CLBeaconRegion (new NSUuid (Globals.BroadCastUUid), Globals.BeaconRegion);
			beaconRegion.NotifyEntryStateOnDisplay = true;
			beaconRegion.NotifyOnEntry = true;
			beaconRegion.NotifyOnExit = true;
		}

		public static CLBeaconRegion RegionToMonitor
		{
			get
			{
				return beaconRegion;
			}
		}


	}
}

