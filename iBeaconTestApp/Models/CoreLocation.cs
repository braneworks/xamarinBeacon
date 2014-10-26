using System;
using MonoTouch.CoreLocation;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iBeaconTestApp.Models
{
	public class CoreLocation : CLLocationManagerDelegate
	{

		public CoreLocation(){}

		public void SetContent(BeaconContent content)
		{
			if (content != null) {
				if (UIApplication.SharedApplication.ApplicationState == UIApplicationState.Active) {
					NSNotificationCenter.DefaultCenter.PostNotificationName ("ContentUpdate", this, new NSDictionary ("Content", content));
				} else { //Application is in the background
					NotificationHelper.SendLocalAlertNotification (content);
				}
			}
		}
		public override void MonitoringFailed (CLLocationManager manager, CLRegion region, NSError error)
		{
			Console.WriteLine (error.ToString ());
		}
		public override void RegionEntered (CLLocationManager manager, CLRegion region)
		{
			Console.WriteLine ("Entered Region");
			manager.StartRangingBeacons (region as CLBeaconRegion);

			SetContent (BeaconContentManager.GetInstance().GetRegionContent(region, CLRegionState.Inside));

		}

		public override void RegionLeft (CLLocationManager manager, CLRegion region)
		{
			Console.WriteLine ("Exited Region");
			manager.StopRangingBeacons (region as CLBeaconRegion);

			SetContent (BeaconContentManager.GetInstance().GetRegionContent(region, CLRegionState.Outside));
		}

		public override void DidRangeBeacons (CLLocationManager manager, CLBeacon[] beacons, CLBeaconRegion region)
		{
			Console.WriteLine ("Ranging Beacons");

			if(beacons.Length > 0)
			{
				CLBeacon selectedBeacon = (CLBeacon)beacons.GetValue (0);
				Console.WriteLine (selectedBeacon.ProximityUuid.AsString () + " : " + selectedBeacon.Major.ToString () + " : " +
					selectedBeacon.Minor.ToString () + " : " + selectedBeacon.Proximity.ToString ());

				if (selectedBeacon.Proximity != CLProximity.Unknown && UIApplication.SharedApplication.ApplicationState == UIApplicationState.Active) {
					SetContent (BeaconContentManager.GetInstance().GetBeaconContent(selectedBeacon,region));
				}
			}
		}

		public override void DidDetermineState (CLLocationManager manager, CLRegionState state, CLRegion region)
		{
			Console.WriteLine ("DidDetermineState");

			if (state == CLRegionState.Inside)
			{
				manager.StartRangingBeacons (region as CLBeaconRegion);
			}

		}
	}
}
